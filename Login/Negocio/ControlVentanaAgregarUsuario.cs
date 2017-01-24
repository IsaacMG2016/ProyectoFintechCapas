using Login.Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Negocio
{
    class ControlVentanaAgregarUsuario
    {
        Usuario user;
        DAOUsuario dao;

        public void inicia()
        {
            VentanaAgregarUsuario ventana = new VentanaAgregarUsuario();
            ventana.ShowDialog();
        }

        public Boolean agregarUsuario(string nombre,string apellido,string usuario,string contraseña,string clave
            ,string area,string perfil,string bn_activo, DateTime fecha_alta, DateTime fecha_baja)
        {
            user = new Usuario(0,nombre,apellido,usuario,contraseña,clave,area,perfil,bn_activo,fecha_alta,fecha_baja);
            dao = new DAOUsuario();
            Boolean agrega = dao.agregarUsuario(user);
            if (agrega == true)
            {
                MessageBox.Show("datos Almacenados exitosamente");
            }
            else
            {
                MessageBox.Show("FALLO AL GENERAR LA CONSULTA");
            }
            return agrega;
        }

    }
}
