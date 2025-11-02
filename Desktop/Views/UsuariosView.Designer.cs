namespace Desktop.Views
{
    partial class UsuariosView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TimerStatusBar = new System.Windows.Forms.Timer(components);
            TabPageAgregarEditar = new TabPage();
            label3 = new Label();
            TxtNombreyApellido = new TextBox();
            ComboTiposDeUsuarios = new ComboBox();
            label5 = new Label();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            TabPageLista = new TabPage();
            CheckVerEliminados = new CheckBox();
            BtnRestaurar = new FontAwesome.Sharp.IconButton();
            BtnEliminar = new FontAwesome.Sharp.IconButton();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            TxtBuscar = new TextBox();
            label2 = new Label();
            BtnSalir = new FontAwesome.Sharp.IconButton();
            BtnModificar = new FontAwesome.Sharp.IconButton();
            BtnAgregar = new FontAwesome.Sharp.IconButton();
            GridUsuarios = new DataGridView();
            TabControl = new TabControl();
            label1 = new Label();
            panel1 = new Panel();
            LabelStatusMessage = new ToolStripStatusLabel();
            statusStrip1 = new StatusStrip();
            TxtPassword2 = new TextBox();
            LabelPassword2 = new Label();
            TxtPassword = new TextBox();
            LabelPassword = new Label();
            TxtEmail = new TextBox();
            label4 = new Label();
            TabPageAgregarEditar.SuspendLayout();
            TabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridUsuarios).BeginInit();
            TabControl.SuspendLayout();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // TimerStatusBar
            // 
            TimerStatusBar.Interval = 5000;
            TimerStatusBar.Tick += TimerStatusBar_Tick;
            // 
            // TabPageAgregarEditar
            // 
            TabPageAgregarEditar.Controls.Add(TxtPassword2);
            TabPageAgregarEditar.Controls.Add(LabelPassword2);
            TabPageAgregarEditar.Controls.Add(TxtPassword);
            TabPageAgregarEditar.Controls.Add(LabelPassword);
            TabPageAgregarEditar.Controls.Add(TxtEmail);
            TabPageAgregarEditar.Controls.Add(label4);
            TabPageAgregarEditar.Controls.Add(label3);
            TabPageAgregarEditar.Controls.Add(TxtNombreyApellido);
            TabPageAgregarEditar.Controls.Add(ComboTiposDeUsuarios);
            TabPageAgregarEditar.Controls.Add(label5);
            TabPageAgregarEditar.Controls.Add(BtnCancelar);
            TabPageAgregarEditar.Controls.Add(BtnGuardar);
            TabPageAgregarEditar.Location = new Point(4, 24);
            TabPageAgregarEditar.Margin = new Padding(3, 2, 3, 2);
            TabPageAgregarEditar.Name = "TabPageAgregarEditar";
            TabPageAgregarEditar.Padding = new Padding(3, 2, 3, 2);
            TabPageAgregarEditar.Size = new Size(1046, 465);
            TabPageAgregarEditar.TabIndex = 1;
            TabPageAgregarEditar.Text = "Agregar/Editar";
            TabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(79, 69);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(110, 15);
            label3.TabIndex = 43;
            label3.Text = "Nombre y Apellido:";
            // 
            // TxtNombreyApellido
            // 
            TxtNombreyApellido.Location = new Point(218, 61);
            TxtNombreyApellido.Margin = new Padding(2);
            TxtNombreyApellido.Name = "TxtNombreyApellido";
            TxtNombreyApellido.Size = new Size(629, 23);
            TxtNombreyApellido.TabIndex = 42;
            // 
            // ComboTiposDeUsuarios
            // 
            ComboTiposDeUsuarios.FormattingEnabled = true;
            ComboTiposDeUsuarios.Location = new Point(218, 207);
            ComboTiposDeUsuarios.Margin = new Padding(3, 2, 3, 2);
            ComboTiposDeUsuarios.Name = "ComboTiposDeUsuarios";
            ComboTiposDeUsuarios.Size = new Size(233, 23);
            ComboTiposDeUsuarios.TabIndex = 41;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(98, 210);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(91, 15);
            label5.TabIndex = 40;
            label5.Text = "Tipo de usuario:";
            // 
            // BtnCancelar
            // 
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(528, 396);
            BtnCancelar.Margin = new Padding(3, 2, 3, 2);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(116, 47);
            BtnCancelar.TabIndex = 13;
            BtnCancelar.Text = "&Cancelar";
            BtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            BtnGuardar.IconColor = Color.Black;
            BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuardar.Location = new Point(357, 396);
            BtnGuardar.Margin = new Padding(3, 2, 3, 2);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(118, 47);
            BtnGuardar.TabIndex = 12;
            BtnGuardar.Text = "&Guardar";
            BtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // TabPageLista
            // 
            TabPageLista.Controls.Add(CheckVerEliminados);
            TabPageLista.Controls.Add(BtnRestaurar);
            TabPageLista.Controls.Add(BtnEliminar);
            TabPageLista.Controls.Add(BtnBuscar);
            TabPageLista.Controls.Add(TxtBuscar);
            TabPageLista.Controls.Add(label2);
            TabPageLista.Controls.Add(BtnSalir);
            TabPageLista.Controls.Add(BtnModificar);
            TabPageLista.Controls.Add(BtnAgregar);
            TabPageLista.Controls.Add(GridUsuarios);
            TabPageLista.Location = new Point(4, 24);
            TabPageLista.Margin = new Padding(3, 2, 3, 2);
            TabPageLista.Name = "TabPageLista";
            TabPageLista.Padding = new Padding(3, 2, 3, 2);
            TabPageLista.Size = new Size(1046, 465);
            TabPageLista.TabIndex = 0;
            TabPageLista.Text = "Lista";
            TabPageLista.UseVisualStyleBackColor = true;
            // 
            // CheckVerEliminados
            // 
            CheckVerEliminados.AutoSize = true;
            CheckVerEliminados.Location = new Point(668, 18);
            CheckVerEliminados.Margin = new Padding(3, 2, 3, 2);
            CheckVerEliminados.Name = "CheckVerEliminados";
            CheckVerEliminados.Size = new Size(103, 19);
            CheckVerEliminados.TabIndex = 21;
            CheckVerEliminados.Text = "Ver eliminados";
            CheckVerEliminados.UseVisualStyleBackColor = true;
            CheckVerEliminados.CheckedChanged += CheckVerEliminados_CheckedChanged;
            // 
            // BtnRestaurar
            // 
            BtnRestaurar.Anchor = AnchorStyles.Right;
            BtnRestaurar.IconChar = FontAwesome.Sharp.IconChar.Reply;
            BtnRestaurar.IconColor = Color.Black;
            BtnRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnRestaurar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRestaurar.Location = new Point(849, 190);
            BtnRestaurar.Margin = new Padding(3, 2, 3, 2);
            BtnRestaurar.Name = "BtnRestaurar";
            BtnRestaurar.Size = new Size(120, 40);
            BtnRestaurar.TabIndex = 20;
            BtnRestaurar.Text = "&Restaurar";
            BtnRestaurar.TextAlign = ContentAlignment.MiddleRight;
            BtnRestaurar.UseVisualStyleBackColor = true;
            BtnRestaurar.Click += BtnRestaurar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Anchor = AnchorStyles.Right;
            BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            BtnEliminar.IconColor = Color.Black;
            BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEliminar.Location = new Point(849, 146);
            BtnEliminar.Margin = new Padding(3, 2, 3, 2);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(120, 40);
            BtnEliminar.TabIndex = 17;
            BtnEliminar.Text = "&Eliminar";
            BtnEliminar.TextAlign = ContentAlignment.MiddleRight;
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click_1;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscar.IconColor = Color.Black;
            BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscar.Location = new Point(849, 15);
            BtnBuscar.Margin = new Padding(3, 2, 3, 2);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(120, 38);
            BtnBuscar.TabIndex = 16;
            BtnBuscar.Text = "&Buscar";
            BtnBuscar.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Location = new Point(72, 16);
            TxtBuscar.Margin = new Padding(3, 2, 3, 2);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(521, 23);
            TxtBuscar.TabIndex = 15;
            TxtBuscar.TextChanged += TxtBuscar_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 15);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 14;
            label2.Text = "Buscar:";
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            BtnSalir.IconColor = Color.Black;
            BtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSalir.Location = new Point(878, 278);
            BtnSalir.Margin = new Padding(3, 2, 3, 2);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(101, 36);
            BtnSalir.TabIndex = 13;
            BtnSalir.Text = "Salir";
            BtnSalir.TextAlign = ContentAlignment.MiddleRight;
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Anchor = AnchorStyles.Right;
            BtnModificar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            BtnModificar.IconColor = Color.Black;
            BtnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnModificar.Location = new Point(849, 101);
            BtnModificar.Margin = new Padding(3, 2, 3, 2);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(120, 41);
            BtnModificar.TabIndex = 12;
            BtnModificar.Text = "Modificar";
            BtnModificar.TextAlign = ContentAlignment.MiddleRight;
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.Right;
            BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            BtnAgregar.IconColor = Color.Black;
            BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregar.Location = new Point(849, 57);
            BtnAgregar.Margin = new Padding(3, 2, 3, 2);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(120, 40);
            BtnAgregar.TabIndex = 11;
            BtnAgregar.Text = "&Agregar";
            BtnAgregar.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // GridUsuarios
            // 
            GridUsuarios.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridUsuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridUsuarios.Location = new Point(3, 51);
            GridUsuarios.Margin = new Padding(3, 2, 3, 2);
            GridUsuarios.MultiSelect = false;
            GridUsuarios.Name = "GridUsuarios";
            GridUsuarios.RowHeadersWidth = 51;
            GridUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridUsuarios.Size = new Size(823, 262);
            GridUsuarios.TabIndex = 1;
            GridUsuarios.CellContentClick += GridDiscos_CellContentClick;
            // 
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl.Controls.Add(TabPageLista);
            TabControl.Controls.Add(TabPageAgregarEditar);
            TabControl.Location = new Point(10, 60);
            TabControl.Margin = new Padding(3, 2, 3, 2);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1054, 493);
            TabControl.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 20F);
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(115, 34);
            label1.TabIndex = 0;
            label1.Text = "Usuarios";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(995, 46);
            panel1.TabIndex = 7;
            // 
            // LabelStatusMessage
            // 
            LabelStatusMessage.Name = "LabelStatusMessage";
            LabelStatusMessage.Size = new Size(0, 17);
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { LabelStatusMessage });
            statusStrip1.Location = new Point(0, 549);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(1092, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // TxtPassword2
            // 
            TxtPassword2.ForeColor = Color.Black;
            TxtPassword2.Location = new Point(218, 168);
            TxtPassword2.Margin = new Padding(2);
            TxtPassword2.Name = "TxtPassword2";
            TxtPassword2.PasswordChar = '*';
            TxtPassword2.PlaceholderText = "Mínimo 6 caracteres";
            TxtPassword2.Size = new Size(629, 23);
            TxtPassword2.TabIndex = 50;
            // 
            // LabelPassword2
            // 
            LabelPassword2.Location = new Point(26, 170);
            LabelPassword2.Margin = new Padding(2, 0, 2, 0);
            LabelPassword2.Name = "LabelPassword2";
            LabelPassword2.Size = new Size(163, 18);
            LabelPassword2.TabIndex = 51;
            LabelPassword2.Text = "Repetir contraseña:";
            LabelPassword2.TextAlign = ContentAlignment.TopRight;
            // 
            // TxtPassword
            // 
            TxtPassword.ForeColor = Color.Black;
            TxtPassword.Location = new Point(218, 136);
            TxtPassword.Margin = new Padding(2);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.PasswordChar = '*';
            TxtPassword.PlaceholderText = "Mínimo 6 caracteres";
            TxtPassword.Size = new Size(629, 23);
            TxtPassword.TabIndex = 48;
            // 
            // LabelPassword
            // 
            LabelPassword.Location = new Point(26, 136);
            LabelPassword.Margin = new Padding(2, 0, 2, 0);
            LabelPassword.Name = "LabelPassword";
            LabelPassword.Size = new Size(163, 15);
            LabelPassword.TabIndex = 49;
            LabelPassword.Text = "Contraseña:";
            LabelPassword.TextAlign = ContentAlignment.TopRight;
            // 
            // TxtEmail
            // 
            TxtEmail.ForeColor = Color.Black;
            TxtEmail.Location = new Point(218, 102);
            TxtEmail.Margin = new Padding(2);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(629, 23);
            TxtEmail.TabIndex = 46;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(152, 102);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 47;
            label4.Text = "Email:";
            // 
            // UsuariosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1092, 571);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Controls.Add(TabControl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UsuariosView";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            TabPageAgregarEditar.ResumeLayout(false);
            TabPageAgregarEditar.PerformLayout();
            TabPageLista.ResumeLayout(false);
            TabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridUsuarios).EndInit();
            TabControl.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private System.Windows.Forms.Timer TimerStatusBar;
        private TabPage TabPageAgregarEditar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private TabPage TabPageLista;
        private CheckBox CheckVerEliminados;
        private FontAwesome.Sharp.IconButton BtnRestaurar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private TextBox TxtBuscar;
        private Label label2;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private FontAwesome.Sharp.IconButton BtnModificar;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private DataGridView GridUsuarios;
        private TabControl TabControl;
        private Label label1;
        private Panel panel1;
        private ToolStripStatusLabel LabelStatusMessage;
        private StatusStrip statusStrip1;
        private ComboBox ComboTiposDeUsuarios;
        private Label label5;
        private Label label3;
        private TextBox TxtNombreyApellido;
        private TextBox TxtPassword2;
        private Label LabelPassword2;
        private TextBox TxtPassword;
        private Label LabelPassword;
        private TextBox TxtEmail;
        private Label label4;
    }
}