using Desktop.Views;

namespace Desktop
{
    public partial class MenuPrincipalView : Form
    {
        public MenuPrincipalView()
        {
            InitializeComponent();
        }

        private void SubMenuSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SubMenuUsuarios_Click(object sender, EventArgs e)
        {
            var usuariosView = new UsuariosView();
            usuariosView.MdiParent = this;
            usuariosView.Show();
        }

        private void SubMenuDisco_Click(object sender, EventArgs e)
        {
            var discosView = new DiscosView();
            discosView.MdiParent = this;
            discosView.Show();
        }

        private void SubMenuVenta_Click(object sender, EventArgs e)
        {
            var ventasView = new VentasView();
            ventasView.MdiParent = this;
            ventasView.Show();
        }
    }
}
