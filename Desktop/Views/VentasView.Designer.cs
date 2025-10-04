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
            statusStrip1 = new StatusStrip();
            LabelStatusMessage = new ToolStripStatusLabel();
            TimerStatusBarr = new System.Windows.Forms.Timer(components);
            TabControl = new TabControl();
            TabPageLista = new TabPage();
            BtnSalirr = new FontAwesome.Sharp.IconButton();
            BtnRestaurarr = new FontAwesome.Sharp.IconButton();
            BtnEliminarr = new FontAwesome.Sharp.IconButton();
            BtnBuscarr = new FontAwesome.Sharp.IconButton();
            BtnModificarr = new FontAwesome.Sharp.IconButton();
            BtnAgregarr = new FontAwesome.Sharp.IconButton();
            CheckVerEliminadoss = new CheckBox();
            BtnRestaurar = new FontAwesome.Sharp.IconButton();
            BtnEliminar = new FontAwesome.Sharp.IconButton();
            BtnBuscar = new FontAwesome.Sharp.IconButton();
            TxtBuscarr = new TextBox();
            label2 = new Label();
            BtnSalir = new FontAwesome.Sharp.IconButton();
            BtnModificar = new FontAwesome.Sharp.IconButton();
            BtnAgregar = new FontAwesome.Sharp.IconButton();
            GridVentas = new DataGridView();
            TabPageAgregarEditar = new TabPage();
            NumericCantidad = new NumericUpDown();
            ComboDisco = new ComboBox();
            ComboCliente = new ComboBox();
            label8 = new Label();
            label4 = new Label();
            label3 = new Label();
            BtnCancelarr = new FontAwesome.Sharp.IconButton();
            BtnGuardarr = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            label1 = new Label();
            statusStrip1.SuspendLayout();
            TabControl.SuspendLayout();
            TabPageLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridVentas).BeginInit();
            TabPageAgregarEditar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)NumericCantidad).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { LabelStatusMessage });
            statusStrip1.Location = new Point(0, 557);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Padding = new Padding(1, 0, 12, 0);
            statusStrip1.Size = new Size(1100, 22);
            statusStrip1.TabIndex = 9;
            statusStrip1.Text = "statusStrip1";
            // 
            // LabelStatusMessage
            // 
            LabelStatusMessage.Name = "LabelStatusMessage";
            LabelStatusMessage.Size = new Size(0, 17);
            // 
            // TimerStatusBarr
            // 
            TimerStatusBarr.Interval = 5000;
            TimerStatusBarr.Tick += TimerStatusBarr_Tick;
            // 
            // TabControl
            // 
            TabControl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            TabControl.Controls.Add(TabPageLista);
            TabControl.Controls.Add(TabPageAgregarEditar);
            TabControl.Location = new Point(0, 78);
            TabControl.Margin = new Padding(3, 2, 3, 2);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1100, 477);
            TabControl.TabIndex = 10;
            // 
            // TabPageLista
            // 
            TabPageLista.Controls.Add(BtnSalirr);
            TabPageLista.Controls.Add(BtnRestaurarr);
            TabPageLista.Controls.Add(BtnEliminarr);
            TabPageLista.Controls.Add(BtnBuscarr);
            TabPageLista.Controls.Add(BtnModificarr);
            TabPageLista.Controls.Add(BtnAgregarr);
            TabPageLista.Controls.Add(CheckVerEliminadoss);
            TabPageLista.Controls.Add(BtnRestaurar);
            TabPageLista.Controls.Add(BtnEliminar);
            TabPageLista.Controls.Add(BtnBuscar);
            TabPageLista.Controls.Add(TxtBuscarr);
            TabPageLista.Controls.Add(label2);
            TabPageLista.Controls.Add(BtnSalir);
            TabPageLista.Controls.Add(BtnModificar);
            TabPageLista.Controls.Add(BtnAgregar);
            TabPageLista.Controls.Add(GridVentas);
            TabPageLista.Location = new Point(4, 24);
            TabPageLista.Margin = new Padding(3, 2, 3, 2);
            TabPageLista.Name = "TabPageLista";
            TabPageLista.Padding = new Padding(3, 2, 3, 2);
            TabPageLista.Size = new Size(1092, 449);
            TabPageLista.TabIndex = 0;
            TabPageLista.Text = "Lista";
            TabPageLista.UseVisualStyleBackColor = true;
            // 
            // BtnSalirr
            // 
            BtnSalirr.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            BtnSalirr.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            BtnSalirr.IconColor = Color.Black;
            BtnSalirr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSalirr.ImageAlign = ContentAlignment.MiddleLeft;
            BtnSalirr.Location = new Point(974, 398);
            BtnSalirr.Margin = new Padding(3, 2, 3, 2);
            BtnSalirr.Name = "BtnSalirr";
            BtnSalirr.Size = new Size(101, 36);
            BtnSalirr.TabIndex = 27;
            BtnSalirr.Text = "Salir";
            BtnSalirr.TextAlign = ContentAlignment.MiddleRight;
            BtnSalirr.UseVisualStyleBackColor = true;
            BtnSalirr.Click += BtnSalirr_Click;
            // 
            // BtnRestaurarr
            // 
            BtnRestaurarr.Anchor = AnchorStyles.Right;
            BtnRestaurarr.IconChar = FontAwesome.Sharp.IconChar.Reply;
            BtnRestaurarr.IconColor = Color.Black;
            BtnRestaurarr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnRestaurarr.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRestaurarr.Location = new Point(944, 245);
            BtnRestaurarr.Margin = new Padding(3, 2, 3, 2);
            BtnRestaurarr.Name = "BtnRestaurarr";
            BtnRestaurarr.Size = new Size(120, 40);
            BtnRestaurarr.TabIndex = 26;
            BtnRestaurarr.Text = "&Restaurar";
            BtnRestaurarr.TextAlign = ContentAlignment.MiddleRight;
            BtnRestaurarr.UseVisualStyleBackColor = true;
            BtnRestaurarr.Click += BtnRestaurarr_Click;
            // 
            // BtnEliminarr
            // 
            BtnEliminarr.Anchor = AnchorStyles.Right;
            BtnEliminarr.IconChar = FontAwesome.Sharp.IconChar.Trash;
            BtnEliminarr.IconColor = Color.Black;
            BtnEliminarr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEliminarr.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEliminarr.Location = new Point(944, 201);
            BtnEliminarr.Margin = new Padding(3, 2, 3, 2);
            BtnEliminarr.Name = "BtnEliminarr";
            BtnEliminarr.Size = new Size(120, 40);
            BtnEliminarr.TabIndex = 25;
            BtnEliminarr.Text = "&Eliminar";
            BtnEliminarr.TextAlign = ContentAlignment.MiddleRight;
            BtnEliminarr.UseVisualStyleBackColor = true;
            BtnEliminarr.Click += BtnEliminarr_Click;
            // 
            // BtnBuscarr
            // 
            BtnBuscarr.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscarr.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscarr.IconColor = Color.Black;
            BtnBuscarr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscarr.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscarr.Location = new Point(944, 18);
            BtnBuscarr.Margin = new Padding(3, 2, 3, 2);
            BtnBuscarr.Name = "BtnBuscarr";
            BtnBuscarr.Size = new Size(120, 38);
            BtnBuscarr.TabIndex = 24;
            BtnBuscarr.Text = "&Buscar";
            BtnBuscarr.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscarr.UseVisualStyleBackColor = true;
            BtnBuscarr.Click += BtnBuscarr_Click;
            // 
            // BtnModificarr
            // 
            BtnModificarr.Anchor = AnchorStyles.Right;
            BtnModificarr.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            BtnModificarr.IconColor = Color.Black;
            BtnModificarr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnModificarr.ImageAlign = ContentAlignment.MiddleLeft;
            BtnModificarr.Location = new Point(944, 156);
            BtnModificarr.Margin = new Padding(3, 2, 3, 2);
            BtnModificarr.Name = "BtnModificarr";
            BtnModificarr.Size = new Size(120, 41);
            BtnModificarr.TabIndex = 23;
            BtnModificarr.Text = "Modificar";
            BtnModificarr.TextAlign = ContentAlignment.MiddleRight;
            BtnModificarr.UseVisualStyleBackColor = true;
            BtnModificarr.Click += BtnModificarr_Click;
            // 
            // BtnAgregarr
            // 
            BtnAgregarr.Anchor = AnchorStyles.Right;
            BtnAgregarr.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            BtnAgregarr.IconColor = Color.Black;
            BtnAgregarr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAgregarr.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregarr.Location = new Point(944, 112);
            BtnAgregarr.Margin = new Padding(3, 2, 3, 2);
            BtnAgregarr.Name = "BtnAgregarr";
            BtnAgregarr.Size = new Size(120, 40);
            BtnAgregarr.TabIndex = 22;
            BtnAgregarr.Text = "&Agregar";
            BtnAgregarr.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregarr.UseVisualStyleBackColor = true;
            BtnAgregarr.Click += BtnAgregarr_Click;
            // 
            // CheckVerEliminadoss
            // 
            CheckVerEliminadoss.AutoSize = true;
            CheckVerEliminadoss.Location = new Point(618, 18);
            CheckVerEliminadoss.Margin = new Padding(3, 2, 3, 2);
            CheckVerEliminadoss.Name = "CheckVerEliminadoss";
            CheckVerEliminadoss.Size = new Size(103, 19);
            CheckVerEliminadoss.TabIndex = 21;
            CheckVerEliminadoss.Text = "Ver eliminados";
            CheckVerEliminadoss.UseVisualStyleBackColor = true;
            CheckVerEliminadoss.CheckedChanged += CheckVerEliminadoss_CheckedChanged;
            // 
            // BtnRestaurar
            // 
            BtnRestaurar.Anchor = AnchorStyles.Right;
            BtnRestaurar.IconChar = FontAwesome.Sharp.IconChar.Reply;
            BtnRestaurar.IconColor = Color.Black;
            BtnRestaurar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnRestaurar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnRestaurar.Location = new Point(1738, 364);
            BtnRestaurar.Margin = new Padding(3, 2, 3, 2);
            BtnRestaurar.Name = "BtnRestaurar";
            BtnRestaurar.Size = new Size(120, 40);
            BtnRestaurar.TabIndex = 20;
            BtnRestaurar.Text = "&Restaurar";
            BtnRestaurar.TextAlign = ContentAlignment.MiddleRight;
            BtnRestaurar.UseVisualStyleBackColor = true;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Anchor = AnchorStyles.Right;
            BtnEliminar.IconChar = FontAwesome.Sharp.IconChar.Trash;
            BtnEliminar.IconColor = Color.Black;
            BtnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnEliminar.Location = new Point(1738, 320);
            BtnEliminar.Margin = new Padding(3, 2, 3, 2);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(120, 40);
            BtnEliminar.TabIndex = 17;
            BtnEliminar.Text = "&Eliminar";
            BtnEliminar.TextAlign = ContentAlignment.MiddleRight;
            BtnEliminar.UseVisualStyleBackColor = true;
            // 
            // BtnBuscar
            // 
            BtnBuscar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            BtnBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscar.IconColor = Color.Black;
            BtnBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnBuscar.Location = new Point(1738, 17);
            BtnBuscar.Margin = new Padding(3, 2, 3, 2);
            BtnBuscar.Name = "BtnBuscar";
            BtnBuscar.Size = new Size(120, 38);
            BtnBuscar.TabIndex = 16;
            BtnBuscar.Text = "&Buscar";
            BtnBuscar.TextAlign = ContentAlignment.MiddleRight;
            BtnBuscar.UseVisualStyleBackColor = true;
            // 
            // TxtBuscarr
            // 
            TxtBuscarr.Location = new Point(72, 16);
            TxtBuscarr.Margin = new Padding(3, 2, 3, 2);
            TxtBuscarr.Name = "TxtBuscarr";
            TxtBuscarr.Size = new Size(521, 23);
            TxtBuscarr.TabIndex = 15;
            TxtBuscarr.TextChanged += TxtBuscarr_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(8, 17);
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
            BtnSalir.Location = new Point(1767, 625);
            BtnSalir.Margin = new Padding(3, 2, 3, 2);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(101, 36);
            BtnSalir.TabIndex = 13;
            BtnSalir.Text = "Salir";
            BtnSalir.TextAlign = ContentAlignment.MiddleRight;
            BtnSalir.UseVisualStyleBackColor = true;
            // 
            // BtnModificar
            // 
            BtnModificar.Anchor = AnchorStyles.Right;
            BtnModificar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            BtnModificar.IconColor = Color.Black;
            BtnModificar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnModificar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnModificar.Location = new Point(1738, 275);
            BtnModificar.Margin = new Padding(3, 2, 3, 2);
            BtnModificar.Name = "BtnModificar";
            BtnModificar.Size = new Size(120, 41);
            BtnModificar.TabIndex = 12;
            BtnModificar.Text = "Modificar";
            BtnModificar.TextAlign = ContentAlignment.MiddleRight;
            BtnModificar.UseVisualStyleBackColor = true;
            // 
            // BtnAgregar
            // 
            BtnAgregar.Anchor = AnchorStyles.Right;
            BtnAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            BtnAgregar.IconColor = Color.Black;
            BtnAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAgregar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnAgregar.Location = new Point(1738, 231);
            BtnAgregar.Margin = new Padding(3, 2, 3, 2);
            BtnAgregar.Name = "BtnAgregar";
            BtnAgregar.Size = new Size(120, 40);
            BtnAgregar.TabIndex = 11;
            BtnAgregar.Text = "&Agregar";
            BtnAgregar.TextAlign = ContentAlignment.MiddleRight;
            BtnAgregar.UseVisualStyleBackColor = true;
            // 
            // GridVentas
            // 
            GridVentas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GridVentas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            GridVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridVentas.Location = new Point(8, 43);
            GridVentas.Margin = new Padding(3, 2, 3, 2);
            GridVentas.MultiSelect = false;
            GridVentas.Name = "GridVentas";
            GridVentas.RowHeadersWidth = 51;
            GridVentas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            GridVentas.Size = new Size(907, 402);
            GridVentas.TabIndex = 1;
            GridVentas.CellContentClick += GridVentas_CellContentClick;
            // 
            // TabPageAgregarEditar
            // 
            TabPageAgregarEditar.Controls.Add(NumericCantidad);
            TabPageAgregarEditar.Controls.Add(ComboDisco);
            TabPageAgregarEditar.Controls.Add(ComboCliente);
            TabPageAgregarEditar.Controls.Add(label8);
            TabPageAgregarEditar.Controls.Add(label4);
            TabPageAgregarEditar.Controls.Add(label3);
            TabPageAgregarEditar.Controls.Add(BtnCancelarr);
            TabPageAgregarEditar.Controls.Add(BtnGuardarr);
            TabPageAgregarEditar.Location = new Point(4, 24);
            TabPageAgregarEditar.Margin = new Padding(3, 2, 3, 2);
            TabPageAgregarEditar.Name = "TabPageAgregarEditar";
            TabPageAgregarEditar.Padding = new Padding(3, 2, 3, 2);
            TabPageAgregarEditar.Size = new Size(1092, 449);
            TabPageAgregarEditar.TabIndex = 1;
            TabPageAgregarEditar.Text = "Agregar/Editar";
            TabPageAgregarEditar.UseVisualStyleBackColor = true;
            // 
            // NumericCantidad
            // 
            NumericCantidad.Location = new Point(138, 44);
            NumericCantidad.Name = "NumericCantidad";
            NumericCantidad.Size = new Size(120, 23);
            NumericCantidad.TabIndex = 31;
            // 
            // ComboDisco
            // 
            ComboDisco.FormattingEnabled = true;
            ComboDisco.Location = new Point(138, 129);
            ComboDisco.Margin = new Padding(3, 2, 3, 2);
            ComboDisco.Name = "ComboDisco";
            ComboDisco.Size = new Size(730, 23);
            ComboDisco.TabIndex = 29;
            // 
            // ComboCliente
            // 
            ComboCliente.FormattingEnabled = true;
            ComboCliente.Location = new Point(138, 86);
            ComboCliente.Margin = new Padding(3, 2, 3, 2);
            ComboCliente.Name = "ComboCliente";
            ComboCliente.Size = new Size(730, 23);
            ComboCliente.TabIndex = 28;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(81, 132);
            label8.Name = "label8";
            label8.Size = new Size(39, 15);
            label8.TabIndex = 27;
            label8.Text = "Disco:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 89);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 26;
            label4.Text = "Cliente:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 46);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 14;
            label3.Text = "Cantidad:";
            // 
            // BtnCancelarr
            // 
            BtnCancelarr.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelarr.IconColor = Color.Black;
            BtnCancelarr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelarr.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelarr.Location = new Point(463, 255);
            BtnCancelarr.Margin = new Padding(3, 2, 3, 2);
            BtnCancelarr.Name = "BtnCancelarr";
            BtnCancelarr.Size = new Size(120, 40);
            BtnCancelarr.TabIndex = 13;
            BtnCancelarr.Text = "&Cancelar";
            BtnCancelarr.TextAlign = ContentAlignment.MiddleRight;
            BtnCancelarr.UseVisualStyleBackColor = true;
            BtnCancelarr.Click += BtnCancelarr_Click;
            // 
            // BtnGuardarr
            // 
            BtnGuardarr.IconChar = FontAwesome.Sharp.IconChar.Save;
            BtnGuardarr.IconColor = Color.Black;
            BtnGuardarr.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnGuardarr.ImageAlign = ContentAlignment.MiddleLeft;
            BtnGuardarr.Location = new Point(302, 255);
            BtnGuardarr.Margin = new Padding(3, 2, 3, 2);
            BtnGuardarr.Name = "BtnGuardarr";
            BtnGuardarr.Size = new Size(120, 40);
            BtnGuardarr.TabIndex = 12;
            BtnGuardarr.Text = "&Guardar";
            BtnGuardarr.TextAlign = ContentAlignment.MiddleRight;
            BtnGuardarr.UseVisualStyleBackColor = true;
            BtnGuardarr.Click += BtnGuardarr_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 11);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1003, 63);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 8);
            label1.Name = "label1";
            label1.Size = new Size(124, 45);
            label1.TabIndex = 0;
            label1.Text = "Ventas";
            // 
            // VentasView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1100, 579);
            Controls.Add(panel1);
            Controls.Add(TabControl);
            Controls.Add(statusStrip1);
            Name = "VentasView";
            Text = "VentasView";
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            TabControl.ResumeLayout(false);
            TabPageLista.ResumeLayout(false);
            TabPageLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)GridVentas).EndInit();
            TabPageAgregarEditar.ResumeLayout(false);
            TabPageAgregarEditar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)NumericCantidad).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private StatusStrip statusStrip1;
        private ToolStripStatusLabel LabelStatusMessage;
        private System.Windows.Forms.Timer TimerStatusBarr;
        private TabControl TabControl;
        private TabPage TabPageLista;
        private CheckBox CheckVerEliminadoss;
        private FontAwesome.Sharp.IconButton BtnRestaurar;
        private FontAwesome.Sharp.IconButton BtnEliminar;
        private FontAwesome.Sharp.IconButton BtnBuscar;
        private TextBox TxtBuscarr;
        private Label label2;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private FontAwesome.Sharp.IconButton BtnModificar;
        private FontAwesome.Sharp.IconButton BtnAgregar;
        private DataGridView GridVentas;
        private TabPage TabPageAgregarEditar;
        private ComboBox ComboDisco;
        private ComboBox ComboCliente;
        private Label label8;
        private Label label4;
        private Label label3;
        private FontAwesome.Sharp.IconButton BtnCancelarr;
        private FontAwesome.Sharp.IconButton BtnGuardarr;
        private Panel panel1;
        private Label label1;
        private FontAwesome.Sharp.IconButton BtnRestaurarr;
        private FontAwesome.Sharp.IconButton BtnEliminarr;
        private FontAwesome.Sharp.IconButton BtnBuscarr;
        private FontAwesome.Sharp.IconButton BtnModificarr;
        private FontAwesome.Sharp.IconButton BtnAgregarr;
        private FontAwesome.Sharp.IconButton BtnSalirr;
        private NumericUpDown NumericCantidad;
    }
}