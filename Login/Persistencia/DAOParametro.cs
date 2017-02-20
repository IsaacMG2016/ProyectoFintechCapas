using System;
using System.Data;

using System.Configuration;
using Npgsql;
namespace Login
{
    internal class DAOParametro
    {
        private DataTable datosbd;

        internal DataTable Obten_parametros(int id_proceso)
        {
            Conexion conn = new Conexion();
            conn.Abre_conexion();

            string query = "select modo, tipo_dato, nombre from pmc_cat_enc_parametro where id_proceso = "+id_proceso;
            datosbd = conn.Ejecutar(query, "pmc_cat_enc_parametro").Tables[0];
            return datosbd;
        }
    }
}