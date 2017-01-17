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
        NpgsqlDataAdapter dadapter;
        DataSet dset;

        // m.fec_fecha_hora_inicio,m.fec_fecha_hora_fin, 
        public DataSet consultaUltimasEjecuciones()
        {
            string connstring = ConfigurationManager.ConnectionStrings["conexion_db_pmc"].ConnectionString;
            string query = "select c.nombre,m.*,i.responsable " +
                           "from pmc_rep_exe_monitor as m join pmc_ope_exe_instancia as i "+
                           "on m.id_instancia = i.id_instancia "+
                           "join pmc_cat_enc_cadena as c on i.id_cadena = c.id_cadena "+
                           "order by m.fec_fecha_hora_inicio desc limit 3";
            
            dadapter = new NpgsqlDataAdapter(query,connstring);
            dset = new DataSet();
            dadapter.Fill(dset);
            return dset;
        }
    }
}
