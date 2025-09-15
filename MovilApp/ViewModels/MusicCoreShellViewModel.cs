using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using MovilApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovilApp.ViewModels
{
    public partial class MusicCoreShellViewModel : ObservableObject
    {
        [ObservableProperty]
        private bool userIsLogout = true;

        public IRelayCommand LogoutCommand { get; }

        public MusicCoreShellViewModel()
        {
            LogoutCommand = new RelayCommand(OnLogout);
        }

        private void OnLogout()
        {
            userIsLogout = true;
            var musicCoreShell = (MusicCoreShell)App.Current.MainPage;
            //musicCoreShell.DisableAppAfterLogin();
        }
    }
}


