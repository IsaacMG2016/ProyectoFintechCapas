using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Proceso
    {
        private string nombre;
        private string propietario;
        private string descripcion;
        
        public Proceso(string nombre,string propietario,string descripcion)
        {
            this.nombre = nombre;
            this.propietario = propietario;
            this.descripcion = descripcion;
            
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

        public string Propietario
        {
            get
            {
                return propietario;
            }

            set
            {
                propietario = value;
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

    }
}
