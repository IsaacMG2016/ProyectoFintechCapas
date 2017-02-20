using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    /* clase auxiliar para generar el arbol en la ventana de ejecucion
     * el proposito es obtener detalle del proceso seleccionado
     */
    class NodoPanel
    {
        private int id;
        private string nombre;
        private string descripcion;
        private bool parametros;
        private int id_categoria;
        private string elemento;

        public NodoPanel()
        {

        }
        /*public NodoPanel(int id, string nombre, string descripcion, bool parametros)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.parametros = parametros;
        }

        public NodoPanel(int id, string nombre, string descripcion, bool parametros, int id_categoria)
        {
            this.id = id;
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.parametros = parametros;
            this.id_categoria = id_categoria;
        }*/

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }

            set
            {
                nombre = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public bool Parametros
        {
            get
            {
                return parametros;
            }

            set
            {
                parametros = value;
            }
        }

        public int Id_categoria
        {
            get
            {
                return id_categoria;
            }

            set
            {
                id_categoria = value;
            }
        }

        public string Elemento
        {
            get
            {
                return elemento;
            }

            set
            {
                elemento = value;
            }
        }
    }
}