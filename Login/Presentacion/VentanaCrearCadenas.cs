﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class VentanaCrearCadenas : Form
    {
        public VentanaCrearCadenas()
        {
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            VentanaCrearCadenas.ActiveForm.Close();
        }
    }
}