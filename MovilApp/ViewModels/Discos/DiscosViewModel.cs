using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Service.Services;
using Service.Models;


namespace MovilApp.ViewModels.Discos
{
    partial class DiscosViewModel:ObservableObject
    {
        GenericService<Disco> _discoService = new();

        [ObservableProperty]
        private string textoBusqueda = string.Empty;

        [ObservableProperty]
        private bool estaDescargando;

        [ObservableProperty]
        private ObservableCollection<Disco> discos = new();

        public IRelayCommand BuscarCommand { get; }
        public IRelayCommand LimpiarCommand { get; }

        public DiscosViewModel()
        {
            BuscarCommand = new RelayCommand(OnBuscar);
            LimpiarCommand = new RelayCommand(OnLimpiar);
            _ = InicializarAsync();
        }

        private async Task InicializarAsync()
        {
            OnBuscar();
        }


        private async void OnBuscar()
        {
            if (EstaDescargando) return;

            try
            {
                EstaDescargando = true;

                // Obtener todos los libros si no los tenemos
                var discos = await _discoService.GetAllAsync(TextoBusqueda);

                Discos = discos != null ?
                        new ObservableCollection<Disco>(discos)
                        : new ObservableCollection<Disco>();
            }
            finally
            {
                EstaDescargando = false;
            }
        }



        private void OnLimpiar()
        {
            TextoBusqueda = string.Empty;
            // Mantener los filtros pero ejecutar búsqueda limpia
            OnBuscar();
        }
    }
}
