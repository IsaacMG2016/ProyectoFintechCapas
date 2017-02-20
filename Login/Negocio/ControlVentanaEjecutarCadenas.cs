using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class ControlVentanaEjecutarCadenas
    {
        private DAOCategoria dao_categoria;
        private DAOCadena dao_cadena;
        private DAOProceso dao_proceso;
        private DAOParametro dao_parametro;
        private DAOProceosoCadena dao_proceso_cadena;

        public void inicia()
        {
            VentanaEjecutarCadenas ventana = new VentanaEjecutarCadenas(this);
            ventana.ShowDialog();
        }

        public DataSet Obtener_panel_cad_proc()
        {
            DataSet panel_cp = new DataSet();
            //categorias, procesos y cadenas disponibles
            string condicion = "bn_disponible = true";
            DataRow[] disponibles_cat = Obtener_categorias().Select(condicion);
            DataRow[] disponibles_cad = Obtener_cadenas().Select(condicion);
            DataRow[] disponibles_proc = Obtener_procesos().Select(condicion);

            //campos necesarios
            string[] campos_categoria = { "id_categoria","nombre"};
            string[] campos_cadena = { "id_cadena", "nombre", "dsc_descripcion", "bn_parametros", "id_categoria" };
            string[] campos_proceso = { "id_proceso", "nombre", "dsl_descripcion", "bn_parametros", "id_categoria"};
            
            panel_cp.Tables.Add(disponibles_cat.CopyToDataTable().DefaultView.ToTable(true, campos_categoria));
            panel_cp.Tables.Add(disponibles_cad.CopyToDataTable().DefaultView.ToTable(true, campos_cadena));
            panel_cp.Tables.Add(disponibles_proc.CopyToDataTable().DefaultView.ToTable(true, campos_proceso));

            return panel_cp;
        }
        
        internal DataTable Obtener_categorias()
        {
            dao_categoria = new DAOCategoria();
            return dao_categoria.Obten_categorias();
        }

        internal DataTable Obtener_cadenas()
        {
            dao_cadena = new DAOCadena();
            return dao_cadena.Obten_cadenas();   
        }

        internal DataTable Obtener_procesos()
        {
            dao_proceso = new DAOProceso();
            return dao_proceso.Obten_procesos();
        }

        // OBTIENE LOS PARAMETROS DE UN PROCESO
        public DataTable Obtener_parametros(int id_proceso)
        {
            dao_parametro = new DAOParametro();
            return dao_parametro.Obten_parametros(id_proceso);
        }

        // OBTIENE LOS PROCESOS QUE INTEGRAN LA CADENA IDENTIFICADA POR id 
        public DataTable Obtener_procesos_encadenados(int id)
        {
            dao_proceso_cadena = new DAOProceosoCadena();
            return dao_proceso_cadena.Obten_procesos_encadenados(id);
        }

        internal void Ejecutar_proceso(string nombre, ArrayList val_parametros)
        {
            // datos de instancia

            //dao_instancia = new Instancia();
            // actualizacion de monitor
            // lanzar ventana de seguimiento del proceso
        }
    }
}
