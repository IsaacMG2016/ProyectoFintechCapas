namespace Login
{
    partial class VentanaProgramarCadenas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaProgramarCadenas));
            this.salir = new System.Windows.Forms.Button();
            this.aceptar = new System.Windows.Forms.Button();
            this.seleccionaCadenaLabel = new System.Windows.Forms.Label();
            this.seleccionaCadenaTextBox = new System.Windows.Forms.TextBox();
            this.seleccionaCadenaButton = new System.Windows.Forms.Button();
            this.PeriodoLabel = new System.Windows.Forms.Label();
            this.periodoComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.salir.Location = new System.Drawing.Point(627, 291);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(119, 119);
            this.salir.TabIndex = 0;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = false;
            this.salir.Click += new System.EventHandler(this.salir_Click);
            // 
            // aceptar
            // 
            this.aceptar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.aceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aceptar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.aceptar.Location = new System.Drawing.Point(484, 291);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(119, 119);
            this.aceptar.TabIndex = 1;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseVisualStyleBackColor = false;
            // 
            // seleccionaCadenaLabel
            // 
            this.seleccionaCadenaLabel.AutoSize = true;
            this.seleccionaCadenaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccionaCadenaLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.seleccionaCadenaLabel.Location = new System.Drawing.Point(54, 33);
            this.seleccionaCadenaLabel.Name = "seleccionaCadenaLabel";
            this.seleccionaCadenaLabel.Size = new System.Drawing.Size(153, 18);
            this.seleccionaCadenaLabel.TabIndex = 2;
            this.seleccionaCadenaLabel.Text = "Selecciona Cadena";
            // 
            // seleccionaCadenaTextBox
            // 
            this.seleccionaCadenaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccionaCadenaTextBox.Location = new System.Drawing.Point(217, 27);
            this.seleccionaCadenaTextBox.Multiline = true;
            this.seleccionaCadenaTextBox.Name = "seleccionaCadenaTextBox";
            this.seleccionaCadenaTextBox.Size = new System.Drawing.Size(299, 29);
            this.seleccionaCadenaTextBox.TabIndex = 3;
            // 
            // seleccionaCadenaButton
            // 
            this.seleccionaCadenaButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.seleccionaCadenaButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.seleccionaCadenaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seleccionaCadenaButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.seleccionaCadenaButton.Location = new System.Drawing.Point(518, 27);
            this.seleccionaCadenaButton.Name = "seleccionaCadenaButton";
            this.seleccionaCadenaButton.Size = new System.Drawing.Size(47, 29);
            this.seleccionaCadenaButton.TabIndex = 4;
            this.seleccionaCadenaButton.Text = "°°°";
            this.seleccionaCadenaButton.UseVisualStyleBackColor = false;
            // 
            // PeriodoLabel
            // 
            this.PeriodoLabel.AutoSize = true;
            this.PeriodoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.PeriodoLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.PeriodoLabel.Location = new System.Drawing.Point(54, 80);
            this.PeriodoLabel.Name = "PeriodoLabel";
            this.PeriodoLabel.Size = new System.Drawing.Size(60, 18);
            this.PeriodoLabel.TabIndex = 5;
            this.PeriodoLabel.Text = "Periodo";
            // 
            // periodoComboBox
            // 
            this.periodoComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.periodoComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.periodoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.periodoComboBox.FormattingEnabled = true;
            this.periodoComboBox.Items.AddRange(new object[] {
            "Una Vez",
            "Diario",
            "Semanal",
            "Mensual"});
            this.periodoComboBox.Location = new System.Drawing.Point(57, 101);
            this.periodoComboBox.Name = "periodoComboBox";
            this.periodoComboBox.Size = new System.Drawing.Size(175, 28);
            this.periodoComboBox.TabIndex = 6;
            // 
            // VentanaProgramarCadenas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(773, 432);
            this.Controls.Add(this.periodoComboBox);
            this.Controls.Add(this.PeriodoLabel);
            this.Controls.Add(this.seleccionaCadenaButton);
            this.Controls.Add(this.seleccionaCadenaTextBox);
            this.Controls.Add(this.seleccionaCadenaLabel);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VentanaProgramarCadenas";
            this.Text = "Programar Cadenas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Button aceptar;
        private System.Windows.Forms.Label seleccionaCadenaLabel;
        private System.Windows.Forms.TextBox seleccionaCadenaTextBox;
        private System.Windows.Forms.Button seleccionaCadenaButton;
        private System.Windows.Forms.Label PeriodoLabel;
        private System.Windows.Forms.ComboBox periodoComboBox;
    }
}