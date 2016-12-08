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
            this.groupBoxHistorico = new System.Windows.Forms.GroupBox();
            this.historicoDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBoxBusqueda = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBoxClasificacion = new System.Windows.Forms.ComboBox();
            this.labelPeriodode = new System.Windows.Forms.Label();
            this.labelPeriodoa = new System.Windows.Forms.Label();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.labelUltimasF = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelEstatus = new System.Windows.Forms.Label();
            this.labelClasificacion = new System.Windows.Forms.Label();
            this.labelPeriodo = new System.Windows.Forms.Label();
            this.labelUltimasEjec = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.groupBoxHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historicoDataGridView)).BeginInit();
            this.groupBoxBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // crearCadenas
            // 
            this.crearCadenas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearCadenas.Location = new System.Drawing.Point(12, 12);
            this.crearCadenas.Name = "crearCadenas";
            this.crearCadenas.Size = new System.Drawing.Size(100, 100);
            this.crearCadenas.TabIndex = 0;
            this.crearCadenas.Text = "Crear Cadenas";
            this.crearCadenas.UseVisualStyleBackColor = true;
            this.crearCadenas.Click += new System.EventHandler(this.crearCadenas_Click);
            // 
            // programarCadenas
            // 
            this.programarCadenas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programarCadenas.Location = new System.Drawing.Point(136, 12);
            this.programarCadenas.Name = "programarCadenas";
            this.programarCadenas.Size = new System.Drawing.Size(100, 100);
            this.programarCadenas.TabIndex = 1;
            this.programarCadenas.Text = "Planificar ejecuciones";
            this.programarCadenas.UseVisualStyleBackColor = true;
            this.programarCadenas.Click += new System.EventHandler(this.programarCadenas_Click);
            // 
            // ejecutarCadenas
            // 
            this.ejecutarCadenas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejecutarCadenas.Location = new System.Drawing.Point(260, 12);
            this.ejecutarCadenas.Name = "ejecutarCadenas";
            this.ejecutarCadenas.Size = new System.Drawing.Size(100, 100);
            this.ejecutarCadenas.TabIndex = 2;
            this.ejecutarCadenas.Text = "Ejecutar cadenas";
            this.ejecutarCadenas.UseVisualStyleBackColor = true;
            this.ejecutarCadenas.Click += new System.EventHandler(this.ejecutarCadenas_Click);
            // 
            // administrar
            // 
            this.administrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.administrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administrar.Location = new System.Drawing.Point(833, 12);
            this.administrar.Name = "administrar";
            this.administrar.Size = new System.Drawing.Size(100, 100);
            this.administrar.TabIndex = 3;
            this.administrar.Text = "Administrar";
            this.administrar.UseVisualStyleBackColor = true;
            this.administrar.Click += new System.EventHandler(this.administrar_Click);
            // 
            // groupBoxHistorico
            // 
            this.groupBoxHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxHistorico.Controls.Add(this.historicoDataGridView);
            this.groupBoxHistorico.Controls.Add(this.groupBoxBusqueda);
            this.groupBoxHistorico.Location = new System.Drawing.Point(12, 118);
            this.groupBoxHistorico.Name = "groupBoxHistorico";
            this.groupBoxHistorico.Size = new System.Drawing.Size(921, 433);
            this.groupBoxHistorico.TabIndex = 4;
            this.groupBoxHistorico.TabStop = false;
            this.groupBoxHistorico.Text = "Historial de ejecuciones";
            // 
            // historicoDataGridView
            // 
            this.historicoDataGridView.AllowUserToAddRows = false;
            this.historicoDataGridView.AllowUserToDeleteRows = false;
            this.historicoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historicoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historicoDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveBorder;
            this.historicoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.historicoDataGridView.ColumnHeadersHeight = 40;
            this.historicoDataGridView.Location = new System.Drawing.Point(6, 134);
            this.historicoDataGridView.Name = "historicoDataGridView";
            this.historicoDataGridView.ReadOnly = true;
            this.historicoDataGridView.Size = new System.Drawing.Size(909, 284);
            this.historicoDataGridView.TabIndex = 2;
            // 
            // groupBoxBusqueda
            // 
            this.groupBoxBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBusqueda.Controls.Add(this.comboBox1);
            this.groupBoxBusqueda.Controls.Add(this.comboBoxClasificacion);
            this.groupBoxBusqueda.Controls.Add(this.labelPeriodode);
            this.groupBoxBusqueda.Controls.Add(this.labelPeriodoa);
            this.groupBoxBusqueda.Controls.Add(this.dateTimePickerFin);
            this.groupBoxBusqueda.Controls.Add(this.dateTimePickerInicio);
            this.groupBoxBusqueda.Controls.Add(this.labelUltimasF);
            this.groupBoxBusqueda.Controls.Add(this.textBox2);
            this.groupBoxBusqueda.Controls.Add(this.textBox1);
            this.groupBoxBusqueda.Controls.Add(this.buttonLimpiar);
            this.groupBoxBusqueda.Controls.Add(this.buttonBuscar);
            this.groupBoxBusqueda.Controls.Add(this.labelEstatus);
            this.groupBoxBusqueda.Controls.Add(this.labelClasificacion);
            this.groupBoxBusqueda.Controls.Add(this.labelPeriodo);
            this.groupBoxBusqueda.Controls.Add(this.labelUltimasEjec);
            this.groupBoxBusqueda.Controls.Add(this.labelNombre);
            this.groupBoxBusqueda.Location = new System.Drawing.Point(6, 19);
            this.groupBoxBusqueda.Name = "groupBoxBusqueda";
            this.groupBoxBusqueda.Size = new System.Drawing.Size(909, 109);
            this.groupBoxBusqueda.TabIndex = 0;
            this.groupBoxBusqueda.TabStop = false;
            this.groupBoxBusqueda.Text = "Busqueda";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(652, 35);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // comboBoxClasificacion
            // 
            this.comboBoxClasificacion.FormattingEnabled = true;
            this.comboBoxClasificacion.Location = new System.Drawing.Point(451, 35);
            this.comboBoxClasificacion.Name = "comboBoxClasificacion";
            this.comboBoxClasificacion.Size = new System.Drawing.Size(181, 21);
            this.comboBoxClasificacion.TabIndex = 14;
            // 
            // labelPeriodode
            // 
            this.labelPeriodode.AutoSize = true;
            this.labelPeriodode.Location = new System.Drawing.Point(6, 80);
            this.labelPeriodode.Name = "labelPeriodode";
            this.labelPeriodode.Size = new System.Drawing.Size(19, 13);
            this.labelPeriodode.TabIndex = 13;
            this.labelPeriodode.Text = "de";
            // 
            // labelPeriodoa
            // 
            this.labelPeriodoa.AutoSize = true;
            this.labelPeriodoa.Location = new System.Drawing.Point(221, 80);
            this.labelPeriodoa.Name = "labelPeriodoa";
            this.labelPeriodoa.Size = new System.Drawing.Size(13, 13);
            this.labelPeriodoa.TabIndex = 12;
            this.labelPeriodoa.Text = "a";
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Location = new System.Drawing.Point(240, 78);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.ShowCheckBox = true;
            this.dateTimePickerFin.Size = new System.Drawing.Size(185, 20);
            this.dateTimePickerFin.TabIndex = 11;
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Location = new System.Drawing.Point(31, 78);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.ShowCheckBox = true;
            this.dateTimePickerInicio.Size = new System.Drawing.Size(184, 20);
            this.dateTimePickerInicio.TabIndex = 10;
            // 
            // labelUltimasF
            // 
            this.labelUltimasF.AutoSize = true;
            this.labelUltimasF.Location = new System.Drawing.Point(324, 35);
            this.labelUltimasF.Name = "labelUltimasF";
            this.labelUltimasF.Size = new System.Drawing.Size(64, 13);
            this.labelUltimasF.TabIndex = 9;
            this.labelUltimasF.Text = "ejecuciones";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(277, 32);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(41, 20);
            this.textBox2.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 32);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 20);
            this.textBox1.TabIndex = 7;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(828, 80);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 23);
            this.buttonLimpiar.TabIndex = 5;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Location = new System.Drawing.Point(828, 30);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscar.TabIndex = 4;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // labelEstatus
            // 
            this.labelEstatus.AutoSize = true;
            this.labelEstatus.Location = new System.Drawing.Point(689, 16);
            this.labelEstatus.Name = "labelEstatus";
            this.labelEstatus.Size = new System.Drawing.Size(42, 13);
            this.labelEstatus.TabIndex = 3;
            this.labelEstatus.Text = "Estatus";
            // 
            // labelClasificacion
            // 
            this.labelClasificacion.AutoSize = true;
            this.labelClasificacion.Location = new System.Drawing.Point(495, 16);
            this.labelClasificacion.Name = "labelClasificacion";
            this.labelClasificacion.Size = new System.Drawing.Size(66, 13);
            this.labelClasificacion.TabIndex = 2;
            this.labelClasificacion.Text = "Clasificación";
            // 
            // labelPeriodo
            // 
            this.labelPeriodo.AutoSize = true;
            this.labelPeriodo.Location = new System.Drawing.Point(21, 55);
            this.labelPeriodo.Name = "labelPeriodo";
            this.labelPeriodo.Size = new System.Drawing.Size(107, 13);
            this.labelPeriodo.TabIndex = 1;
            this.labelPeriodo.Text = "Periodo de ejecución";
            // 
            // labelUltimasEjec
            // 
            this.labelUltimasEjec.AutoSize = true;
            this.labelUltimasEjec.Location = new System.Drawing.Point(227, 35);
            this.labelUltimasEjec.Name = "labelUltimasEjec";
            this.labelUltimasEjec.Size = new System.Drawing.Size(44, 13);
            this.labelUltimasEjec.TabIndex = 1;
            this.labelUltimasEjec.Text = "Ultimas:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(75, 16);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 560);
            this.Controls.Add(this.groupBoxHistorico);
            this.Controls.Add(this.administrar);
            this.Controls.Add(this.ejecutarCadenas);
            this.Controls.Add(this.programarCadenas);
            this.Controls.Add(this.crearCadenas);
            this.Name = "VentanaPrincipal";
            this.Text = "Process Management  Console";
            this.groupBoxHistorico.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.historicoDataGridView)).EndInit();
            this.groupBoxBusqueda.ResumeLayout(false);
            this.groupBoxBusqueda.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button crearCadenas;
        private System.Windows.Forms.Button programarCadenas;
        private System.Windows.Forms.Button ejecutarCadenas;
        private System.Windows.Forms.Button administrar;
        private System.Windows.Forms.GroupBox groupBoxHistorico;
        private System.Windows.Forms.GroupBox groupBoxBusqueda;
        private System.Windows.Forms.DataGridView historicoDataGridView;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBoxClasificacion;
        private System.Windows.Forms.Label labelPeriodode;
        private System.Windows.Forms.Label labelPeriodoa;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.Label labelUltimasF;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelEstatus;
        private System.Windows.Forms.Label labelClasificacion;
        private System.Windows.Forms.Label labelPeriodo;
        private System.Windows.Forms.Label labelUltimasEjec;
        private System.Windows.Forms.Label labelNombre;
    }
}