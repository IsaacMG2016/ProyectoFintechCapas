using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Usuario
    {
        private int idUsuario;
        private string nombre;
        private string apellido;
        private string nomUsuario;
        private string contraseña;
        private string clave;
        private string area;
        private string perfil;
        private string bn_activo;
        private DateTime fecha_alta;
        private DateTime fecha_baja;

        public Usuario(int idUsuario,string nombre,string apellido, string nomUsuario,string contraseña, string clave,
            string area, string perfil, string bn_activo, DateTime fecha_alta, DateTime fecha_baja)
        {
            this.idUsuario = idUsuario;
            this.nombre = nombre;
            this.apellido = apellido;
            this.nomUsuario = nomUsuario;
            this.contraseña = contraseña;
            this.clave = clave;
            this.area = area;
            this.perfil = perfil;
            this.bn_activo = bn_activo;
            this.fecha_alta = fecha_alta;
            this.fecha_baja = fecha_baja;
        }

        public int getIdUsuario()
        {
            return this.idUsuario;
        }

        public void setIdUsuario(int idUsuario)
        {
            this.idUsuario = idUsuario;
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

        public string getClave()
        {
            return this.clave;
        }

        public void setClave(string clave)
        {
            this.clave = clave;
        }

        public string getArea()
        {
            return this.area;
        }

        public void setArea(string area)
        {
            this.area = area;
        }

        public string getPerfil()
        {
            return this.perfil;
        }

        public void setPerfil(string perfil)
        {
            this.perfil = perfil;
        }

        public string getBn_activo()
        {
            return this.bn_activo;
        }

        public void setBn_activo(string bn_activo)
        {
            this.bn_activo = bn_activo;
        }

        public DateTime getFecha_alta()
        {
            return this.fecha_alta;
        }

        public void setFecha_alta(DateTime fecha_alta)
        {
            this.fecha_alta = fecha_alta;
        }

        public DateTime getFecha_baja()
        {
            return this.fecha_baja;
        }

        public void setFecha_baja(DateTime fecha_baja)
        {
            this.fecha_baja = fecha_baja;
        }

        public static implicit operator string(Usuario v)
        {
            throw new NotImplementedException();
        }
    }
}
