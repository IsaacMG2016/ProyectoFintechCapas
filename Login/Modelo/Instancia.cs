using System;

namespace Login
{
    internal class Instancia
    {
        private DateTime fecha_inicio;
        private DateTime fecha_fin;
        private string responsable;
        private string status;
        private int id_cadena;
        private int id_usuario;

        public Instancia(DateTime fecha_inicio, string responsable, int id_cadena, int id_usuario)
        {
            this.Fecha_inicio = fecha_inicio;
            this.Responsable = responsable;
            this.Status = "R";
            this.Id_cadena = id_cadena;
            this.Id_usuario = id_usuario;
        }

        public DateTime Fecha_inicio
        {
            get
            {
                return fecha_inicio;
            }

            set
            {
                fecha_inicio = value;
            }
        }

        public DateTime Fecha_fin
        {
            get
            {
                return fecha_fin;
            }

            set
            {
                fecha_fin = value;
            }
        }

        public string Responsable
        {
            get
            {
                return responsable;
            }

            set
            {
                responsable = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public int Id_cadena
        {
            get
            {
                return id_cadena;
            }

            set
            {
                id_cadena = value;
            }
        }

        public int Id_usuario
        {
            get
            {
                return id_usuario;
            }

            set
            {
                id_usuario = value;
            }
        }
    }
}