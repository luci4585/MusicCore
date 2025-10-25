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
            CheckVerEliminadoss.CheckedChanged += DisplayHideControlsRestoreButton;
        }

        private void DisplayHideControlsRestoreButton(object? sender, EventArgs e)
        {
            BtnRestaurarr.Visible = CheckVerEliminadoss.Checked;
            BtnEliminarr.Enabled = !CheckVerEliminadoss.Checked;
            BtnModificarr.Enabled = !CheckVerEliminadoss.Checked;
            BtnAgregarr.Enabled = !CheckVerEliminadoss.Checked;
            BtnModificarr.Enabled = !CheckVerEliminadoss.Checked;
            BtnBuscarr.Enabled = !CheckVerEliminadoss.Checked;
        }

        private async Task GetAllData()
        {
            GetComboCliente();
            GetComboDisco();
            _clientes = await _clienteService.GetAllAsync();
            if (CheckVerEliminadoss.Checked)
            {
                _ventas = await _ventaService.GetAllDeletedsAsync();
            }
            else
            {
                _ventas = await _ventaService.GetAllAsync();
            }
            var ventasParaMostrar = _ventas.Select(v => new
    {
                Fecha = v.Fecha.ToShortDateString(),
                Precio = Math.Round(v.Precio, 2),
                Cliente = _clientes.FirstOrDefault(c => c.Id == v.ClienteId)?.Nombre,
                Disco = _discos.FirstOrDefault(d => d.Id == v.DiscoId)?.Titulo,
                Cantidad = v.Cantidad
            }).ToList();

            GridVentas.DataSource = ventasParaMostrar;
        }

        private async Task GetComboDisco()
        {
            _discos= await _discoService.GetAllAsync();
            ComboDisco.DataSource = _discos;
            ComboDisco.DisplayMember = "Nombre";
            ComboDisco.ValueMember = "Id";
            ComboDisco.SelectedIndex = -1;
        }

        private async Task GetComboCliente()
        {
            _clientes = await _clienteService.GetAllAsync();
            ComboCliente.DataSource = _clientes;
            ComboCliente.DisplayMember = "Nombre";
            ComboCliente.ValueMember = "Id";
            ComboCliente.SelectedIndex = -1;
        }

        private void BtnSalirr_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void BtnEliminarr_Click(object sender, EventArgs e)
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
                        TimerStatusBarr.Start();
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

        private void BtnAgregarr_Click(object sender, EventArgs e)
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

        private void BtnCancelarr_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab("TabPageLista");
        }

        private async void BtnGuardarr_Click(object sender, EventArgs e)
        {
            Venta ventaAGuardar = new Venta
            {
                Id = _currentVenta?.Id ?? 0,
                Cantidad = (int)NumericCantidad.Value,
                ClienteId= (int)(ComboCliente.SelectedValue ?? 0),
                DiscoId= (int)(ComboDisco.SelectedValue ?? 0)

            };
            bool response = false;
            if (_currentVenta != null)
            {
                response = await _ventaService.UpdateAsync(ventaAGuardar);
            }
            else
            {
                var nuevaventa = await _ventaService.AddAsync(ventaAGuardar);
                response = nuevaventa != null;
            }
            if (response)
            {
                _currentVenta = null; // Reset the modified movie after saving
                LabelStatusMessage.Text = $"Venta {ventaAGuardar} guardada correctamente";
                TimerStatusBarr.Start(); // Iniciar el temporizador para mostrar el mensaje en la barra de estado
                await GetAllData();
                LimpiarControlesAgregarEditar();
                TabControl.SelectedTab = TabPageLista;
            }
            else
            {
                MessageBox.Show("Error al agregar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnModificarr_Click(object sender, EventArgs e)
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

        private async void BtnBuscarr_Click(object sender, EventArgs e)
        {
            GridVentas.DataSource = _discos.Where(p => p.Titulo.ToUpper().Contains(TxtBuscarr.Text.ToUpper())).ToList();
        }

        private void TxtBuscarr_TextChanged(object sender, EventArgs e)
        {

        }

        private void TimerStatusBarr_Tick(object sender, EventArgs e)
        {
            LabelStatusMessage.Text = string.Empty;
            TimerStatusBarr.Stop();
        }

        private void GridVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridVentas.RowCount > 0 && GridVentas.SelectedRows.Count > 0)
            {
                //Venta _curr = (Venta)GridVentas.SelectedRows[0].DataBoundItem;
            }
        }

        private async void BtnRestaurarr_Click(object sender, EventArgs e)
        {
            if (!CheckVerEliminadoss.Checked) return;

            if (GridVentas.Rows.Count > 0 && GridVentas.SelectedRows.Count > 0)
            {
                Venta entitySelected = (Venta)GridVentas.SelectedRows[0].DataBoundItem;
                var respuesta = MessageBox.Show($"¿Está seguro de recuperar la venta {entitySelected} seleccionado?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    if (await _ventaService.RestoreAsync(entitySelected.Id))
                    {
                        LabelStatusMessage.Text = $"Venta {entitySelected} restaurada correctamente";
                        TimerStatusBarr.Start();
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

        private async void CheckVerEliminadoss_CheckedChanged(object sender, EventArgs e)
        {
            await GetAllData();
        }
    }
}
