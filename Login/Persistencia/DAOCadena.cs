using System;

using System.Configuration;
using Npgsql;
using System.Data;
namespace Login
{
    internal class DAOCadena
    {
        DataTable datosbd;

        internal DataTable Obten_cadenas()
        {
            Conexion conn = new Conexion();
            conn.Abre_conexion();

            string query = "select * from pmc_cat_enc_cadena";
            datosbd = conn.Ejecutar(query,"pmc_cat_enc_cadena").Tables[0];
            conn.Cierra_conexion();
            return datosbd;
        }
    }
}