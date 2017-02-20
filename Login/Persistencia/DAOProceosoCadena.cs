using System;
using System.Data;

using System.Configuration;
using Npgsql;
using System.Data;
namespace Login
{
    internal class DAOProceosoCadena
    {
        private DataTable datosbd;
        public DAOProceosoCadena()
        {
        }
        // OBTIENE LOS PROCESOS QUE CONFORMAN UNA CADENA
        internal DataTable Obten_procesos_encadenados(int id)
        {
            Conexion conn = new Conexion();
            conn.Abre_conexion();

            string query = "select * from pmc_brg_enc_proceso_cadena where id_cadena = " + id + " order by posicion_en_cadena";
            datosbd = conn.Ejecutar(query,"pmc_brg_enc_proceso_cadena").Tables[0];
            return datosbd;
        }
    }
}