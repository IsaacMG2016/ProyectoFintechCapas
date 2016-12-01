namespace Login
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.aceptar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.imagen = new System.Windows.Forms.PictureBox();
            this.usuarioLabel = new System.Windows.Forms.Label();
            this.UsuarioComboBox = new System.Windows.Forms.ComboBox();
            this.ContraseñaLabel = new System.Windows.Forms.Label();
            this.contraseñaTextBox = new System.Windows.Forms.TextBox();
            this.recordarUsuarioCheckBox = new System.Windows.Forms.CheckBox();
            this.registrarUsuarioLinkLabel = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).BeginInit();
            this.SuspendLayout();
            // 
            // aceptar
            // 
            this.aceptar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.aceptar.Location = new System.Drawing.Point(255, 169);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(111, 37);
            this.aceptar.TabIndex = 0;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = false;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.salir.Location = new System.Drawing.Point(387, 169);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(111, 37);
            this.salir.TabIndex = 1;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // imagen
            // 
            this.imagen.BackColor = System.Drawing.SystemColors.Control;
            this.imagen.Image = ((System.Drawing.Image)(resources.GetObject("imagen.Image")));
            this.imagen.Location = new System.Drawing.Point(24, 12);
            this.imagen.Name = "imagen";
            this.imagen.Size = new System.Drawing.Size(148, 161);
            this.imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imagen.TabIndex = 2;
            this.imagen.TabStop = false;
            // 
            // usuarioLabel
            // 
            this.usuarioLabel.AutoSize = true;
            this.usuarioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuarioLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.usuarioLabel.Location = new System.Drawing.Point(190, 46);
            this.usuarioLabel.Name = "usuarioLabel";
            this.usuarioLabel.Size = new System.Drawing.Size(67, 18);
            this.usuarioLabel.TabIndex = 3;
            this.usuarioLabel.Text = "Usuario";
            // 
            // UsuarioComboBox
            // 
            this.UsuarioComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.UsuarioComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UsuarioComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.UsuarioComboBox.FormattingEnabled = true;
            this.UsuarioComboBox.Location = new System.Drawing.Point(297, 42);
            this.UsuarioComboBox.Name = "UsuarioComboBox";
            this.UsuarioComboBox.Size = new System.Drawing.Size(201, 28);
            this.UsuarioComboBox.TabIndex = 4;
            // 
            // ContraseñaLabel
            // 
            this.ContraseñaLabel.AutoSize = true;
            this.ContraseñaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraseñaLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ContraseñaLabel.Location = new System.Drawing.Point(189, 82);
            this.ContraseñaLabel.Name = "ContraseñaLabel";
            this.ContraseñaLabel.Size = new System.Drawing.Size(102, 20);
            this.ContraseñaLabel.TabIndex = 5;
            this.ContraseñaLabel.Text = "Contraseña";
            // 
            // contraseñaTextBox
            // 
            this.contraseñaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.contraseñaTextBox.Location = new System.Drawing.Point(297, 79);
            this.contraseñaTextBox.Multiline = true;
            this.contraseñaTextBox.Name = "contraseñaTextBox";
            this.contraseñaTextBox.Size = new System.Drawing.Size(201, 29);
            this.contraseñaTextBox.TabIndex = 6;
            // 
            // recordarUsuarioCheckBox
            // 
            this.recordarUsuarioCheckBox.AutoSize = true;
            this.recordarUsuarioCheckBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.recordarUsuarioCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.recordarUsuarioCheckBox.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.recordarUsuarioCheckBox.Location = new System.Drawing.Point(193, 119);
            this.recordarUsuarioCheckBox.Name = "recordarUsuarioCheckBox";
            this.recordarUsuarioCheckBox.Size = new System.Drawing.Size(239, 21);
            this.recordarUsuarioCheckBox.TabIndex = 7;
            this.recordarUsuarioCheckBox.Text = "Recordar Nombre de Usuario";
            this.recordarUsuarioCheckBox.UseVisualStyleBackColor = true;
            // 
            // registrarUsuarioLinkLabel
            // 
            this.registrarUsuarioLinkLabel.AutoSize = true;
            this.registrarUsuarioLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarUsuarioLinkLabel.Location = new System.Drawing.Point(21, 201);
            this.registrarUsuarioLinkLabel.Name = "registrarUsuarioLinkLabel";
            this.registrarUsuarioLinkLabel.Size = new System.Drawing.Size(120, 15);
            this.registrarUsuarioLinkLabel.TabIndex = 8;
            this.registrarUsuarioLinkLabel.TabStop = true;
            this.registrarUsuarioLinkLabel.Text = "Registrar Usuario";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(539, 236);
            this.Controls.Add(this.registrarUsuarioLinkLabel);
            this.Controls.Add(this.contraseñaTextBox);
            this.Controls.Add(this.ContraseñaLabel);
            this.Controls.Add(this.UsuarioComboBox);
            this.Controls.Add(this.usuarioLabel);
            this.Controls.Add(this.imagen);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.recordarUsuarioCheckBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Login";
            this.Text = "Inicio de Sesión";
            ((System.ComponentModel.ISupportInitialize)(this.imagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.PictureBox imagen;
        private System.Windows.Forms.Label usuarioLabel;
        private System.Windows.Forms.ComboBox UsuarioComboBox;
        private System.Windows.Forms.Label ContraseñaLabel;
        private System.Windows.Forms.TextBox contraseñaTextBox;
        private System.Windows.Forms.CheckBox recordarUsuarioCheckBox;
        private System.Windows.Forms.LinkLabel registrarUsuarioLinkLabel;
    }

}