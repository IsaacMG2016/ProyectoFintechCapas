using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class DAOProceso
    {
        NpgsqlDataAdapter dadapter;

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

        public NpgsqlDataAdapter recuperaProcesos()
        {

            string connstring = ConfigurationManager.ConnectionStrings["conexion_db_pmc"].ConnectionString;

            dadapter = new NpgsqlDataAdapter("select * from pmc_cat_enc_proceso", connstring);
            return dadapter;
        }

    }
}
