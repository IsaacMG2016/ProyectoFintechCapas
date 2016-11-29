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
    public partial class VentanaPrincipal : Form
    {
        ControlVentanaPrincipal control;

        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void salir_Click(object sender, EventArgs e)
        {
            VentanaPrincipal.ActiveForm.Close();
        }

        private void crearCadenas_Click(object sender, EventArgs e)
        {
            control = new ControlVentanaPrincipal();
            control.crearCadenas();
        }

        private void programarCadenas_Click(object sender, EventArgs e)
        {
            control = new ControlVentanaPrincipal();
            control.programarCadenas();
        }

        private void ejecutarCadenas_Click(object sender, EventArgs e)
        {
            control = new ControlVentanaPrincipal();
            control.ejecutarCadenas();
        }

        private void administrar_Click(object sender, EventArgs e)
        {
            control = new ControlVentanaPrincipal();
            control.administrarUsuarios();
        }

        
    }
}
