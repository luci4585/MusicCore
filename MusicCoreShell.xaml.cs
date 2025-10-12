using MovilApp.ViewModels;
using MovilApp.Views.Login;

namespace MovilApp.Views
{
    public partial class MusicCoreShell : Shell
    {
        public MusicCoreShellViewModel ViewModel => (MusicCoreShellViewModel)BindingContext;

        public MusicCoreShell()
        {
            InitializeComponent();
        }
        public void SetLoginState(bool isLoggedIn)
        {
            ViewModel.SetLoginState(isLoggedIn);

        }
    }
}