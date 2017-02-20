using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Configuration;
using Npgsql;
using System.Data;

namespace Login
{
    public class DAOCategoria
    {
        private DataTable datosbd;
        

        public DataTable Obten_categorias()
        {
            Conexion conn = new Conexion();
            conn.Abre_conexion();
            string query = "select * from pmc_cat_enc_categoria where bn_disponible = true order by id_categoria desc";
            datosbd = conn.Ejecutar(query, "pmc_cat_enc_categoria").Tables[0];
            conn.Cierra_conexion();
            return datosbd;

        }

        // para el combo box  de busqueda en la ventana principal
        // campos -- id y nombre
        public DataTable categorias_busqueda()
        {
            Conexion conn = new Conexion();
            conn.Abre_conexion();
            string query = "select id_categoria, nombre from pmc_cat_enc_categoria where bn_disponible = true order by id_categoria desc";
            datosbd = conn.Ejecutar(query, "pmc_cat_enc_categoria").Tables[0];
            conn.Cierra_conexion();
            return datosbd;
        }

    }
}
