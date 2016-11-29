using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Usuario
    {
        private string nombre;
        private string apellido;
        private string nomUsuario;
        private string contraseña;

        public Usuario(string nombre,string apellido, string nomUsuario,string contraseña)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nomUsuario = nomUsuario;
            this.contraseña = contraseña;
        }

        public string getNombre()
        {
            return this.nombre;
        }

        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }

        public string getapellido()
        {
            return this.apellido;
        }

        public void setapellido(string apellido)
        {
            this.apellido = apellido;
        }

        public string getNomUsuario()
        {
            return this.nomUsuario;
        }

        public void setNomUsuario(string nomUsuario)
        {
            this.nomUsuario = nomUsuario;
        }

        public string getContraseña()
        {
            return this.contraseña;
        }

        public void setContraseña(string contraseña)
        {
            this.contraseña = contraseña;
        }

    }
}
