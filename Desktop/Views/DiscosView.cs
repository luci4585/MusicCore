using System;
using System.Collections.Generic;
using System.Data;
using Service.Models;
using Service.Services;

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
        }

        private async Task GetAllData()
        {
            _discos = await _discoService.GetAllAsync();
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
            NumericDuracion.Value = 0;
            NumericCalificacion.Value = 0;
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            TabControl.SelectTab("TabPageLista");
        }

        private async void BtnGuardar_Click(object sender, EventArgs e)
        {
            //Pelicula peliculaAGuardar = new Pelicula
            //{
            //    id = peliculaModificada?.id ?? null,
            //    titulo = TxtTitulo.Text,
            //    duracion = (int)NumericDuracion.Value,
            //    portada = TxtPortada.Text,
            //    calificacion = (double)NumericCalificacion.Value,
            //    PaisId = (int?)ComboPaises.SelectedValue
            //};

            //bool response;
            //if (peliculaModificada != null)
            //{
            //    response = await peliculaService.UpdateAsync(peliculaAGuardar);
            //}
            //else
            //{
            //    response = await peliculaService.AddAsync(peliculaAGuardar);
            //}
            //if (response)
            //{
            //    peliculaModificada = null; // Reiniciamos la variable para futuras inserciones
            //    LabelStatusMessage.Text = "Película modificada correctamente";
            //    TimerStatusBar.Start();
            //    ObtenemosPeliculas();
            //    LimpiarControlesAgregarEditar();
            //    TabControl.SelectTab("TabPageLista");
            //}
            //else
            //{
            //    MessageBox.Show("Error al agregar la pelicula", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void BtnModificar_Click(object sender, EventArgs e)
        {
            //chequeamos que haya películas seleccionadas
            //if (GridPeliculas.RowCount > 0 && GridPeliculas.SelectedRows.Count > 0)
            //{
            //    peliculaModificada = (Pelicula)GridPeliculas.SelectedRows[0].DataBoundItem;
            //    TxtTitulo.Text = peliculaModificada.titulo;
            //    NumericDuracion.Value = peliculaModificada.duracion;
            //    TxtPortada.Text = peliculaModificada.portada;
            //    NumericCalificacion.Value = (decimal)peliculaModificada.calificacion;
            //    //asignar el país seleccionado en el combo
            //    if (peliculaModificada.PaisId != null)
            //    {
            //        ComboPaises.SelectedValue = peliculaModificada.PaisId;
            //    }
            //    else
            //    {
            //        ComboPaises.SelectedIndex = -1;
            //    }
            //    TabControl.SelectTab("TabpageAgregarEditar");
            //}
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            // GridPeliculas.DataSource = peliculas.Where(p => p.titulo.ToUpper().Contains(TxtBuscar.Text.ToUpper())).ToList();
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
                //Capacitacion _curr = (Pelicula)GridPeliculas.SelectedRows[0].DataBoundItem;
                //FilmPicture.ImageLocation = peliculaSeleccionada.portada;
            }
        }
    }
} 
