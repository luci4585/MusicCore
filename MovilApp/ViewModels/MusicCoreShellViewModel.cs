﻿using CommunityToolkit.Mvvm.ComponentModel;
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
        private bool userIsLogged = true;

        public IRelayCommand LogoutCommand { get; }

        public MusicCoreShellViewModel()
        {
            LogoutCommand = new RelayCommand(OnLogout);
            SetLoginState(false);
        }

        public void SetLoginState(bool isLoggedIn)
        {
            if (Application.Current?.MainPage is MusicCoreShell shell)
            {
                if (isLoggedIn)
                    shell.FlyoutBehavior = FlyoutBehavior.Flyout;
                else
                    shell.FlyoutBehavior = FlyoutBehavior.Disabled;

                UserIsLogged = isLoggedIn;
                if (isLoggedIn)
                    shell.GoToAsync("//MainPage");  // Cambio a MainPage (pantalla de inicio)
                else
                    shell.GoToAsync("//Login");
            }

        }

        private void OnLogout()
        {
            SetLoginState(false);
        }
    }
}


