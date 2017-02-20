using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Parametro
    {
        private int id;
        private int posicion;

        private string nombre;
        private string tipo_dato;
        private string modo;
        
        // para mostrar en la ventana de ejecucion
        public Parametro (string nombre, string tipo_dato, string modo, int posicion)
        {
            this.nombre = nombre;
            this.tipo_dato = tipo_dato;
            this.modo = modo;
        }
        // para almacenar
        public Parametro(int id, int posicion, string nombre, string tipo_dato, string modo)
        {
            this.id = id;
            this.posicion = posicion;
            this.nombre = nombre;
            this.tipo_dato = tipo_dato;
            this.modo = modo;
        }

        public string Modo
        {
            get { return modo; }
            set { modo = value; }
        }

        public string Tipo_dato 
        {
            get { return tipo_dato; }
            set { tipo_dato = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Id
        {
            get{ return id; }
            set{ id = value; }
        }

        public int Posicion
        {
            get{ return posicion; }
            set{ posicion = value; }
        }
    }
}
