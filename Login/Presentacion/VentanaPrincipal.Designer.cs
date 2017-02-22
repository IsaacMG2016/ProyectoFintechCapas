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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.crearCadenas = new System.Windows.Forms.Button();
            this.programarCadenas = new System.Windows.Forms.Button();
            this.ejecutarCadenas = new System.Windows.Forms.Button();
            this.administrar = new System.Windows.Forms.Button();
            this.groupBoxHistorico = new System.Windows.Forms.GroupBox();
            this.historicoDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBoxBusqueda = new System.Windows.Forms.GroupBox();
            this.comboBoxClasificacion = new System.Windows.Forms.ComboBox();
            this.labelPeriodode = new System.Windows.Forms.Label();
            this.labelPeriodoa = new System.Windows.Forms.Label();
            this.dateTimePickerFin = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerInicio = new System.Windows.Forms.DateTimePicker();
            this.labelUltimasF = new System.Windows.Forms.Label();
            this.textBoxNumEjecuciones = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.labelEstatus = new System.Windows.Forms.Label();
            this.labelClasificacion = new System.Windows.Forms.Label();
            this.labelPeriodo = new System.Windows.Forms.Label();
            this.labelUltimasEjec = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.comboBoxEstatus = new System.Windows.Forms.ComboBox();
            this.groupBoxHistorico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.historicoDataGridView)).BeginInit();
            this.groupBoxBusqueda.SuspendLayout();
            this.SuspendLayout();
            // 
            // crearCadenas
            // 
            this.crearCadenas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.crearCadenas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.crearCadenas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crearCadenas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.crearCadenas.Location = new System.Drawing.Point(18, 12);
            this.crearCadenas.Name = "crearCadenas";
            this.crearCadenas.Size = new System.Drawing.Size(118, 100);
            this.crearCadenas.TabIndex = 0;
            this.crearCadenas.Text = "Crear Cadenas";
            this.crearCadenas.UseVisualStyleBackColor = false;
            this.crearCadenas.Click += new System.EventHandler(this.crearCadenas_Click);
            // 
            // programarCadenas
            // 
            this.programarCadenas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.programarCadenas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.programarCadenas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.programarCadenas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.programarCadenas.Location = new System.Drawing.Point(157, 12);
            this.programarCadenas.Name = "programarCadenas";
            this.programarCadenas.Size = new System.Drawing.Size(118, 100);
            this.programarCadenas.TabIndex = 1;
            this.programarCadenas.Text = "Planificar Ejecuciones";
            this.programarCadenas.UseVisualStyleBackColor = false;
            this.programarCadenas.Click += new System.EventHandler(this.programarCadenas_Click);
            // 
            // ejecutarCadenas
            // 
            this.ejecutarCadenas.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ejecutarCadenas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ejecutarCadenas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ejecutarCadenas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ejecutarCadenas.Location = new System.Drawing.Point(297, 12);
            this.ejecutarCadenas.Name = "ejecutarCadenas";
            this.ejecutarCadenas.Size = new System.Drawing.Size(118, 100);
            this.ejecutarCadenas.TabIndex = 2;
            this.ejecutarCadenas.Text = "Ejecutar cadenas";
            this.ejecutarCadenas.UseVisualStyleBackColor = false;
            this.ejecutarCadenas.Click += new System.EventHandler(this.ejecutarCadenas_Click);
            // 
            // administrar
            // 
            this.administrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.administrar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.administrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.administrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administrar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.administrar.Location = new System.Drawing.Point(809, 12);
            this.administrar.Name = "administrar";
            this.administrar.Size = new System.Drawing.Size(118, 100);
            this.administrar.TabIndex = 3;
            this.administrar.Text = "Administrar";
            this.administrar.UseVisualStyleBackColor = false;
            this.administrar.Click += new System.EventHandler(this.administrar_Click);
            // 
            // groupBoxHistorico
            // 
            this.groupBoxHistorico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxHistorico.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxHistorico.Controls.Add(this.historicoDataGridView);
            this.groupBoxHistorico.Controls.Add(this.groupBoxBusqueda);
            this.groupBoxHistorico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBoxHistorico.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxHistorico.Location = new System.Drawing.Point(12, 118);
            this.groupBoxHistorico.Name = "groupBoxHistorico";
            this.groupBoxHistorico.Size = new System.Drawing.Size(921, 433);
            this.groupBoxHistorico.TabIndex = 4;
            this.groupBoxHistorico.TabStop = false;
            this.groupBoxHistorico.Text = "Historial de Ejecuciones";
            // 
            // historicoDataGridView
            // 
            this.historicoDataGridView.AllowUserToAddRows = false;
            this.historicoDataGridView.AllowUserToDeleteRows = false;
            this.historicoDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.historicoDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historicoDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.historicoDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.historicoDataGridView.ColumnHeadersHeight = 40;
            this.historicoDataGridView.Location = new System.Drawing.Point(6, 144);
            this.historicoDataGridView.Name = "historicoDataGridView";
            this.historicoDataGridView.ReadOnly = true;
            this.historicoDataGridView.Size = new System.Drawing.Size(909, 286);
            this.historicoDataGridView.TabIndex = 2;
            // 
            // groupBoxBusqueda
            // 
            this.groupBoxBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBusqueda.Controls.Add(this.comboBoxEstatus);
            this.groupBoxBusqueda.Controls.Add(this.comboBoxClasificacion);
            this.groupBoxBusqueda.Controls.Add(this.labelPeriodode);
            this.groupBoxBusqueda.Controls.Add(this.labelPeriodoa);
            this.groupBoxBusqueda.Controls.Add(this.dateTimePickerFin);
            this.groupBoxBusqueda.Controls.Add(this.dateTimePickerInicio);
            this.groupBoxBusqueda.Controls.Add(this.labelUltimasF);
            this.groupBoxBusqueda.Controls.Add(this.textBoxNumEjecuciones);
            this.groupBoxBusqueda.Controls.Add(this.textBoxNombre);
            this.groupBoxBusqueda.Controls.Add(this.buttonLimpiar);
            this.groupBoxBusqueda.Controls.Add(this.buttonBuscar);
            this.groupBoxBusqueda.Controls.Add(this.labelEstatus);
            this.groupBoxBusqueda.Controls.Add(this.labelClasificacion);
            this.groupBoxBusqueda.Controls.Add(this.labelPeriodo);
            this.groupBoxBusqueda.Controls.Add(this.labelUltimasEjec);
            this.groupBoxBusqueda.Controls.Add(this.labelNombre);
            this.groupBoxBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBoxBusqueda.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxBusqueda.Location = new System.Drawing.Point(6, 19);
            this.groupBoxBusqueda.Name = "groupBoxBusqueda";
            this.groupBoxBusqueda.Size = new System.Drawing.Size(909, 119);
            this.groupBoxBusqueda.TabIndex = 0;
            this.groupBoxBusqueda.TabStop = false;
            this.groupBoxBusqueda.Text = "Busqueda";
            // 
            // comboBoxClasificacion
            // 
            this.comboBoxClasificacion.BackColor = System.Drawing.Color.White;
            this.comboBoxClasificacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClasificacion.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxClasificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBoxClasificacion.FormattingEnabled = true;
            this.comboBoxClasificacion.Location = new System.Drawing.Point(452, 32);
            this.comboBoxClasificacion.Name = "comboBoxClasificacion";
            this.comboBoxClasificacion.Size = new System.Drawing.Size(230, 28);
            this.comboBoxClasificacion.TabIndex = 14;
            this.comboBoxClasificacion.Tag = "";
            // 
            // labelPeriodode
            // 
            this.labelPeriodode.AutoSize = true;
            this.labelPeriodode.Location = new System.Drawing.Point(7, 85);
            this.labelPeriodode.Name = "labelPeriodode";
            this.labelPeriodode.Size = new System.Drawing.Size(24, 17);
            this.labelPeriodode.TabIndex = 13;
            this.labelPeriodode.Text = "de";
            // 
            // labelPeriodoa
            // 
            this.labelPeriodoa.AutoSize = true;
            this.labelPeriodoa.Location = new System.Drawing.Point(223, 86);
            this.labelPeriodoa.Name = "labelPeriodoa";
            this.labelPeriodoa.Size = new System.Drawing.Size(16, 17);
            this.labelPeriodoa.TabIndex = 12;
            this.labelPeriodoa.Text = "a";
            // 
            // dateTimePickerFin
            // 
            this.dateTimePickerFin.Checked = false;
            this.dateTimePickerFin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerFin.Location = new System.Drawing.Point(247, 83);
            this.dateTimePickerFin.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerFin.Name = "dateTimePickerFin";
            this.dateTimePickerFin.ShowCheckBox = true;
            this.dateTimePickerFin.Size = new System.Drawing.Size(185, 23);
            this.dateTimePickerFin.TabIndex = 11;
            // 
            // dateTimePickerInicio
            // 
            this.dateTimePickerInicio.Checked = false;
            this.dateTimePickerInicio.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerInicio.Location = new System.Drawing.Point(32, 83);
            this.dateTimePickerInicio.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateTimePickerInicio.Name = "dateTimePickerInicio";
            this.dateTimePickerInicio.ShowCheckBox = true;
            this.dateTimePickerInicio.Size = new System.Drawing.Size(184, 23);
            this.dateTimePickerInicio.TabIndex = 10;
            // 
            // labelUltimasF
            // 
            this.labelUltimasF.AutoSize = true;
            this.labelUltimasF.Location = new System.Drawing.Point(338, 36);
            this.labelUltimasF.Name = "labelUltimasF";
            this.labelUltimasF.Size = new System.Drawing.Size(84, 17);
            this.labelUltimasF.TabIndex = 9;
            this.labelUltimasF.Text = "Ejecuciones";
            // 
            // textBoxNumEjecuciones
            // 
            this.textBoxNumEjecuciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxNumEjecuciones.Location = new System.Drawing.Point(290, 32);
            this.textBoxNumEjecuciones.Name = "textBoxNumEjecuciones";
            this.textBoxNumEjecuciones.Size = new System.Drawing.Size(41, 26);
            this.textBoxNumEjecuciones.TabIndex = 8;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.textBoxNombre.Location = new System.Drawing.Point(9, 33);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(181, 26);
            this.textBoxNombre.TabIndex = 7;
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLimpiar.Location = new System.Drawing.Point(815, 77);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(75, 29);
            this.buttonLimpiar.TabIndex = 5;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = false;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuscar.Location = new System.Drawing.Point(815, 32);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(75, 28);
            this.buttonBuscar.TabIndex = 4;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // labelEstatus
            // 
            this.labelEstatus.AutoSize = true;
            this.labelEstatus.Location = new System.Drawing.Point(688, 15);
            this.labelEstatus.Name = "labelEstatus";
            this.labelEstatus.Size = new System.Drawing.Size(55, 17);
            this.labelEstatus.TabIndex = 3;
            this.labelEstatus.Text = "Estatus";
            // 
            // labelClasificacion
            // 
            this.labelClasificacion.AutoSize = true;
            this.labelClasificacion.Location = new System.Drawing.Point(524, 15);
            this.labelClasificacion.Name = "labelClasificacion";
            this.labelClasificacion.Size = new System.Drawing.Size(86, 17);
            this.labelClasificacion.TabIndex = 2;
            this.labelClasificacion.Text = "Clasificación";
            // 
            // labelPeriodo
            // 
            this.labelPeriodo.AutoSize = true;
            this.labelPeriodo.Location = new System.Drawing.Point(9, 61);
            this.labelPeriodo.Name = "labelPeriodo";
            this.labelPeriodo.Size = new System.Drawing.Size(141, 17);
            this.labelPeriodo.TabIndex = 1;
            this.labelPeriodo.Text = "Periodo de ejecución";
            // 
            // labelUltimasEjec
            // 
            this.labelUltimasEjec.AutoSize = true;
            this.labelUltimasEjec.Location = new System.Drawing.Point(219, 37);
            this.labelUltimasEjec.Name = "labelUltimasEjec";
            this.labelUltimasEjec.Size = new System.Drawing.Size(58, 17);
            this.labelUltimasEjec.TabIndex = 1;
            this.labelUltimasEjec.Text = "Ultimas:";
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(70, 16);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(58, 17);
            this.labelNombre.TabIndex = 0;
            this.labelNombre.Text = "Nombre";
            // 
            // comboBoxEstatus
            // 
            this.comboBoxEstatus.BackColor = System.Drawing.Color.White;
            this.comboBoxEstatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEstatus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.comboBoxEstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.comboBoxEstatus.FormattingEnabled = true;
            this.comboBoxEstatus.Location = new System.Drawing.Point(691, 32);
            this.comboBoxEstatus.Name = "comboBoxEstatus";
            this.comboBoxEstatus.Size = new System.Drawing.Size(91, 28);
            this.comboBoxEstatus.TabIndex = 15;
            this.comboBoxEstatus.Tag = "";
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(945, 560);
            this.Controls.Add(this.groupBoxHistorico);
            this.Controls.Add(this.administrar);
            this.Controls.Add(this.ejecutarCadenas);
            this.Controls.Add(this.programarCadenas);
            this.Controls.Add(this.crearCadenas);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VentanaPrincipal";
            this.Text = "Process Management  Console";
            this.Load += new System.EventHandler(this.VentanaPrincipal_Load);
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
        private System.Windows.Forms.ComboBox comboBoxClasificacion;
        private System.Windows.Forms.Label labelPeriodode;
        private System.Windows.Forms.Label labelPeriodoa;
        private System.Windows.Forms.DateTimePicker dateTimePickerFin;
        private System.Windows.Forms.DateTimePicker dateTimePickerInicio;
        private System.Windows.Forms.Label labelUltimasF;
        private System.Windows.Forms.TextBox textBoxNumEjecuciones;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.Label labelEstatus;
        private System.Windows.Forms.Label labelClasificacion;
        private System.Windows.Forms.Label labelPeriodo;
        private System.Windows.Forms.Label labelUltimasEjec;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.ComboBox comboBoxEstatus;
    }
}