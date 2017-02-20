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
        private DAOMonitor dao_monitor;
        private DAOCategoria dao_categoria;

        public ControlVentanaPrincipal()
        {
            dao_monitor = new DAOMonitor();
            dao_categoria = new DAOCategoria();
        }

        public void inicia()
        {
            VentanaPrincipal modulo_pmc = new VentanaPrincipal(this);
            //modulo_pmc.ShowDialog();
            modulo_pmc.Visible = true;
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

        public DataTable consultarUltimasEjecuciones()
        {
            return dao_monitor.consultaUltimasEjecuciones(3); // valor por default

        }

        public DataTable llenarCategorias()
        {
            ControlVentanaCategoria control = new ControlVentanaCategoria(dao_categoria);
            return control.Dame_categorias();
        }

        public DataTable buscar(VentanaPrincipal.Busqueda busqueda)
        {
            if (busqueda.nombre == "" && busqueda.clasificacion == "" && busqueda.status == "" && busqueda.fecha_ini == "" &&
                busqueda.fecha_fin == "" && busqueda.num_ejec == 0)
            {
                Console.WriteLine("no hay parametros de busqueda");
                return null;
            }
            else
            {
                string condiciones = "where ";
                if (busqueda.nombre != "")
                    condiciones += "c.nombre = '" + busqueda.nombre + "' and ";
                if (busqueda.clasificacion != "")
                    condiciones += "c.id_categoria = " + busqueda.clasificacion + " and ";
                if (busqueda.status != "")
                    condiciones += "m.status = '" + busqueda.status + "' and ";
                if (busqueda.periodo_fec_ini != "")
                {
                    condiciones += "m.fec_fecha_hora_inicio Between '" + busqueda.periodo_fec_ini + "' ";
                }
                else
                {
                    if (busqueda.fecha_ini != "")
                        condiciones += "m.fec_fecha_hora_inicio BETWEEN '" + busqueda.fecha_ini + "' ";
                    if (busqueda.fecha_fin != "")
                        condiciones += "m.fec_fecha_hora_fin BETWEEN '" + busqueda.fecha_fin + "' ";
                }
                if (condiciones.Substring(condiciones.Length - 5).Equals(" and "))
                    condiciones = condiciones.Substring(0, condiciones.Length - 4);
                condiciones += "order by fec_fecha_hora_inicio desc ";
                if (busqueda.num_ejec > 0)
                    condiciones += "limit " + busqueda.num_ejec;
                Console.WriteLine(condiciones);
                return dao_monitor.buscar(condiciones);
            }
        }
    }
}
