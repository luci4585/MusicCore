namespace Desktop
{
    partial class MenuPrincipalView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            MenuPrincipal = new FontAwesome.Sharp.IconMenuItem();
            SubMenuUsuarios = new FontAwesome.Sharp.IconMenuItem();
            MenuSalir = new FontAwesome.Sharp.IconMenuItem();
            SubMenuSalir = new FontAwesome.Sharp.IconMenuItem();
            toolStrip1 = new ToolStrip();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { MenuPrincipal, MenuSalir });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // MenuPrincipal
            // 
            MenuPrincipal.DropDownItems.AddRange(new ToolStripItem[] { SubMenuUsuarios });
            MenuPrincipal.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            MenuPrincipal.IconColor = Color.Black;
            MenuPrincipal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuPrincipal.Name = "MenuPrincipal";
            MenuPrincipal.Size = new Size(81, 20);
            MenuPrincipal.Text = "Principal";
            // 
            // SubMenuUsuarios
            // 
            SubMenuUsuarios.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            SubMenuUsuarios.IconColor = Color.Black;
            SubMenuUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuUsuarios.Name = "SubMenuUsuarios";
            SubMenuUsuarios.Size = new Size(180, 22);
            SubMenuUsuarios.Text = "Usuarios";
            SubMenuUsuarios.Click += SubMenuUsuarios_Click;
            // 
            // MenuSalir
            // 
            MenuSalir.DropDownItems.AddRange(new ToolStripItem[] { SubMenuSalir });
            MenuSalir.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            MenuSalir.IconColor = Color.Black;
            MenuSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            MenuSalir.Name = "MenuSalir";
            MenuSalir.Size = new Size(57, 20);
            MenuSalir.Text = "Salir";
            // 
            // SubMenuSalir
            // 
            SubMenuSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            SubMenuSalir.IconColor = Color.Black;
            SubMenuSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            SubMenuSalir.Name = "SubMenuSalir";
            SubMenuSalir.Size = new Size(158, 22);
            SubMenuSalir.Text = "Salir del sistema";
            SubMenuSalir.Click += SubMenuSalir_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 2;
            toolStrip1.Text = "toolStrip1";
            // 
            // MenuPrincipalView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "MenuPrincipalView";
            Text = "Music Core : Tienda de discos musicales";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private FontAwesome.Sharp.IconMenuItem MenuPrincipal;
        private ToolStrip toolStrip1;
        private FontAwesome.Sharp.IconMenuItem MenuSalir;
        private FontAwesome.Sharp.IconMenuItem SubMenuSalir;
        private FontAwesome.Sharp.IconMenuItem SubMenuUsuarios;
    }
}
