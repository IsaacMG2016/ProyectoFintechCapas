using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public abstract class Encadenamieto
    {
        private int id;
        private string nombre;
        private string prop_creador;
        private string descripcion;
        private DateTime fecha_creacion;
        private bool disponible;
        private DateTime fecha_alta;
        private DateTime fecha_baja;
        private int categoria;
        private bool bn_parametro;

        public Encadenamieto(string nombre,string descripcion, bool disponible, int categoria, bool parametro)
        {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.disponible = disponible;
            this.categoria = categoria;
            this.bn_parametro = parametro;
        }

        protected int Id
        {
            get{ return id; }
            set{ id = value; }
        }

        protected string Nombre
        {
            get{ return nombre; }
            set{ nombre = value; }
        }

        protected string Prop_creador
        {
            get
            {
                return prop_creador;
            }

            set
            {
                prop_creador = value;
            }
        }

        protected string Descripcion
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

        protected DateTime Fecha_creacion
        {
            get
            {
                return fecha_creacion;
            }

            set
            {
                fecha_creacion = value;
            }
        }

        protected bool Disponible
        {
            get
            {
                return disponible;
            }

            set
            {
                disponible = value;
            }
        }

        protected DateTime Fecha_alta
        {
            get
            {
                return fecha_alta;
            }

            set
            {
                fecha_alta = value;
            }
        }

        protected DateTime Fecha_baja
        {
            get
            {
                return fecha_baja;
            }

            set
            {
                fecha_baja = value;
            }
        }

        protected int Categoria
        {
            get
            {
                return categoria;
            }

            set
            {
                categoria = value;
            }
        }

        protected bool Bn_parametro
        {
            get
            {
                return bn_parametro;
            }

            set
            {
                bn_parametro = value;
            }
        }
    }
}
