namespace Desktop.Views
{
    partial class VentasView
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
            panel1 = new Panel();
            label1 = new Label();
            TabControl = new TabControl();
            TabPageLista = new TabPage();
            BtnSalir = new FontAwesome.Sharp.IconButton();
            BtnEliminar = new FontAwesome.Sharp.IconButton();
            BtnRestaurar = new FontAwesome.Sharp.IconButton();
            BtnAgregar = new FontAwesome.Sharp.IconButton();
            BtnModificar = new FontAwesome.Sharp.IconButton();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            statusStrip1 = new StatusStrip();
            LabelStatusMessage = new ToolStripStatusLabel();
            GridVentas = new DataGridView();
            CheckVerEliminados = new CheckBox();
            TxtBuscar = new TextBox();
            label2 = new Label();
            TabPageAgregarEditar = new TabPage();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnGuardar = new FontAwesome.Sharp.IconButton();
            ComboDisco = new ComboBox();
            label8 = new Label();
            ComboCliente = new ComboBox();
            label4 = new Label();
            NumericCantidad = new NumericUpDown();
            label3 = new Label();
            TimerStatusBar = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            TabControl.SuspendLayout();
            TabPageLista.SuspendLayout();
            statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridVentas).BeginInit();
            TabPageAgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericCantidad).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(label1);
            panel1.Location = new Point(10, 10);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1054, 58);
            panel1.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 20.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 10);
            label1.Name = "label1";
            label1.Size = new Size(117, 43);
            label1.TabIndex = 0;
            label1.Text = "Ventas";
            // 
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl.Controls.Add(TabPageLista);
            TabControl.Controls.Add(TabPageAgregarEditar);
            TabControl.Location = new Point(10, 74);
            TabControl.Margin = new Padding(2);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1050, 564);
            TabControl.TabIndex = 13;
            // 
            // TabPageLista
            // 
            TabPageLista.Controls.Add(BtnSalir);
            TabPageLista.Controls.Add(BtnEliminar);
            TabPageLista.Controls.Add(BtnRestaurar);
            TabPageLista.Controls.Add(BtnAgregar);
            TabPageLista.Controls.Add(BtnModificar);
            TabPageLista.Controls.Add(BtnBuscar);
            TabPageLista.Controls.Add(statusStrip1);
            TabPageLista.Controls.Add(GridVentas);
            TabPageLista.Controls.Add(CheckVerEliminados);
            TabPageLista.Controls.Add(TxtBuscar);
            TabPageLista.Controls.Add(label2);
            TabPageLista.Location = new Point(4, 29);
            TabPageLista.Margin = new Padding(2);
            TabPageLista.Name = "TabPageLista";
            TabPageLista.Padding = new Padding(2);
            TabPageLista.Size = new Size(1042, 531);
            TabPageLista.TabIndex = 0;
            TabPageLista.Text = "Lista";
            TabPageLista.UseVisualStyleBackColor = true;
            // 
            // BtnSalir
            // 
            BtnSalir.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            BtnSalir.IconColor = Color.Black;
            BtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSalir.IconSize = 35;
            BtnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSalir.Location = new Point(945, 440);
            BtnSalir.Margin = new Padding(3, 2, 3, 2);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(79, 34);
            BtnSalir.TabIndex = 30;
            BtnSalir.Text = "Salir";
            BtnSalir.TextAlign = ContentAlignment.MiddleRight;
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            BtnEliminar.IconColor = Color.Black;
            BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEliminar.IconSize = 35;
            BtnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEliminar.Location = new Point(848, 318);
            BtnEliminar.Margin = new Padding(3, 2, 3, 2);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(106, 58);
            BtnEliminar.TabIndex = 29;
            BtnEliminar.Text = "&Eliminar";
            BtnEliminar.TextAlign = ContentAlignment.MiddleRight;
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnRestaurar
            // 
            BtnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnRestaurar.IconChar = FontAwesome.Sharp.IconChar.Reply;
            BtnRestaurar.IconColor = Color.Black;
            BtnRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnRestaurar.IconSize = 35;
            BtnRestaurar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRestaurar.Location = new Point(848, 240);
            BtnRestaurar.Margin = new Padding(3, 2, 3, 2);
            BtnRestaurar.Name = "BtnRestaurar";
            BtnRestaurar.Size = new Size(106, 58);
            BtnRestaurar.TabIndex = 28;
            BtnRestaurar.Text = "&Restaurar";
            BtnRestaurar.TextAlign = ContentAlignment.MiddleRight;
            BtnRestaurar.UseVisualStyleBackColor = true;
            BtnRestaurar.Click += BtnRestaurar_Click;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            BtnAgregar.IconColor = Color.Black;
            BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAgregar.IconSize = 35;
            BtnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregar.Location = new Point(848, 162);
            BtnAgregar.Margin = new Padding(3, 2, 3, 2);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(106, 58);
            BtnAgregar.TabIndex = 27;
            BtnAgregar.Text = "&Agregar";
            BtnAgregar.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregar.UseVisualStyleBackColor = true;
            BtnAgregar.Click += BtnAgregar_Click;
            // 
            // BtnModificar
            // 
            BtnModificar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnModificar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            BtnModificar.IconColor = Color.Black;
            BtnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnModificar.IconSize = 35;
            BtnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnModificar.Location = new Point(848, 94);
            BtnModificar.Margin = new Padding(3, 2, 3, 2);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(106, 52);
            BtnModificar.TabIndex = 26;
            BtnModificar.Text = "Modificar";
            BtnModificar.TextAlign = ContentAlignment.MiddleRight;
            BtnModificar.UseVisualStyleBackColor = true;
            BtnModificar.Click += BtnModificar_Click;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscar.IconColor = Color.Black;
            BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscar.IconSize = 35;
            BtnBuscar.ImageAlign = ContentAlignment.BottomLeft;
            BtnBuscar.Location = new Point(723, 14);
            BtnBuscar.Margin = new Padding(3, 2, 3, 2);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(96, 56);
            BtnBuscar.TabIndex = 25;
            BtnBuscar.Text = "&Buscar";
            BtnBuscar.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscar.UseVisualStyleBackColor = true;
            BtnBuscar.Click += BtnBuscar_Click;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { LabelStatusMessage });
            statusStrip1.Location = new Point(2, 507);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(1038, 22);
            statusStrip1.TabIndex = 24;
            statusStrip1.Text = "statusStrip1";
            // 
            // LabelStatusMessage
            // 
            LabelStatusMessage.Name = "LabelStatusMessage";
            LabelStatusMessage.Size = new Size(0, 16);
            // 
            // GridVentas
            // 
            GridVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridVentas.Location = new Point(6, 54);
            GridVentas.Margin = new Padding(3, 2, 3, 2);
            GridVentas.MultiSelect = false;
            GridVentas.Name = "GridVentas";
            GridVentas.RowHeadersWidth = 51;
            GridVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridVentas.Size = new Size(680, 422);
            GridVentas.TabIndex = 23;
            GridVentas.CellContentClick += GridVentas_CellContentClick;
            // 
            // CheckVerEliminados
            // 
            CheckVerEliminados.AutoSize = true;
            CheckVerEliminados.Location = new Point(538, 14);
            CheckVerEliminados.Margin = new Padding(3, 2, 3, 2);
            CheckVerEliminados.Name = "CheckVerEliminados";
            CheckVerEliminados.Size = new Size(129, 24);
            CheckVerEliminados.TabIndex = 22;
            CheckVerEliminados.Text = "Ver eliminados";
            CheckVerEliminados.UseVisualStyleBackColor = true;
            CheckVerEliminados.CheckedChanged += CheckVerEliminados_CheckedChanged;
            // 
            // TxtBuscar
            // 
            TxtBuscar.Location = new Point(65, 10);
            TxtBuscar.Margin = new Padding(3, 2, 3, 2);
            TxtBuscar.Name = "TxtBuscar";
            TxtBuscar.Size = new Size(452, 27);
            TxtBuscar.TabIndex = 16;
            TxtBuscar.TextChanged += TxtBuscar_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 10);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 15;
            label2.Text = "Buscar:";
            // 
            // TabPageAgregarEditar
            // 
            TabPageAgregarEditar.Controls.Add(BtnCancelar);
            TabPageAgregarEditar.Controls.Add(BtnGuardar);
            TabPageAgregarEditar.Controls.Add(ComboDisco);
            TabPageAgregarEditar.Controls.Add(label8);
            TabPageAgregarEditar.Controls.Add(ComboCliente);
            TabPageAgregarEditar.Controls.Add(label4);
            TabPageAgregarEditar.Controls.Add(NumericCantidad);
            TabPageAgregarEditar.Controls.Add(label3);
            TabPageAgregarEditar.Location = new Point(4, 29);
            TabPageAgregarEditar.Margin = new Padding(2);
            TabPageAgregarEditar.Name = "TabPageAgregarEditar";
            TabPageAgregarEditar.Padding = new Padding(2);
            TabPageAgregarEditar.Size = new Size(1042, 531);
            TabPageAgregarEditar.TabIndex = 1;
            TabPageAgregarEditar.Text = "Agregar/Editar";
            TabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // BtnCancelar
            // 
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.IconSize = 35;
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(424, 278);
            BtnCancelar.Margin = new Padding(3, 2, 3, 2);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(93, 36);
            BtnCancelar.TabIndex = 39;
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
            BtnGuardar.IconSize = 35;
            BtnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuardar.Location = new Point(273, 280);
            BtnGuardar.Margin = new Padding(3, 2, 3, 2);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(97, 34);
            BtnGuardar.TabIndex = 38;
            BtnGuardar.Text = "&Guardar";
            BtnGuardar.TextAlign = ContentAlignment.MiddleRight;
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // ComboDisco
            // 
            ComboDisco.FormattingEnabled = true;
            ComboDisco.Location = new Point(233, 178);
            ComboDisco.Margin = new Padding(3, 2, 3, 2);
            ComboDisco.Name = "ComboDisco";
            ComboDisco.Size = new Size(375, 28);
            ComboDisco.TabIndex = 37;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(146, 178);
            label8.Name = "label8";
            label8.Size = new Size(49, 20);
            label8.TabIndex = 36;
            label8.Text = "Disco:";
            // 
            // ComboCliente
            // 
            ComboCliente.FormattingEnabled = true;
            ComboCliente.Location = new Point(233, 114);
            ComboCliente.Margin = new Padding(3, 2, 3, 2);
            ComboCliente.Name = "ComboCliente";
            ComboCliente.Size = new Size(349, 28);
            ComboCliente.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 114);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 34;
            label4.Text = "Cliente:";
            // 
            // NumericCantidad
            // 
            NumericCantidad.Location = new Point(233, 54);
            NumericCantidad.Margin = new Padding(3, 4, 3, 4);
            NumericCantidad.Name = "NumericCantidad";
            NumericCantidad.Size = new Size(137, 27);
            NumericCantidad.TabIndex = 33;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 58);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 32;
            label3.Text = "Cantidad:";
            // 
            // TimerStatusBar
            // 
            TimerStatusBar.Tick += TimerStatusBar_Tick;
            // 
            // VentasView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 646);
            Controls.Add(TabControl);
            Controls.Add(panel1);
            Margin = new Padding(2);
            Name = "VentasView";
            Text = "VentasView";
            WindowState = FormWindowState.Maximized;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            TabControl.ResumeLayout(false);
            TabPageLista.ResumeLayout(false);
            TabPageLista.PerformLayout();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridVentas).EndInit();
            TabPageAgregarEditar.ResumeLayout(false);
            TabPageAgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericCantidad).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TabControl TabControl;
        private TabPage TabPageLista;
        private TabPage TabPageAgregarEditar;
        private Label label2;
        private TextBox TxtBuscar;
        private CheckBox CheckVerEliminados;
        private DataGridView GridVentas;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel LabelStatusMessage;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private FontAwesome.Sharp.IconButton BtnModificar;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private FontAwesome.Sharp.IconButton BtnRestaurar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private NumericUpDown NumericCantidad;
        private Label label3;
        private ComboBox ComboCliente;
        private Label label4;
        private ComboBox ComboDisco;
        private Label label8;
        private FontAwesome.Sharp.IconButton BtnGuardar;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private System.Windows.Forms.Timer TimerStatusBar;
    }
}