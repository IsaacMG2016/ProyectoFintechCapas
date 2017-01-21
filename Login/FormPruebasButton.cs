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
    public partial class FormPruebasButton : Form
    {
        public FormPruebasButton()
        {
            InitializeComponent();
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackgroundImage = (System.Drawing.Image)(Properties.Resources.botonNormal_6);
            button1.Refresh();
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackgroundImage = (System.Drawing.Image)(Properties.Resources.botonSobre_6);
            button1.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackgroundImage = (System.Drawing.Image)(Properties.Resources.botonClic_6);
            button1.Refresh();
            System.Threading.Thread.Sleep(80);
            MessageBox.Show("ACEPTAR", "aceptar");
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackgroundImage = (System.Drawing.Image)(Properties.Resources.botonNormal_6);
            button2.Refresh();
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackgroundImage = (System.Drawing.Image)(Properties.Resources.botonSobre_6);
            button2.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackgroundImage = (System.Drawing.Image)(Properties.Resources.botonClic_6);
            button2.Refresh();
            System.Threading.Thread.Sleep(80);
            FormPruebasButton.ActiveForm.Close();

        }
    }
}
