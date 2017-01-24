using Login.Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Negocio
{
    class ControlVentanaEditarUsuario
    {

        public void inicia(string indice)
        {
            VentanaEditarUsuario ventana = new VentanaEditarUsuario(indice);
            ventana.ShowDialog();
        }

    }
}
