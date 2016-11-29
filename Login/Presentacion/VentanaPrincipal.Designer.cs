namespace Login
{
    partial class VentanaPrincipal
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
            this.crearCadenas = new System.Windows.Forms.Button();
            this.programarCadenas = new System.Windows.Forms.Button();
            this.ejecutarCadenas = new System.Windows.Forms.Button();
            this.administrar = new System.Windows.Forms.Button();
            this.salir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crearCadenas
            // 
            this.crearCadenas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearCadenas.Location = new System.Drawing.Point(12, 12);
            this.crearCadenas.Name = "crearCadenas";
            this.crearCadenas.Size = new System.Drawing.Size(148, 135);
            this.crearCadenas.TabIndex = 0;
            this.crearCadenas.Text = "Crear Cadenas";
            this.crearCadenas.UseVisualStyleBackColor = true;
            this.crearCadenas.Click += new System.EventHandler(this.crearCadenas_Click);
            // 
            // programarCadenas
            // 
            this.programarCadenas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programarCadenas.Location = new System.Drawing.Point(184, 13);
            this.programarCadenas.Name = "programarCadenas";
            this.programarCadenas.Size = new System.Drawing.Size(148, 135);
            this.programarCadenas.TabIndex = 1;
            this.programarCadenas.Text = "Programar Cadenas";
            this.programarCadenas.UseVisualStyleBackColor = true;
            this.programarCadenas.Click += new System.EventHandler(this.programarCadenas_Click);
            // 
            // ejecutarCadenas
            // 
            this.ejecutarCadenas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejecutarCadenas.Location = new System.Drawing.Point(356, 14);
            this.ejecutarCadenas.Name = "ejecutarCadenas";
            this.ejecutarCadenas.Size = new System.Drawing.Size(148, 134);
            this.ejecutarCadenas.TabIndex = 2;
            this.ejecutarCadenas.Text = "Ejecutar Cadenas";
            this.ejecutarCadenas.UseVisualStyleBackColor = true;
            this.ejecutarCadenas.Click += new System.EventHandler(this.ejecutarCadenas_Click);
            // 
            // administrar
            // 
            this.administrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administrar.Location = new System.Drawing.Point(622, 12);
            this.administrar.Name = "administrar";
            this.administrar.Size = new System.Drawing.Size(148, 134);
            this.administrar.TabIndex = 3;
            this.administrar.Text = "Administrar";
            this.administrar.UseVisualStyleBackColor = true;
            this.administrar.Click += new System.EventHandler(this.administrar_Click);
            // 
            // salir
            // 
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.Location = new System.Drawing.Point(622, 317);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(148, 132);
            this.salir.TabIndex = 4;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = true;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 461);
            this.Controls.Add(this.salir);
            this.Controls.Add(this.administrar);
            this.Controls.Add(this.ejecutarCadenas);
            this.Controls.Add(this.programarCadenas);
            this.Controls.Add(this.crearCadenas);
            this.Name = "VentanaPrincipal";
            this.Text = "VentanaPrincipal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button crearCadenas;
        private System.Windows.Forms.Button programarCadenas;
        private System.Windows.Forms.Button ejecutarCadenas;
        private System.Windows.Forms.Button administrar;
        private System.Windows.Forms.Button salir;
    }
}