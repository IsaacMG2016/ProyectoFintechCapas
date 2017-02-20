using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Conexion
    {
        NpgsqlConnection conn;

        public NpgsqlConnection Abre_conexion()
        {
            string info_conexion = "Host=127.0.0.1;Port=5432;Database=db_pmc;Username=postgres;Password=root";

            if (!string.IsNullOrWhiteSpace(info_conexion))
            {
                try
                {
                    conn = new NpgsqlConnection(info_conexion);
                    conn.Open();
                }
                catch (Exception)
                {
                    conn.Close();
                }
            }
            return conn;
        }

        public void Cierra_conexion()
        {
            conn.Close();
        }

        public DataSet Ejecutar(string query, string tabla)
        {
            NpgsqlDataAdapter cmd = new NpgsqlDataAdapter(query, conn);
            DataSet dset = new DataSet();
            cmd.Fill(dset,tabla);

            return dset;
        }

    }
}
