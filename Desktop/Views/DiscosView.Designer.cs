namespace Desktop.Views
{
    partial class DiscosView
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
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            label4 = new Label();
            label8 = new Label();
            ComboBoxArtista = new ComboBox();
            ComboBoxGenero = new ComboBox();
            TabPageLista = new TabPage();
            GridDiscos = new DataGridView();
            BtnAgregar = new FontAwesome.Sharp.IconButton();
            BtnModificar = new FontAwesome.Sharp.IconButton();
            BtnSalir = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            TxtBuscar = new TextBox();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            BtnEliminar = new FontAwesome.Sharp.IconButton();
            BtnRestaurar = new FontAwesome.Sharp.IconButton();
            CheckVerEliminados = new CheckBox();
            TabControl = new TabControl();
            label1 = new Label();
            panel1 = new Panel();
            LabelStatusMessage = new ToolStripStatusLabel();
            statusStrip1 = new StatusStrip();
            TxtTitulo = new TextBox();
            TabPageAgregarEditar.SuspendLayout();
            TabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridDiscos).BeginInit();
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
            TabPageAgregarEditar.Controls.Add(ComboBoxGenero);
            TabPageAgregarEditar.Controls.Add(ComboBoxArtista);
            TabPageAgregarEditar.Controls.Add(label8);
            TabPageAgregarEditar.Controls.Add(label4);
            TabPageAgregarEditar.Controls.Add(TxtTitulo);
            TabPageAgregarEditar.Controls.Add(label3);
            TabPageAgregarEditar.Controls.Add(BtnCancelar);
            TabPageAgregarEditar.Controls.Add(BtnGuardar);
            TabPageAgregarEditar.Location = new Point(4, 24);
            TabPageAgregarEditar.Margin = new Padding(3, 2, 3, 2);
            TabPageAgregarEditar.Name = "TabPageAgregarEditar";
            TabPageAgregarEditar.Padding = new Padding(3, 2, 3, 2);
            TabPageAgregarEditar.Size = new Size(990, 322);
            TabPageAgregarEditar.TabIndex = 1;
            TabPageAgregarEditar.Text = "Agregar/Editar";
            TabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // BtnGuardar
            // 
            BtnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            BtnGuardar.IconColor = Color.Black;
            BtnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuardar.Location = new Point(302, 255);
            BtnGuardar.Margin = new Padding(3, 2, 3, 2);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(120, 40);
            BtnGuardar.TabIndex = 12;
            BtnGuardar.Text = "&Guardar";
            BtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnCancelar
            // 
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(463, 255);
            BtnCancelar.Margin = new Padding(3, 2, 3, 2);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(120, 40);
            BtnCancelar.TabIndex = 13;
            BtnCancelar.Text = "&Cancelar";
            BtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            BtnCancelar.UseVisualStyleBackColor = true;
            BtnCancelar.Click += BtnCancelar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(74, 41);
            label3.Name = "label3";
            label3.Size = new Size(47, 15);
            label3.TabIndex = 14;
            label3.Text = "Cliente:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(70, 85);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 26;
            label4.Text = "Artista:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(66, 129);
            label8.Name = "label8";
            label8.Size = new Size(48, 15);
            label8.TabIndex = 27;
            label8.Text = "Género:";
            // 
            // ComboBoxArtista
            // 
            ComboBoxArtista.FormattingEnabled = true;
            ComboBoxArtista.Location = new Point(138, 86);
            ComboBoxArtista.Margin = new Padding(3, 2, 3, 2);
            ComboBoxArtista.Name = "ComboBoxArtista";
            ComboBoxArtista.Size = new Size(730, 23);
            ComboBoxArtista.TabIndex = 28;
            // 
            // ComboBoxGenero
            // 
            ComboBoxGenero.FormattingEnabled = true;
            ComboBoxGenero.Location = new Point(138, 129);
            ComboBoxGenero.Margin = new Padding(3, 2, 3, 2);
            ComboBoxGenero.Name = "ComboBoxGenero";
            ComboBoxGenero.Size = new Size(730, 23);
            ComboBoxGenero.TabIndex = 29;
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
            TabPageLista.Controls.Add(GridDiscos);
            TabPageLista.Location = new Point(4, 24);
            TabPageLista.Margin = new Padding(3, 2, 3, 2);
            TabPageLista.Name = "TabPageLista";
            TabPageLista.Padding = new Padding(3, 2, 3, 2);
            TabPageLista.Size = new Size(990, 322);
            TabPageLista.TabIndex = 0;
            TabPageLista.Text = "Lista";
            TabPageLista.UseVisualStyleBackColor = true;
            // 
            // GridDiscos
            // 
            GridDiscos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridDiscos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridDiscos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridDiscos.Location = new Point(3, 51);
            GridDiscos.Margin = new Padding(3, 2, 3, 2);
            GridDiscos.MultiSelect = false;
            GridDiscos.Name = "GridDiscos";
            GridDiscos.RowHeadersWidth = 51;
            GridDiscos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridDiscos.Size = new Size(823, 262);
            GridDiscos.TabIndex = 1;
            GridDiscos.CellContentClick += GridDiscos_CellContentClick;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(5, 15);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 14;
            label2.Text = "Buscar:";
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
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl.Controls.Add(TabPageLista);
            TabControl.Controls.Add(TabPageAgregarEditar);
            TabControl.Location = new Point(10, 60);
            TabControl.Margin = new Padding(3, 2, 3, 2);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(998, 350);
            TabControl.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 20F);
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(90, 34);
            label1.TabIndex = 0;
            label1.Text = "Discos";
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
            statusStrip1.Location = new Point(0, 406);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(1036, 22);
            statusStrip1.TabIndex = 8;
            statusStrip1.Text = "statusStrip1";
            // 
            // TxtTitulo
            // 
            TxtTitulo.Location = new Point(138, 38);
            TxtTitulo.Margin = new Padding(3, 2, 3, 2);
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(730, 23);
            TxtTitulo.TabIndex = 15;
            // 
            // DiscosView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1036, 428);
            Controls.Add(statusStrip1);
            Controls.Add(panel1);
            Controls.Add(TabControl);
            Margin = new Padding(3, 2, 3, 2);
            Name = "DiscosView";
            StartPosition = FormStartPosition.CenterScreen;
            WindowState = FormWindowState.Maximized;
            TabPageAgregarEditar.ResumeLayout(false);
            TabPageAgregarEditar.PerformLayout();
            TabPageLista.ResumeLayout(false);
            TabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridDiscos).EndInit();
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
        private ComboBox ComboBoxGenero;
        private ComboBox ComboBoxArtista;
        private Label label8;
        private Label label4;
        private Label label3;
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
        private DataGridView GridDiscos;
        private TabControl TabControl;
        private Label label1;
        private Panel panel1;
        private ToolStripStatusLabel LabelStatusMessage;
        private StatusStrip statusStrip1;
        private TextBox TxtTitulo;
    }
}