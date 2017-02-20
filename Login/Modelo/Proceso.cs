using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Proceso : Encadenamieto
    {
        private Parametro[] parametros;

        public Proceso(string nombre, string descripcion, bool disponible, int categoria, bool bn_parametro, Parametro[] parametros)
            :base(nombre, descripcion, disponible, categoria, bn_parametro)
        {
            this.Parametros = parametros;
        }

        public Parametro[] Parametros
        {
            get{ return parametros; }
            set{ parametros = value; }
        }
    }
}
