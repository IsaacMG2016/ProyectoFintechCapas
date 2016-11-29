using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class ControlVentanaPrincipal
    {

        public void inicia()
        {
            VentanaPrincipal menu = new VentanaPrincipal();
            menu.ShowDialog();
        }
        
        public void crearCadenas()
        {
            ControlVentanaCrearCadenas control = new ControlVentanaCrearCadenas();
            control.inicia();
        }

        public void programarCadenas()
        {
            ControlVentanaProgramarCadenas control = new ControlVentanaProgramarCadenas();
            control.inicia();
        }

        public void ejecutarCadenas()
        {
            ControlVentanaEjecutarCadenas control = new ControlVentanaEjecutarCadenas();
            control.inicia();
        }

        public void administrarUsuarios()
        {
            ControlVentanaAdministracionUsuarios control = new ControlVentanaAdministracionUsuarios();
            control.inicia();
        }
    }
}
