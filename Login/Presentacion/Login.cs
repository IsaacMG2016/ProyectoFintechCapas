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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            salir.BackgroundImage = (System.Drawing.Image)(Properties.Resources.botonClic_6);
            salir.Refresh();
            //salir.ForeColor = Color.White;
            System.Threading.Thread.Sleep(80);
            FormPruebasButton nuevo = new FormPruebasButton();
            nuevo.ShowDialog();
            //Login.ActiveForm.Close();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            aceptar.BackgroundImage = (System.Drawing.Image)(Properties.Resources.botonClic_6);
            aceptar.Refresh();
            System.Threading.Thread.Sleep(80);
            Principal ventana = new Principal();
            ventana.inicioCorrecto();
        }

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
    }
}
