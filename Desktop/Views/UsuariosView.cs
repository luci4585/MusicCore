using Firebase.Auth;
using Firebase.Auth.Providers;
using Newtonsoft.Json.Linq;
using Service.Enums;
using Service.Models;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Net.Http.Headers;
using System.Windows.Controls;

namespace Desktop.Views
{
    public partial class UsuariosView : Form
    {
        FirebaseAuthClient _firebaseAuthClient;
        GenericService<Usuario> _usuarioService = new ();
        Usuario _currentUsuario;
        List<Usuario>? _usuarios;

        public UsuariosView()
        {
            InitializeComponent();
            _ = GetAllData();
            SettingFirebase();
            CheckVerEliminados.CheckedChanged += DisplayHideControlsRestoreButton;
        }

        private void SettingFirebase()
        {
            var config = new FirebaseAuthConfig()
            {
                ApiKey = Service.Properties.Resources.ApiKeyFirebase,
                AuthDomain = Service.Properties.Resources.AuthDomainFirebase,
                Providers = new FirebaseAuthProvider[]
                {
                    new EmailProvider()

                }
            };
            _firebaseAuthClient = new FirebaseAuthClient(config);
        }

        private void DisplayHideControlsRestoreButton(object sender, EventArgs e)
        {
            BtnRestaurar.Visible = CheckVerEliminados.Checked;
            BtnEliminar.Enabled = !CheckVerEliminados.Checked;
            BtnModificar.Enabled = !CheckVerEliminados.Checked;
            BtnAgregar.Enabled = !CheckVerEliminados.Checked;
            BtnModificar.Enabled = !CheckVerEliminados.Checked;
            BtnBuscar.Enabled = !CheckVerEliminados.Checked;

        }

        private async Task GetAllData()
        {
            if (CheckVerEliminados.Checked)
            {
                _usuarios = await _usuarioService.GetAllDeletedsAsync();
            }
            else
            {
                _usuarios = await _usuarioService.GetAllAsync();
            }
            GridUsuarios.DataSource = _usuarios;
            GridUsuarios.Columns["Id"].Visible = false;
            GridUsuarios.Columns["IsDeleted"].Visible = false;
            GetComboTiposDeUsuarios();
        }

        private void GetComboTiposDeUsuarios()
        {
            //cargo el combo tipos de usuarios con el enum TipoUsuario
            ComboTiposDeUsuarios.DataSource = Enum.GetValues(typeof(TipoUsuarioEnum));
        }

