namespace Login
{
    partial class VentanaEjecutarCadenas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaEjecutarCadenas));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelMenuEjec = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxBusqueda = new System.Windows.Forms.GroupBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.groupBoxClasificados = new System.Windows.Forms.GroupBox();
            this.treeViewClasificados = new System.Windows.Forms.TreeView();
            this.groupBoxProcesos = new System.Windows.Forms.GroupBox();
            this.listBoxProcesos = new System.Windows.Forms.ListBox();
            this.buttonEjecutar = new System.Windows.Forms.Button();
            this.groupBoxParametros = new System.Windows.Forms.GroupBox();
            this.panelParametros = new System.Windows.Forms.Panel();
            this.groupBoxSeleccionado = new System.Windows.Forms.GroupBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanelMenuEjec.SuspendLayout();
            this.groupBoxBusqueda.SuspendLayout();
            this.groupBoxClasificados.SuspendLayout();
            this.groupBoxProcesos.SuspendLayout();
            this.groupBoxParametros.SuspendLayout();
            this.groupBoxSeleccionado.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanelMenuEjec);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.buttonEjecutar);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxParametros);
            this.splitContainer1.Panel2.Controls.Add(this.groupBoxSeleccionado);
            this.splitContainer1.Size = new System.Drawing.Size(764, 484);
            this.splitContainer1.SplitterDistance = 254;
            this.splitContainer1.TabIndex = 1;
            // 
            // tableLayoutPanelMenuEjec
            // 
            this.tableLayoutPanelMenuEjec.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanelMenuEjec.ColumnCount = 1;
            this.tableLayoutPanelMenuEjec.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelMenuEjec.Controls.Add(this.groupBoxBusqueda, 0, 0);
            this.tableLayoutPanelMenuEjec.Controls.Add(this.groupBoxClasificados, 0, 1);
            this.tableLayoutPanelMenuEjec.Controls.Add(this.groupBoxProcesos, 0, 2);
            this.tableLayoutPanelMenuEjec.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelMenuEjec.Name = "tableLayoutPanelMenuEjec";
            this.tableLayoutPanelMenuEjec.RowCount = 3;
            this.tableLayoutPanelMenuEjec.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.54967F));
            this.tableLayoutPanelMenuEjec.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.45033F));
            this.tableLayoutPanelMenuEjec.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 201F));
            this.tableLayoutPanelMenuEjec.Size = new System.Drawing.Size(248, 481);
            this.tableLayoutPanelMenuEjec.TabIndex = 0;
            // 
            // groupBoxBusqueda
            // 
            this.groupBoxBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBusqueda.Controls.Add(this.buttonBuscar);
            this.groupBoxBusqueda.Controls.Add(this.textBoxBuscar);
            this.groupBoxBusqueda.Controls.Add(this.labelBuscar);
            this.groupBoxBusqueda.Location = new System.Drawing.Point(3, 3);
            this.groupBoxBusqueda.Name = "groupBoxBusqueda";
            this.groupBoxBusqueda.Size = new System.Drawing.Size(242, 43);
            this.groupBoxBusqueda.TabIndex = 0;
            this.groupBoxBusqueda.TabStop = false;
            this.groupBoxBusqueda.Text = "Busqueda";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Enabled = false;
            this.buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            this.buttonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscar.Location = new System.Drawing.Point(211, 15);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(25, 25);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Location = new System.Drawing.Point(44, 18);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(161, 20);
            this.textBoxBuscar.TabIndex = 1;
            // 
            // labelBuscar
            // 
            this.labelBuscar.AutoSize = true;
            this.labelBuscar.Location = new System.Drawing.Point(0, 21);
            this.labelBuscar.Name = "labelBuscar";
            this.labelBuscar.Size = new System.Drawing.Size(47, 13);
            this.labelBuscar.TabIndex = 0;
            this.labelBuscar.Text = "Nombre ";
            // 
            // groupBoxClasificados
            // 
            this.groupBoxClasificados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxClasificados.Controls.Add(this.treeViewClasificados);
            this.groupBoxClasificados.Location = new System.Drawing.Point(3, 52);
            this.groupBoxClasificados.Name = "groupBoxClasificados";
            this.groupBoxClasificados.Size = new System.Drawing.Size(242, 224);
            this.groupBoxClasificados.TabIndex = 1;
            this.groupBoxClasificados.TabStop = false;
            this.groupBoxClasificados.Text = "Clasificados";
            // 
            // treeViewClasificados
            // 
            this.treeViewClasificados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewClasificados.Location = new System.Drawing.Point(3, 16);
            this.treeViewClasificados.Name = "treeViewClasificados";
            this.treeViewClasificados.Size = new System.Drawing.Size(236, 205);
            this.treeViewClasificados.TabIndex = 0;
            this.treeViewClasificados.DoubleClick += new System.EventHandler(this.treeViewClasificados_DoubleClick);
            // 
            // groupBoxProcesos
            // 
            this.groupBoxProcesos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProcesos.Controls.Add(this.listBoxProcesos);
            this.groupBoxProcesos.Location = new System.Drawing.Point(3, 282);
            this.groupBoxProcesos.Name = "groupBoxProcesos";
            this.groupBoxProcesos.Size = new System.Drawing.Size(242, 196);
            this.groupBoxProcesos.TabIndex = 2;
            this.groupBoxProcesos.TabStop = false;
            this.groupBoxProcesos.Text = "Procesos";
            // 
            // listBoxProcesos
            // 
            this.listBoxProcesos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxProcesos.FormattingEnabled = true;
            this.listBoxProcesos.Location = new System.Drawing.Point(3, 19);
            this.listBoxProcesos.Name = "listBoxProcesos";
            this.listBoxProcesos.Size = new System.Drawing.Size(236, 160);
            this.listBoxProcesos.TabIndex = 0;
            this.listBoxProcesos.DoubleClick += new System.EventHandler(this.listBoxProcesos_DoubleClick);
            // 
            // buttonEjecutar
            // 
            this.buttonEjecutar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEjecutar.Enabled = false;
            this.buttonEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEjecutar.Location = new System.Drawing.Point(0, 445);
            this.buttonEjecutar.Name = "buttonEjecutar";
            this.buttonEjecutar.Size = new System.Drawing.Size(506, 39);
            this.buttonEjecutar.TabIndex = 2;
            this.buttonEjecutar.Text = "Ejecutar";
            this.buttonEjecutar.UseVisualStyleBackColor = true;
            // 
            // groupBoxParametros
            // 
            this.groupBoxParametros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxParametros.Controls.Add(this.panelParametros);
            this.groupBoxParametros.Location = new System.Drawing.Point(3, 176);
            this.groupBoxParametros.Name = "groupBoxParametros";
            this.groupBoxParametros.Size = new System.Drawing.Size(500, 263);
            this.groupBoxParametros.TabIndex = 1;
            this.groupBoxParametros.TabStop = false;
            this.groupBoxParametros.Text = "Parámetros de ejecución";
            // 
            // panelParametros
            // 
            this.panelParametros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelParametros.Location = new System.Drawing.Point(3, 16);
            this.panelParametros.Name = "panelParametros";
            this.panelParametros.Size = new System.Drawing.Size(494, 244);
            this.panelParametros.TabIndex = 0;
            // 
            // groupBoxSeleccionado
            // 
            this.groupBoxSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSeleccionado.Controls.Add(this.textBoxNombre);
            this.groupBoxSeleccionado.Controls.Add(this.textBoxDescripcion);
            this.groupBoxSeleccionado.Location = new System.Drawing.Point(3, 6);
            this.groupBoxSeleccionado.Name = "groupBoxSeleccionado";
            this.groupBoxSeleccionado.Size = new System.Drawing.Size(500, 164);
            this.groupBoxSeleccionado.TabIndex = 0;
            this.groupBoxSeleccionado.TabStop = false;
            this.groupBoxSeleccionado.Text = "Informacion del proceso";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxNombre.Location = new System.Drawing.Point(161, 14);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size(190, 20);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescripcion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.textBoxDescripcion.Location = new System.Drawing.Point(6, 53);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.ReadOnly = true;
            this.textBoxDescripcion.Size = new System.Drawing.Size(488, 105);
            this.textBoxDescripcion.TabIndex = 1;
            // 
            // VentanaEjecutarCadenas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 484);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.Name = "VentanaEjecutarCadenas";
            this.Text = "Ejecutar Cadenas";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanelMenuEjec.ResumeLayout(false);
            this.groupBoxBusqueda.ResumeLayout(false);
            this.groupBoxBusqueda.PerformLayout();
            this.groupBoxClasificados.ResumeLayout(false);
            this.groupBoxProcesos.ResumeLayout(false);
            this.groupBoxParametros.ResumeLayout(false);
            this.groupBoxSeleccionado.ResumeLayout(false);
            this.groupBoxSeleccionado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMenuEjec;
        private System.Windows.Forms.GroupBox groupBoxBusqueda;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.GroupBox groupBoxClasificados;
        private System.Windows.Forms.TreeView treeViewClasificados;
        private System.Windows.Forms.GroupBox groupBoxProcesos;
        private System.Windows.Forms.ListBox listBoxProcesos;
        private System.Windows.Forms.Button buttonEjecutar;
        private System.Windows.Forms.GroupBox groupBoxParametros;
        private System.Windows.Forms.Panel panelParametros;
        private System.Windows.Forms.GroupBox groupBoxSeleccionado;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDescripcion;
    }
}