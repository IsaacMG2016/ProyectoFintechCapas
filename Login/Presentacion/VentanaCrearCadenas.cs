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
    public partial class VentanaCrearCadenas : Form
    {
        /*Aquí es donde debes poner lo de la ventana que 
          estas haciendo alex.
          Yo solo puse un boton de prueba ahí tu le pones lo demas que hace falta 
          Por favaor*/

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
