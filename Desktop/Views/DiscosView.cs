using Service.Models;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Controls;

namespace Desktop.Views
{
    public partial class DiscosView : Form
    {
        GenericService<Disco> _discoService = new GenericService<Disco>();
        Disco _currentDisco;
        List<Disco>? _discos;

        public DiscosView()
        {
            InitializeComponent();
            _=GetAllData();
            CheckVerEliminados.CheckedChanged += DisplayHideControlsRestoreButton;
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
                _discos = await _discoService.GetAllDeletedsAsync();
            }
            else
            { 
                _discos = await _discoService.GetAllAsync();
            }
            GridDiscos.DataSource = _discos;
            GridDiscos.Columns["Id"].Visible = false;
            GridDiscos.Columns["IsDeleted"].Visible = false;
        }

        private async void BtnEliminar_Click_1(object sender, EventArgs e)
        {
            //chequeamos que haya películas seleccionadas
            if (GridDiscos.Rows.Count > 0 && GridDiscos.SelectedRows.Count > 0)
            {
                Disco entitySelected = (Disco)GridDiscos.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Está seguro de eliminar el disco {entitySelected.Titulo} seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (await _discoService.DeleteAsync(entitySelected.Id))
                    {
                        LabelStatusMessage.Text = $"Disco {entitySelected.Titulo} eliminado correctamente";
                        TimerStatusBar.Start();
                        await GetAllData();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar el disco", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un disco para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarControlesAgregarEditar();
            TabControl.SelectTab("TabpageAgregarEditar");
        }
        private void LimpiarControlesAgregarEditar()
        {
            TxtTitulo.Clear();
            TxtArtista.Clear();
            TxtGenero.Clear();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab("TabPageLista");
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            Disco discoAGuardar = new Disco
            {
                Id = _currentDisco?.Id ?? 0,
                Titulo = TxtTitulo.Text,
                Artista = new Artista { Nombre = TxtArtista.Text },
                Genero = new Genero { Nombre = TxtGenero.Text }

            };
            bool response = false;
            if (_currentDisco != null)
            {
                response = await _discoService.UpdateAsync(discoAGuardar);
            }
            else
            {
                var nuevacapacitacion = await _discoService.AddAsync(discoAGuardar);
                response = nuevacapacitacion != null;
            }
            if (response)
            {
                _currentDisco = null; // Reset the modified movie after saving
                LabelStatusMessage.Text = $"Disco {discoAGuardar.Titulo} guardado correctamente";
                TimerStatusBar.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                await GetAllData();
                LimpiarControlesAgregarEditar();
                TabControl.SelectedTab = TabPageLista;
            }
            else
            {
                MessageBox.Show("Error al agregar la capacitacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (GridDiscos.RowCount > 0 && GridDiscos.SelectedRows.Count > 0)
            {
                _currentDisco = (Disco)GridDiscos.SelectedRows[0].DataBoundItem;
                TxtTitulo.Text = _currentDisco.Titulo;
                TxtArtista.Text = _currentDisco.Artista?.Nombre ?? string.Empty;
                TxtGenero.Text = _currentDisco.Genero?.Nombre ?? string.Empty;
                TabControl.SelectedTab = TabPageAgregarEditar;

            }
            else
            {
                MessageBox.Show("Debe seleccionar una Capacitacion para modificarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            GridDiscos.DataSource = await _discoService.GetAllAsync(TxtBuscar.Text);
        }

        private void TxtBuscar_TextChanged(object sender, EventArgs e)
        {
            BtnBuscar.PerformClick();
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
            if (GridDiscos.RowCount > 0 && GridDiscos.SelectedRows.Count > 0)
            {
                //Disco _curr = (Disco)GridDiscos.SelectedRows[0].DataBoundItem;
            }
        }

        private async void BtnRestaurar_Click(object sender, EventArgs e)
        {
            if (!CheckVerEliminados.Checked) return;

            if (GridDiscos.Rows.Count > 0 && GridDiscos.SelectedRows.Count > 0)
            {
                Disco entitySelected = (Disco)GridDiscos.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Está seguro de recuperar el disco {entitySelected.Titulo} seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (await _discoService.RestoreAsync(entitySelected.Id))
                    {
                        LabelStatusMessage.Text = $"Capacitación {entitySelected.Titulo} restaurada correctamente";
                        TimerStatusBar.Start();
                        await GetAllData();
                    }
                    else
                    {
                        MessageBox.Show("Error al restaurar la capacitacion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una capacitación para restaurar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CheckVerEliminados_CheckedChanged(object sender, EventArgs e)
        {
            await GetAllData();
        }
    }
} 
