using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    class DAOUsuario
    {
        /*En esta clase va lo del DataSet, la conexion con 
          la Base de Datos y los query's */

        /*Metodos para la manipulacion de los usuarios */

        /*Metodo para agregar usuarios a la base de datos, se hace un INSERT a la tabla usuario*/
        public Boolean agregarUsuario(Usuario user)
        {
            return true;
        }
        /*Metodo para eliminar un usuario de la base de datos, se hace un DELETE a la tabla usuario*/
        public Boolean eliminaUsuario(Usuario user)
        {
            return true;
        }
        /*Metodo para buscar en la base de datos un usuario por nombre y pass*/
        public Usuario buscaUsuario(string nombre,string password)
        {
            return null;
        }
    }
}
