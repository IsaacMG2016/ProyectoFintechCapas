using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class DAOProceso
    {
        NpgsqlDataAdapter dadapter;
        DataTable datosbd;

        public Boolean agregarProceso(Proceso proc)
        {
            return true;
        }

        public Boolean eliminarProceso(Proceso proc)
        {
            return true;
        }

        public Proceso bucarProceso(string nombre)
        {
            return null;
        }

        internal DataTable Obten_procesos()
        {
            Conexion conn = new Conexion();
            conn.Abre_conexion();

            string query = "select * from pmc_cat_enc_proceso";
            datosbd = conn.Ejecutar(query, "pmc_cat_enc_proceso").Tables[0];
            conn.Cierra_conexion();
            return datosbd;
        }

        public NpgsqlDataAdapter recuperaProcesos()
        {

            string connstring = ConfigurationManager.ConnectionStrings["conexion_db_pmc"].ConnectionString;

            dadapter = new NpgsqlDataAdapter("select * from pmc_cat_enc_proceso", connstring);
            return dadapter;
        }
    }
}
