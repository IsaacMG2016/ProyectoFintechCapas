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
          Isaac MG 12/Ene/2017
          version 0.3
         */

        public static VentanaProgramarCadenas f1;

        public VentanaProgramarCadenas()
        {
            InitializeComponent();
            VentanaProgramarCadenas.f1 = this;
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

        /*Controles de comportamineto para los botones
         ==============================================
         */
        private void aceptar_MouseHover(object sender, EventArgs e)
        {
            aceptar.BackgroundImage = (System.Drawing.Image)(Properties.Resources.botonNormal_6);
            aceptar.Refresh();
        }

        private void aceptar_MouseLeave(object sender, EventArgs e)
        {
            aceptar.BackgroundImage = (System.Drawing.Image)(Properties.Resources.botonSobre_6);
            aceptar.Refresh();
        }
        /* ACEPTAR */
        private void aceptar_Click(object sender, EventArgs e)
        {
            aceptar.BackgroundImage = (System.Drawing.Image)(Properties.Resources.botonClic_6);
            aceptar.Refresh();
            System.Threading.Thread.Sleep(80);

            /*Aquí va la operacion para guardar la captura de la cadena programada*/
            VentanaProgramarCadenas.ActiveForm.Close();
        }

        private void salir_MouseHover(object sender, EventArgs e)
        {
            salir.BackgroundImage = (System.Drawing.Image)(Properties.Resources.botonNormal_6);
            salir.Refresh();
        }

        private void salir_MouseLeave(object sender, EventArgs e)
        {
            salir.BackgroundImage = (System.Drawing.Image)(Properties.Resources.botonSobre_6);
            salir.Refresh();
        }

        /* SALIR */
        private void salir_Click(object sender, EventArgs e)
        {
            salir.BackgroundImage = (System.Drawing.Image)(Properties.Resources.botonClic_6);
            salir.Refresh();
            System.Threading.Thread.Sleep(80);
            VentanaProgramarCadenas.ActiveForm.Close();
        }

        private void seleccionaCadenaButton_MouseHover(object sender, EventArgs e)
        {
            seleccionaCadenaButton.BackgroundImage = (System.Drawing.Image)(Properties.Resources.botonNormal_6);
            seleccionaCadenaButton.Refresh();
        }

        private void seleccionaCadenaButton_MouseLeave(object sender, EventArgs e)
        {
            seleccionaCadenaButton.BackgroundImage = (System.Drawing.Image)(Properties.Resources.botonSobre_6);
            seleccionaCadenaButton.Refresh();
        }

        /* SELECCION DE CADENA */
        private void seleccionaCadenaButton_Click(object sender, EventArgs e)
        {
            seleccionaCadenaButton.BackgroundImage = (System.Drawing.Image)(Properties.Resources.botonClic_6);
            seleccionaCadenaButton.Refresh();
            System.Threading.Thread.Sleep(80);
            Seleccion nuevaSeleccion = new Seleccion();
            nuevaSeleccion.ShowDialog();
        }
        /*===========================================*/

        public void cargaCadena(string cadena)
        {
            seleccionaCadenaTextBox.Text = cadena;
        }
    }
}