        private async void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            //chequeamos que haya usuarios seleccionados
            if (GridUsuarios.Rows.Count > 0 && GridUsuarios.SelectedRows.Count > 0)
            {
                Usuario entitySelected = (Usuario)GridUsuarios.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Está seguro de eliminar el usuario {entitySelected.NombreUsuario} seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (await _usuarioService.DeleteAsync(entitySelected.Id))
                    {
                        LabelStatusMessage.Text = $"Usuario {entitySelected.NombreUsuario} eliminado correctamente";
                        TimerStatusBar.Start();
                        await GetAllData();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarControlesAgregarEditar();
            TabControl.SelectTab("TabpageAgregarEditar");
        }
        private void LimpiarControlesAgregarEditar()
        {
            TxtNombreyApellido.Clear();
            TxtEmail.Clear();
            TxtPassword.Clear();
            TxtPassword2.Clear();
            GetComboTiposDeUsuarios();
            LabelPassword.Text = "Contraseña:";
            LabelPassword2.Text = "Repetir contraseña:";
            TxtPassword.PlaceholderText= "Mínimo 6 caracteres";
            TxtPassword2.PlaceholderText= "Mínimo 6 caracteres";
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab("TabPageLista");
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (!DataControl())
                return;
            Usuario usuarioAGuardar = GetUserDataFromScreen();
            bool responseSuccessfull = false;
            if (_currentUsuario != null)//modificando un usuario existente
            {
                responseSuccessfull = await _usuarioService.UpdateAsync(usuarioAGuardar);
                if (responseSuccessfull && !string.IsNullOrWhiteSpace(TxtPassword.Text))
                    await UpdatePasswordInFirebase(usuarioAGuardar);// Actualizar pass en Firebase
            }

            if (_currentUsuario == null)//agregando un nuevo usuario
            {
                try
                {
                    var nuevoUsuario = await _usuarioService.AddAsync(usuarioAGuardar);
                    responseSuccessfull = nuevoUsuario != null;
                    if (responseSuccessfull)
                        await CreateUserInFirebase(nuevoUsuario);// Crear el usuario en Firebase Authentication
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el usuario: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            if (!responseSuccessfull)
            {
                MessageBox.Show("Error al guardar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _currentUsuario = null; // Reset the modified movie after saving
            LabelStatusMessage.Text = $"Usuario {usuarioAGuardar.NombreUsuario} guardado correctamente";
            TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
            await GetAllData();
            LimpiarControlesAgregarEditar();
            TabControl.SelectedTab = TabPageLista;
        }

        private async Task CreateUserInFirebase(Usuario? nuevoUsuario)
        {

            try
            {
                var userCredential = await _firebaseAuthClient.CreateUserWithEmailAndPasswordAsync(
                    nuevoUsuario.Email,
                    TxtPassword.Text.Trim(),
                    nuevoUsuario.NombreUsuario + " " + nuevoUsuario// Contraseña por defecto, se recomienda cambiarla luego
                );
                await SendEmailVerificationAsync(userCredential.User.GetIdTokenAsync().Result); // Enviar correo de verificación
            }
            catch (FirebaseAuthException ex)
            {
                MessageBox.Show($"Error al crear el usuario en Firebase: {ex.Reason}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task SendEmailVerificationAsync(string idToken)
        {
            var FirebaseApiKey = Service.Properties.Resources.ApiKeyFirebase;
            var RequestUri = "https://identitytoolkit.googleapis.com/v1/accounts:sendOobCode?key=" + FirebaseApiKey;

            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                var content = new StringContent("{\"requestType\":\"VERIFY_EMAIL\",\"idToken\":\"" + idToken + "\"}");
                content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

                var response = await client.PostAsync(RequestUri, content);
                response.EnsureSuccessStatusCode();
            }
        }

        private async Task UpdatePasswordInFirebase(Usuario usuarioAGuardar)
        {
            try
            {
                var userCredential = await _firebaseAuthClient.SignInWithEmailAndPasswordAsync(
                    usuarioAGuardar.Email,
                    TxtPassword.Text.Trim()
                );
                await userCredential.User.ChangePasswordAsync(TxtPassword2.Text.Trim());

            }
            catch (FirebaseAuthException ex)
            {
                MessageBox.Show($"Error al actualizar la contraseña en Firebase: {ex.Reason}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Usuario GetUserDataFromScreen()
        {
            return new Usuario
            {
                Id = _currentUsuario?.Id ?? 0,
                NombreUsuario = TxtNombreyApellido.Text,
                Email = TxtEmail.Text,
                TipoUsuario = (TipoUsuarioEnum)(ComboTiposDeUsuarios.SelectedItem ?? TipoUsuarioEnum.Administrador)
                //operador de coalescencia nula por si no hay nada seleccionado en el combo, asigna Asistente por defecto
            };
        }

        private bool DataControl()
        {
            // Validaciones básicas
            if (string.IsNullOrWhiteSpace(TxtNombreyApellido.Text))
            {
                MessageBox.Show("El nombre y apellido son obligatorios.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(TxtEmail.Text))
            {
                MessageBox.Show("El email es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_currentUsuario == null && (TxtPassword.Text!=TxtPassword2.Text))
            {
                MessageBox.Show("Las contraseñas ingresadas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_currentUsuario == null && (string.IsNullOrWhiteSpace(TxtPassword.Text) || string.IsNullOrWhiteSpace(TxtPassword2.Text)))
            {
                MessageBox.Show("Debe completar el campo contraseña y verificación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (_currentUsuario != null && (string.IsNullOrWhiteSpace(TxtPassword.Text) && string.IsNullOrWhiteSpace(TxtPassword2.Text)))//modificacion que no cambia la contraseña
            {
                return true;
            }
            if (_currentUsuario != null && (string.IsNullOrWhiteSpace(TxtPassword.Text)||string.IsNullOrWhiteSpace(TxtPassword2.Text)))
            {
                MessageBox.Show("Para modificar la contraseña debe completar la anterior y la nueva", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if ((TxtPassword.Text.Length<6)||(TxtPassword2.Text.Length<6))
            {
                MessageBox.Show("Las contraseñas deben tener al menos 6 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (GridUsuarios.RowCount > 0 && GridUsuarios.SelectedRows.Count > 0)
            {
                _currentUsuario = (Usuario)GridUsuarios.SelectedRows[0].DataBoundItem;
                TxtNombreyApellido.Text = _currentUsuario.NombreUsuario;
                TxtEmail.Text = _currentUsuario.Email;
                ComboTiposDeUsuarios.SelectedItem = _currentUsuario.TipoUsuario;

                LabelPassword.Text = "Contraseña anterior:";
                LabelPassword2.Text = "Nueva contraseña:";
                TxtPassword.PlaceholderText = "Dejar en blanco para no modificar";
                TxtPassword2.PlaceholderText = "Dejar en blanco para no modificar";
                TabControl.SelectedTab = TabPageAgregarEditar;

            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario para modificarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            GridUsuarios.DataSource = _usuarios.Where(p => p.NombreUsuario.ToUpper().Contains(TxtBuscar.Text.ToUpper())).ToList();
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            //BtnBuscar.PerformClick();
        }

        private void TimerStatusBar_Tick(object sender, EventArgs e)
        {
            LabelStatusMessage.Text = string.Empty;
            TimerStatusBar.Stop();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GridDiscos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridUsuarios.RowCount > 0 && GridUsuarios.SelectedRows.Count > 0)
            {
                //Disco _curr = (Disco)GridDiscos.SelectedRows[0].DataBoundItem;
            }
        }

        private async void BtnRestaurar_Click(object sender, EventArgs e)
        {
            if (!CheckVerEliminados.Checked) return;

            if (GridUsuarios.Rows.Count > 0 && GridUsuarios.SelectedRows.Count > 0)
            {
                Usuario entitySelected = (Usuario)GridUsuarios.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Está seguro de recuperar el usuario {entitySelected.NombreUsuario} seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (await _usuarioService.RestoreAsync(entitySelected.Id))
                    {
                        LabelStatusMessage.Text = $"Usuario {entitySelected.NombreUsuario} restaurado correctamente";
                        TimerStatusBar.Start();
                        await GetAllData();
                    }
                    else
                    {
                        MessageBox.Show("Error al restaurar el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un usuario para restaurar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CheckVerEliminados_CheckedChanged(object sender, EventArgs e)
        {
            await GetAllData();
        }


    }
} 
