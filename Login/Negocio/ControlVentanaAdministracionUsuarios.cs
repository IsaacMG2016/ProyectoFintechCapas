using Login.Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class ControlVentanaAdministracionUsuarios
    {
        public void inicia()
        {
            VentanaAdministracionUsuarios ventana = new VentanaAdministracionUsuarios();
            ventana.ShowDialog();
        }

        public void administrarUsuarios()
        {
            ControlVentanaAdminUsuarios cvau = new ControlVentanaAdminUsuarios();
            cvau.inicia();
        }

        public void administrarProcesos()
        {
            ControlVentanaAdminProcesos cvap = new ControlVentanaAdminProcesos();
            cvap.inicia();
        }
    }
}
