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
            this.splitContainerArbolInfo = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanelMenuEjec = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxBusqueda = new System.Windows.Forms.GroupBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.textBoxBuscar = new System.Windows.Forms.TextBox();
            this.labelBuscar = new System.Windows.Forms.Label();
            this.groupBoxClasificados = new System.Windows.Forms.GroupBox();
            this.treeViewClasificados = new System.Windows.Forms.TreeView();
            this.groupBoxProcesos = new System.Windows.Forms.GroupBox();
            this.treeViewProcesos = new System.Windows.Forms.TreeView();
            this.buttonEjecutar = new System.Windows.Forms.Button();
            this.groupBoxParametros = new System.Windows.Forms.GroupBox();
            this.listViewParametros = new System.Windows.Forms.ListView();
            this.groupBoxSeleccionado = new System.Windows.Forms.GroupBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerArbolInfo)).BeginInit();
            this.splitContainerArbolInfo.Panel1.SuspendLayout();
            this.splitContainerArbolInfo.Panel2.SuspendLayout();
            this.splitContainerArbolInfo.SuspendLayout();
            this.tableLayoutPanelMenuEjec.SuspendLayout();
            this.groupBoxBusqueda.SuspendLayout();
            this.groupBoxClasificados.SuspendLayout();
            this.groupBoxProcesos.SuspendLayout();
            this.groupBoxParametros.SuspendLayout();
            this.groupBoxSeleccionado.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerArbolInfo
            // 
            this.splitContainerArbolInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainerArbolInfo.BackColor = System.Drawing.Color.Transparent;
            this.splitContainerArbolInfo.Location = new System.Drawing.Point(0, 0);
            this.splitContainerArbolInfo.Name = "splitContainerArbolInfo";
            // 
            // splitContainerArbolInfo.Panel1
            // 
            this.splitContainerArbolInfo.Panel1.BackColor = System.Drawing.Color.White;
            this.splitContainerArbolInfo.Panel1.Controls.Add(this.tableLayoutPanelMenuEjec);
            // 
            // splitContainerArbolInfo.Panel2
            // 
            this.splitContainerArbolInfo.Panel2.Controls.Add(this.buttonEjecutar);
            this.splitContainerArbolInfo.Panel2.Controls.Add(this.groupBoxParametros);
            this.splitContainerArbolInfo.Panel2.Controls.Add(this.groupBoxSeleccionado);
            this.splitContainerArbolInfo.Size = new System.Drawing.Size(813, 526);
            this.splitContainerArbolInfo.SplitterDistance = 247;
            this.splitContainerArbolInfo.TabIndex = 1;
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
            this.tableLayoutPanelMenuEjec.Size = new System.Drawing.Size(241, 520);
            this.tableLayoutPanelMenuEjec.TabIndex = 0;
            // 
            // groupBoxBusqueda
            // 
            this.groupBoxBusqueda.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxBusqueda.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxBusqueda.Controls.Add(this.buttonBuscar);
            this.groupBoxBusqueda.Controls.Add(this.textBoxBuscar);
            this.groupBoxBusqueda.Controls.Add(this.labelBuscar);
            this.groupBoxBusqueda.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxBusqueda.Location = new System.Drawing.Point(3, 3);
            this.groupBoxBusqueda.Name = "groupBoxBusqueda";
            this.groupBoxBusqueda.Size = new System.Drawing.Size(235, 49);
            this.groupBoxBusqueda.TabIndex = 0;
            this.groupBoxBusqueda.TabStop = false;
            this.groupBoxBusqueda.Text = "Busqueda";
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonBuscar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuscar.Image = ((System.Drawing.Image)(resources.GetObject("buttonBuscar.Image")));
            this.buttonBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonBuscar.Location = new System.Drawing.Point(204, 18);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(28, 25);
            this.buttonBuscar.TabIndex = 2;
            this.buttonBuscar.UseVisualStyleBackColor = false;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // textBoxBuscar
            // 
            this.textBoxBuscar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBoxBuscar.Location = new System.Drawing.Point(44, 18);
            this.textBoxBuscar.Name = "textBoxBuscar";
            this.textBoxBuscar.Size = new System.Drawing.Size(154, 23);
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
            this.groupBoxClasificados.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxClasificados.Controls.Add(this.treeViewClasificados);
            this.groupBoxClasificados.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxClasificados.Location = new System.Drawing.Point(3, 58);
            this.groupBoxClasificados.Name = "groupBoxClasificados";
            this.groupBoxClasificados.Size = new System.Drawing.Size(235, 257);
            this.groupBoxClasificados.TabIndex = 1;
            this.groupBoxClasificados.TabStop = false;
            this.groupBoxClasificados.Text = "Clasificados";
            // 
            // treeViewClasificados
            // 
            this.treeViewClasificados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewClasificados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewClasificados.Location = new System.Drawing.Point(3, 16);
            this.treeViewClasificados.Name = "treeViewClasificados";
            this.treeViewClasificados.Size = new System.Drawing.Size(229, 238);
            this.treeViewClasificados.TabIndex = 0;
            this.treeViewClasificados.DoubleClick += new System.EventHandler(this.treeViewClasificados_DoubleClick);
            // 
            // groupBoxProcesos
            // 
            this.groupBoxProcesos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxProcesos.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxProcesos.Controls.Add(this.treeViewProcesos);
            this.groupBoxProcesos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBoxProcesos.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxProcesos.Location = new System.Drawing.Point(3, 321);
            this.groupBoxProcesos.Name = "groupBoxProcesos";
            this.groupBoxProcesos.Size = new System.Drawing.Size(235, 196);
            this.groupBoxProcesos.TabIndex = 2;
            this.groupBoxProcesos.TabStop = false;
            this.groupBoxProcesos.Text = "Procesos";
            // 
            // treeViewProcesos
            // 
            this.treeViewProcesos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeViewProcesos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeViewProcesos.Location = new System.Drawing.Point(3, 19);
            this.treeViewProcesos.Name = "treeViewProcesos";
            this.treeViewProcesos.Size = new System.Drawing.Size(229, 174);
            this.treeViewProcesos.TabIndex = 0;
            this.treeViewProcesos.DoubleClick += new System.EventHandler(this.treeViewProcesos_DoubleClick);
            // 
            // buttonEjecutar
            // 
            this.buttonEjecutar.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonEjecutar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonEjecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEjecutar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEjecutar.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonEjecutar.Location = new System.Drawing.Point(0, 487);
            this.buttonEjecutar.Name = "buttonEjecutar";
            this.buttonEjecutar.Size = new System.Drawing.Size(562, 39);
            this.buttonEjecutar.TabIndex = 2;
            this.buttonEjecutar.Text = "Ejecutar";
            this.buttonEjecutar.UseVisualStyleBackColor = false;
            this.buttonEjecutar.Click += new System.EventHandler(this.buttonEjecutar_Click);
            // 
            // groupBoxParametros
            // 
            this.groupBoxParametros.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxParametros.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxParametros.BackgroundImage = global::Login.Properties.Resources.logotipofintechBajochico;
            this.groupBoxParametros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBoxParametros.Controls.Add(this.listViewParametros);
            this.groupBoxParametros.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBoxParametros.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxParametros.Location = new System.Drawing.Point(3, 176);
            this.groupBoxParametros.Name = "groupBoxParametros";
            this.groupBoxParametros.Size = new System.Drawing.Size(552, 271);
            this.groupBoxParametros.TabIndex = 1;
            this.groupBoxParametros.TabStop = false;
            this.groupBoxParametros.Text = "Parámetros de ejecución";
            // 
            // listViewParametros
            // 
            this.listViewParametros.BackgroundImage = global::Login.Properties.Resources.logotipofintechBajochico;
            this.listViewParametros.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewParametros.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewParametros.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewParametros.FullRowSelect = true;
            this.listViewParametros.HideSelection = false;
            this.listViewParametros.Location = new System.Drawing.Point(3, 19);
            this.listViewParametros.Name = "listViewParametros";
            this.listViewParametros.Size = new System.Drawing.Size(546, 249);
            this.listViewParametros.TabIndex = 0;
            this.listViewParametros.UseCompatibleStateImageBehavior = false;
            this.listViewParametros.View = System.Windows.Forms.View.SmallIcon;
            this.listViewParametros.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listViewParametros_MouseDoubleClick);
            // 
            // groupBoxSeleccionado
            // 
            this.groupBoxSeleccionado.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxSeleccionado.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxSeleccionado.Controls.Add(this.textBoxNombre);
            this.groupBoxSeleccionado.Controls.Add(this.textBoxDescripcion);
            this.groupBoxSeleccionado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.groupBoxSeleccionado.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBoxSeleccionado.Location = new System.Drawing.Point(3, 6);
            this.groupBoxSeleccionado.Name = "groupBoxSeleccionado";
            this.groupBoxSeleccionado.Size = new System.Drawing.Size(552, 164);
            this.groupBoxSeleccionado.TabIndex = 0;
            this.groupBoxSeleccionado.TabStop = false;
            this.groupBoxSeleccionado.Text = "Información del proceso";
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBoxNombre.BackColor = System.Drawing.Color.White;
            this.textBoxNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxNombre.Location = new System.Drawing.Point(163, 14);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.ReadOnly = true;
            this.textBoxNombre.Size = new System.Drawing.Size(190, 16);
            this.textBoxNombre.TabIndex = 2;
            this.textBoxNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxDescripcion.BackColor = System.Drawing.Color.White;
            this.textBoxDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxDescripcion.Location = new System.Drawing.Point(6, 53);
            this.textBoxDescripcion.Multiline = true;
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.ReadOnly = true;
            this.textBoxDescripcion.Size = new System.Drawing.Size(541, 105);
            this.textBoxDescripcion.TabIndex = 1;
            // 
            // VentanaEjecutarCadenas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(813, 526);
            this.Controls.Add(this.splitContainerArbolInfo);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "VentanaEjecutarCadenas";
            this.Text = "Ejecutar Cadenas";
            this.splitContainerArbolInfo.Panel1.ResumeLayout(false);
            this.splitContainerArbolInfo.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerArbolInfo)).EndInit();
            this.splitContainerArbolInfo.ResumeLayout(false);
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

        private System.Windows.Forms.SplitContainer splitContainerArbolInfo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelMenuEjec;
        private System.Windows.Forms.GroupBox groupBoxBusqueda;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.TextBox textBoxBuscar;
        private System.Windows.Forms.Label labelBuscar;
        private System.Windows.Forms.GroupBox groupBoxClasificados;
        private System.Windows.Forms.TreeView treeViewClasificados;
        private System.Windows.Forms.GroupBox groupBoxProcesos;
        private System.Windows.Forms.Button buttonEjecutar;
        private System.Windows.Forms.GroupBox groupBoxParametros;
        private System.Windows.Forms.GroupBox groupBoxSeleccionado;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.TreeView treeViewProcesos;
        private System.Windows.Forms.ListView listViewParametros;
    }
}