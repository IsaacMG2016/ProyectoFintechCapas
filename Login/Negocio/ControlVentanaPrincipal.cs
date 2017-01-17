using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        internal DataTable consultarUltimasEjecuciones()
        {
            DAOMonitor daoMonitor = new DAOMonitor();
            DataTable dtable = daoMonitor.consultaUltimasEjecuciones().Tables[0];
            dtable.Columns.Remove("id_monitor");
            dtable.Columns.Remove("id_instancia");
            return dtable;

        }
    }
}
