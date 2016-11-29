using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class ControlVentanaCrearCadenas
    {

        public void inicia()
        {
            VentanaCrearCadenas ventana = new VentanaCrearCadenas();
            ventana.ShowDialog();
        }
    }
}
