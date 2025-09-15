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
            TabControl = new TabControl();
            TabPageLista = new TabPage();
            BtnEliminar = new FontAwesome.Sharp.IconButton();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            TxtBuscar = new TextBox();
            label2 = new Label();
            BtnSalir = new FontAwesome.Sharp.IconButton();
            BtnModificar = new FontAwesome.Sharp.IconButton();
            BtnAgregar = new FontAwesome.Sharp.IconButton();
            GridDiscos = new DataGridView();
            TabPageAgregarEditar = new TabPage();
            label7 = new Label();
            ComboPaises = new ComboBox();
            label6 = new Label();
            NumericCalificacion = new NumericUpDown();
            label5 = new Label();
            NumericDuracion = new NumericUpDown();
            TxtTitulo = new TextBox();
            label3 = new Label();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label1 = new Label();
            statusStrip1 = new StatusStrip();
            LabelStatusMessage = new ToolStripStatusLabel();
            TimerStatusBar = new System.Windows.Forms.Timer(components);
            TabControl.SuspendLayout();
            TabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridDiscos).BeginInit();
            TabPageAgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericCalificacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NumericDuracion).BeginInit();
            panel1.SuspendLayout();
            statusStrip1.SuspendLayout();
            SuspendLayout();
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
            // TabPageLista
            // 
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
            // BtnEliminar
            // 
            BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            BtnEliminar.IconColor = Color.Black;
            BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEliminar.Location = new Point(849, 190);
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
            TxtBuscar.Size = new Size(755, 23);
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
            BtnModificar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            BtnModificar.IconColor = Color.Black;
            BtnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnModificar.Location = new Point(849, 130);
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
            BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            BtnAgregar.IconColor = Color.Black;
            BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregar.Location = new Point(849, 70);
            BtnAgregar.Margin = new Padding(3, 2, 3, 2);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(120, 40);
            BtnAgregar.TabIndex = 11;
            BtnAgregar.Text = "&Agregar";
            BtnAgregar.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
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
            // TabPageAgregarEditar
            // 
            TabPageAgregarEditar.Controls.Add(label7);
            TabPageAgregarEditar.Controls.Add(ComboPaises);
            TabPageAgregarEditar.Controls.Add(label6);
            TabPageAgregarEditar.Controls.Add(NumericCalificacion);
            TabPageAgregarEditar.Controls.Add(label5);
            TabPageAgregarEditar.Controls.Add(NumericDuracion);
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
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(627, 148);
            label7.Name = "label7";
            label7.Size = new Size(31, 15);
            label7.TabIndex = 24;
            label7.Text = "País:";
            // 
            // ComboPaises
            // 
            ComboPaises.DropDownStyle = ComboBoxStyle.DropDownList;
            ComboPaises.FormattingEnabled = true;
            ComboPaises.Location = new Point(685, 146);
            ComboPaises.Margin = new Padding(3, 2, 3, 2);
            ComboPaises.Name = "ComboPaises";
            ComboPaises.Size = new Size(194, 23);
            ComboPaises.TabIndex = 23;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 180);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 22;
            label6.Text = "Calificación:";
            // 
            // NumericCalificacion
            // 
            NumericCalificacion.Location = new Point(193, 180);
            NumericCalificacion.Margin = new Padding(3, 2, 3, 2);
            NumericCalificacion.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            NumericCalificacion.Name = "NumericCalificacion";
            NumericCalificacion.Size = new Size(131, 23);
            NumericCalificacion.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 140);
            label5.Name = "label5";
            label5.Size = new Size(121, 15);
            label5.TabIndex = 19;
            label5.Text = "Duración en minutos:";
            // 
            // NumericDuracion
            // 
            NumericDuracion.Location = new Point(193, 138);
            NumericDuracion.Margin = new Padding(3, 2, 3, 2);
            NumericDuracion.Maximum = new decimal(new int[] { 999, 0, 0, 0 });
            NumericDuracion.Name = "NumericDuracion";
            NumericDuracion.Size = new Size(131, 23);
            NumericDuracion.TabIndex = 18;
            // 
            // TxtTitulo
            // 
            TxtTitulo.Location = new Point(138, 38);
            TxtTitulo.Margin = new Padding(3, 2, 3, 2);
            TxtTitulo.Name = "TxtTitulo";
            TxtTitulo.Size = new Size(741, 23);
            TxtTitulo.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 40);
            label3.Name = "label3";
            label3.Size = new Size(40, 15);
            label3.TabIndex = 14;
            label3.Text = "Título:";
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
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(14, 9);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(995, 46);
            panel1.TabIndex = 7;
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
            // LabelStatusMessage
            // 
            LabelStatusMessage.Name = "LabelStatusMessage";
            LabelStatusMessage.Size = new Size(0, 17);
            // 
            // TimerStatusBar
            // 
            TimerStatusBar.Interval = 5000;
            TimerStatusBar.Tick += TimerStatusBar_Tick;
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
            TabControl.ResumeLayout(false);
            TabPageLista.ResumeLayout(false);
            TabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridDiscos).EndInit();
            TabPageAgregarEditar.ResumeLayout(false);
            TabPageAgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericCalificacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)NumericDuracion).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TabControl TabControl;
        private TabPage TabPageLista;
        private TabPage TabPageAgregarEditar;
        private DataGridView GridDiscos;
        private FontAwesome.Sharp.IconButton BtnModificar;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private Panel panel1;
        private Label label1;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private TextBox TxtBuscar;
        private Label label2;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox2;
        private TextBox TxtTitulo;
        private Label label3;
        private NumericUpDown NumericDuracion;
        private NumericUpDown NumericCalificacion;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel LabelStatusMessage;
        private System.Windows.Forms.Timer TimerStatusBar;
        private Label label7;
        private ComboBox ComboPaises;
    }
}