using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    class DAOMonitor
    {
        DataTable dset;

        // m.fec_fecha_hora_inicio,m.fec_fecha_hora_fin, 

        public DataTable consultaUltimasEjecuciones(int num_ejec)
        {
            Conexion conn = new Conexion();
            conn.Abre_conexion();
            string query = "select c.nombre,m.fec_fecha_hora_inicio,m.fec_fecha_hora_fin,m.status,i.responsable " +
                           "from pmc_rep_exe_monitor as m join pmc_ope_exe_instancia as i "+
                           "on m.id_instancia = i.id_instancia "+
                           "join pmc_cat_enc_cadena as c on i.id_cadena = c.id_cadena "+
                           "order by m.fec_fecha_hora_inicio desc limit "+num_ejec;
            string tabla = "monitor";
            dset = new DataTable();
            dset = conn.Ejecutar(query, tabla).Tables[0];
            conn.Cierra_conexion();
            return dset;
        }

        public DataTable buscar(string condiciones)
        {
            Conexion conn = new Conexion();
            conn.Abre_conexion();
            string query = "select c.nombre,m.fec_fecha_hora_inicio,m.fec_fecha_hora_fin,m.status,i.responsable " +
                            "from pmc_rep_exe_monitor as m join pmc_ope_exe_instancia as i " +
                            "on m.id_instancia = i.id_instancia " +
                            "join pmc_cat_enc_cadena as c on i.id_cadena = c.id_cadena " + condiciones;// + condiciones;
            string tabla = "monitor_busqueda";
            dset = new DataTable();
            dset = conn.Ejecutar(query, tabla).Tables[0];
            conn.Cierra_conexion();
            return dset;
        }
    }
}