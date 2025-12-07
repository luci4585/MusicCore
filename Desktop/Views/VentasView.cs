using Desktop.ExtensionMethod;
using Service.Models;
using Service.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Views
{
    public partial class VentasView : Form
    {
        GenericService<Disco> _discoService = new GenericService<Disco>();
        GenericService<Cliente> _clienteService = new GenericService<Cliente>();
        GenericService<Venta> _ventaService = new GenericService<Venta>();


        Venta _currentVenta;
        List<Disco>? _discos;
        List<Cliente>? _clientes;
        List<Venta>? _ventas;


        public VentasView()
        {
            InitializeComponent();
            _ = GetAllData();
            CheckVerEliminados.CheckedChanged += DisplayHideControlsRestoreButton;
        }

        private void DisplayHideControlsRestoreButton(object? sender, EventArgs e)
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
            await GetComboCliente();
            await GetComboDisco();

            if (CheckVerEliminados.Checked)
            {
                _ventas = await _ventaService.GetAllDeletedsAsync();
            }
            else
            {
                _ventas = await _ventaService.GetAllAsync();
            }
            GridVentas.DataSource = _ventas;

            if (GridVentas.Columns.Contains("Disco"))
                GridVentas.Columns["Disco"].Visible = false;

            if (!GridVentas.Columns.Contains("DiscoTitulo"))
                GridVentas.Columns.Add("DiscoTitulo", "Disco");

            foreach (DataGridViewRow row in GridVentas.Rows)
            {
                var venta = row.DataBoundItem as Venta;
                if (venta != null)
                    row.Cells["DiscoTitulo"].Value = venta.Disco?.Titulo;
            }

            if (GridVentas.Columns.Contains("Disco"))
                GridVentas.Columns["Disco"].Visible = false;

            if (!GridVentas.Columns.Contains("DiscoTitulo"))
                GridVentas.Columns.Add("DiscoTitulo", "Disco");

            foreach (DataGridViewRow row in GridVentas.Rows)
            {
                var venta = row.DataBoundItem as Venta;
                if (venta != null)
                    row.Cells["DiscoTitulo"].Value = venta.Disco?.Titulo;
            }

            GridVentas.HideColumns("Id", "ClienteId", "UsuarioId", "DiscoId", "IsDeleted", "Precio");
            GridVentas.Columns["Precio"].DefaultCellStyle.Format = "C2";

            if (GridVentas.Columns.Contains("Fecha"))
            {
                GridVentas.Columns["Fecha"].DefaultCellStyle.Format = "dd/MM/yyyy";
            }
        }

        private async Task GetComboDisco()
        {
            _discos= await _discoService.GetAllAsync();
            ComboDisco.DataSource = _discos;
            ComboDisco.DisplayMember = "Titulo";
            ComboDisco.ValueMember = "Id";
            ComboDisco.SelectedIndex = -1;

            ComboDisco.BindingContext = new BindingContext();
        }

        private async Task GetComboCliente()
        {
            _clientes = await _clienteService.GetAllAsync();
            ComboCliente.DataSource = _clientes;
            ComboCliente.DisplayMember = "Nombre";
            ComboCliente.ValueMember = "Id";
            ComboCliente.SelectedIndex = -1;

            ComboCliente.BindingContext = new BindingContext();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnEliminar_Click(object sender, EventArgs e)
        {
            //chequeamos que haya películas seleccionadas
            if (GridVentas.Rows.Count > 0 && GridVentas.SelectedRows.Count > 0)
            {
                Venta entitySelected = (Venta)GridVentas.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Está seguro de eliminar la venta seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (await _ventaService.DeleteAsync(entitySelected.Id))
                    {
                        LabelStatusMessage.Text = $"Venta eliminada correctamente";
                        TimerStatusBar.Start();
                        await GetAllData();
                    }
                    else
                    {
                        MessageBox.Show("Error al eliminar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una venta para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            LimpiarControlesAgregarEditar();
            TabControl.SelectedTab=TabPageAgregarEditar;
        }

        private void LimpiarControlesAgregarEditar()
        {
            NumericCantidad.Value = NumericCantidad.Minimum;
            ComboDisco.SelectedIndex = -1;
            ComboCliente.SelectedIndex = -1;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab("TabPageLista");
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            Venta ventaAGuardar = new Venta
            {
                Id = _currentVenta?.Id ?? 0,
                Cantidad = (int)NumericCantidad.Value,
                ClienteId = (int)(ComboCliente.SelectedValue ?? 0),
                DiscoId = (int)(ComboDisco.SelectedValue ?? 0),
                UsuarioId = _currentVenta?.UsuarioId > 0
                ? _currentVenta.UsuarioId 
                : 1
            };

            ventaAGuardar.Cliente = _currentVenta?.Cliente;
            ventaAGuardar.Usuario = _currentVenta?.Usuario;
            ventaAGuardar.Disco = _currentVenta?.Disco;

            bool response = false;

            // si Id > 0 → es modificación
            if (_currentVenta != null && _currentVenta.Id > 0)
            {
                response = await _ventaService.UpdateAsync(ventaAGuardar);
            }
            else
            {
                var nuevaVenta = await _ventaService.AddAsync(ventaAGuardar);
                response = nuevaVenta != null;
            }

            if (response)
            {
                _currentVenta = null;
                LabelStatusMessage.Text = $"Venta guardada correctamente";
                TimerStatusBar.Start();
                await GetAllData();
                LimpiarControlesAgregarEditar();
                TabControl.SelectedTab = TabPageLista;
            }
            else
            {
                MessageBox.Show("Error al agregar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (GridVentas.RowCount > 0 && GridVentas.SelectedRows.Count > 0)
            {
                _currentVenta = (Venta)GridVentas.SelectedRows[0].DataBoundItem;
                NumericCantidad.Value = _currentVenta.Cantidad;
                ComboCliente.SelectedValue = _currentVenta.ClienteId;
                ComboDisco.SelectedValue = _currentVenta.DiscoId;
                TabControl.SelectedTab = TabPageAgregarEditar;

            }
            else
            {
                MessageBox.Show("Debe seleccionar una venta para modificarla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            GridVentas.DataSource = _discos.Where(p => p.Titulo.ToUpper().Contains(TxtBuscar.Text.ToUpper())).ToList();
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

        private void GridVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridVentas.RowCount > 0 && GridVentas.SelectedRows.Count > 0)
            {
                //Venta _curr = (Venta)GridVentas.SelectedRows[0].DataBoundItem;
            }
        }

        private async void BtnRestaurar_Click(object sender, EventArgs e)
        {
            if (!CheckVerEliminados.Checked) return;

            if (GridVentas.Rows.Count > 0 && GridVentas.SelectedRows.Count > 0)
            {
                Venta entitySelected = (Venta)GridVentas.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Está seguro de recuperar la venta seleccionada?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (await _ventaService.RestoreAsync(entitySelected.Id))
                    {
                        LabelStatusMessage.Text = $"Venta {entitySelected} restaurada correctamente";
                        TimerStatusBar.Start();
                        await GetAllData();
                    }
                    else
                    {
                        MessageBox.Show("Error al restaurar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe seleccionar una venta para restaurar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void CheckVerEliminados_CheckedChanged(object sender, EventArgs e)
        {
            await GetAllData();
        }
    }
}
