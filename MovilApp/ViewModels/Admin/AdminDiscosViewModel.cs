using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Service.Models;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovilApp.ViewModels.Admin
{
    partial class AdminDiscosViewModel : ObservableObject
    {
        GenericService<Disco> _discoService = new();

        [ObservableProperty]
        private ObservableCollection<Disco> discos;

        [ObservableProperty]
        [NotifyCanExecuteChangedFor(nameof(EditCommand))]
        [NotifyCanExecuteChangedFor(nameof(DeleteCommand))]
        private Disco discoCurrent;

        [ObservableProperty]
        private bool isRefreshing;

        [ObservableProperty]
        private string filterText;

        public IRelayCommand AddCommand { get; }
        public IRelayCommand EditCommand { get; }
        public IRelayCommand DeleteCommand { get; }
        public IRelayCommand RefreshCommand { get; }

        public AdminDiscosViewModel()
        {
            _ = LoadDiscos();
            AddCommand = new AsyncRelayCommand(AddDisco);
            EditCommand = new AsyncRelayCommand(EditDisco, CanEditDisco);
            DeleteCommand = new AsyncRelayCommand(DeleteDisco, CanDeleteDisco);
            RefreshCommand = new AsyncRelayCommand(LoadDiscos);
        }

        private bool CanDeleteDisco()
        {
            return discoCurrent != null;
        }

        private async Task DeleteDisco()
        {
            throw new NotImplementedException();
        }

        private bool CanEditDisco()
        {
            return discoCurrent != null;
        }

        private async Task EditDisco()
        {
            throw new NotImplementedException();
        }

        private async Task AddDisco()
        {
            throw new NotImplementedException();
        }

        private async Task LoadDiscos()
        {
            IsRefreshing = true;
            var discos = await _discoService.GetAllAsync();
            Discos = discos != null ? new ObservableCollection<Disco>(discos) : new ObservableCollection<Disco>();
            IsRefreshing = false;
        }
    }
}
