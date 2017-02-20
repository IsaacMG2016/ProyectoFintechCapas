using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public class Principal
    {
        /* El inicio de la aplicaion */
        public static void Main()
        {
            Principal p = new Principal();
            p.inicia();
        }

        /*Se iniciara desplegando la ventana de Inicio de sesión*/
        public void inicia()
        {
            Login l = new Login(this);
            l.ShowDialog();
        }

        public void Ventana_Principal()
        {
            ControlVentanaPrincipal ctrlPrincipal = new ControlVentanaPrincipal();
            ctrlPrincipal.inicia();
        }

        /*Validacion para el incio de sesión FALTA*/
        public Boolean validarUsuario(string nomUser, string pass)
        {
            /*Se tiene que comprobar en la base de datos si el nombre de usuario y contraseña
              son correctos iteractuará con el ***DAOUSUARIO****
             */
            DAOUsuario daoUser = new DAOUsuario();
            Usuario isaac = daoUser.buscaUsuario(nomUser, pass);

            return true;
        } 

    }
}
