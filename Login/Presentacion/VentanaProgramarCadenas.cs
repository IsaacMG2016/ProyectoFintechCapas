using System;
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
    public partial class VentanaProgramarCadenas : Form
    {
        /*Se Modifica la ventana de Programacion de cadenas 
          Isaac MG 29/Nov/2016
          version 0.2
         */
        public VentanaProgramarCadenas()
        {
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            VentanaProgramarCadenas.ActiveForm.Close();
        }

        private void seleccionaCadenaButton_Click(object sender, EventArgs e)
        {
            Seleccion nuevaSeleccion = new Seleccion();
            //FormPruebasButton nuevaSeleccion = new FormPruebasButton();
            nuevaSeleccion.ShowDialog();
        }

        private void periodoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string cadena = periodoComboBox.Text;

            Console.WriteLine("VALOR COMBO : " + cadena);

            if (cadena.Equals("Una Vez"))
            {
                DiasSemanaGroupBox.Enabled = false;
                mesComboBox.Enabled = false;
                diasMesTextBox.Enabled = false;
            }
            if (cadena.Equals("Diario"))
            {
                lunesCheckBox.Checked = true;
                MartesCheckBox.Checked = true;
                miercolesCheckBox.Checked = true;
                JuevesCheckBox.Checked = true;
                viernesCheckBox.Checked = true;
                sabadoCheckBox.Checked = true;
                domingoCheckBox.Checked = true;
                DiasSemanaGroupBox.Enabled = false;
                mesComboBox.Enabled = false; 
            }

            if (cadena.Equals("Semanal"))
            {
                MessageBox.Show("Semanal");
                //groupBox1.Enabled = true;
            }

            if (cadena.Equals("Mensual"))
            {
                //groupBox1.Enabled = true;
                MessageBox.Show("Mensual");
                DiasSemanaGroupBox.Enabled = false;

            }

        }
    }
}
