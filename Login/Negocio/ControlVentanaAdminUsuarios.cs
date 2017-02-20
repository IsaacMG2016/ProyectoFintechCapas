using Login.Presentacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login.Negocio
{
    class ControlVentanaAdminUsuarios
    {
        public void inicia()
        {
            VentanaAdminUsuarios ventana = new VentanaAdminUsuarios();
            ventana.ShowDialog();
        }

        public void agregarUsuarios()
        {
            ControlVentanaAgregarUsuario control = new ControlVentanaAgregarUsuario();
            control.inicia();
        }

        public void editarUsuarios(string indice)
        {
            ControlVentanaEditarUsuario control = new ControlVentanaEditarUsuario();
            control.inicia(indice);
        }
    }
}
