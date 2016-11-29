using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public class Principal
    {
        /*YA funciona las pinches mamadas del Irving 
          Falta que le llame a su chavo el Ruben para que 
          nos de Visto bueno haber si no lo manda a la verga.*/
        public static void Main()
        {
            Principal p = new Principal();
            p.inicia();
        }

        /*Se despliega a la ventana de Inicio de sesión*/
        public void inicia()
        {
            Login l = new Login();
            l.ShowDialog();
        }

        public void inicioCorrecto()
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
