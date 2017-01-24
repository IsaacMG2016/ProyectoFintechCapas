using Login.Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Negocio
{
    class ControlVentanaAdminProcesos
    {
        public void inicia()
        {
            VentanaAdminProcesos ventana = new VentanaAdminProcesos();
            ventana.ShowDialog();
        }
    }
}
