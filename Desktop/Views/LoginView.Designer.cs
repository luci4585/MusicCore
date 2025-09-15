namespace Desktop.Views
{
    partial class LoginView
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
            pictureBox1 = new PictureBox();
            BtnCancelar = new FontAwesome.Sharp.IconButton();
            BtnIniciarSesion = new FontAwesome.Sharp.IconButton();
            CheckVerContraseña = new CheckBox();
            TxtPassword = new TextBox();
            TxtEmail = new TextBox();
            label2 = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LogoMusicCore;
            pictureBox1.Location = new Point(-6, -4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(341, 344);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // BtnCancelar
            // 
            BtnCancelar.IconChar = FontAwesome.Sharp.IconChar.Cancel;
            BtnCancelar.IconColor = Color.Black;
            BtnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            BtnCancelar.Location = new Point(557, 224);
            BtnCancelar.Margin = new Padding(3, 2, 3, 2);
            BtnCancelar.Name = "BtnCancelar";
            BtnCancelar.Size = new Size(140, 60);
            BtnCancelar.TabIndex = 15;
            BtnCancelar.Text = "Cancelar";
            BtnCancelar.TextAlign = ContentAlignment.MiddleRight;
            BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnIniciarSesion
            // 
            BtnIniciarSesion.IconChar = FontAwesome.Sharp.IconChar.CircleArrowRight;
            BtnIniciarSesion.IconColor = Color.Black;
            BtnIniciarSesion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnIniciarSesion.ImageAlign = ContentAlignment.MiddleLeft;
            BtnIniciarSesion.Location = new Point(387, 224);
            BtnIniciarSesion.Margin = new Padding(3, 2, 3, 2);
            BtnIniciarSesion.Name = "BtnIniciarSesion";
            BtnIniciarSesion.Size = new Size(138, 60);
            BtnIniciarSesion.TabIndex = 14;
            BtnIniciarSesion.Text = "Iniciar Sesión";
            BtnIniciarSesion.TextAlign = ContentAlignment.MiddleRight;
            BtnIniciarSesion.UseVisualStyleBackColor = true;
            BtnIniciarSesion.Click += BtnIniciarSesion_Click;
            // 
            // CheckVerContraseña
            // 
            CheckVerContraseña.AutoSize = true;
            CheckVerContraseña.Location = new Point(485, 162);
            CheckVerContraseña.Margin = new Padding(3, 2, 3, 2);
            CheckVerContraseña.Name = "CheckVerContraseña";
            CheckVerContraseña.Size = new Size(103, 19);
            CheckVerContraseña.TabIndex = 13;
            CheckVerContraseña.Text = "Ver contraseña";
            CheckVerContraseña.UseVisualStyleBackColor = true;
            CheckVerContraseña.CheckedChanged += CheckVerContraseña_CheckedChanged;
            // 
            // TxtPassword
            // 
            TxtPassword.Location = new Point(478, 106);
            TxtPassword.Margin = new Padding(3, 2, 3, 2);
            TxtPassword.Name = "TxtPassword";
            TxtPassword.Size = new Size(197, 23);
            TxtPassword.TabIndex = 12;
            // 
            // TxtEmail
            // 
            TxtEmail.Location = new Point(478, 74);
            TxtEmail.Margin = new Padding(3, 2, 3, 2);
            TxtEmail.Name = "TxtEmail";
            TxtEmail.Size = new Size(197, 23);
            TxtEmail.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(407, 111);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 10;
            label2.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(404, 79);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 9;
            label1.Text = "Email:";
            // 
            // LoginView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(744, 335);
            Controls.Add(BtnCancelar);
            Controls.Add(BtnIniciarSesion);
            Controls.Add(CheckVerContraseña);
            Controls.Add(TxtPassword);
            Controls.Add(TxtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginView";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton BtnCancelar;
        private FontAwesome.Sharp.IconButton BtnIniciarSesion;
        private CheckBox CheckVerContraseña;
        private TextBox TxtPassword;
        private TextBox TxtEmail;
        private Label label2;
        private Label label1;
    }
}