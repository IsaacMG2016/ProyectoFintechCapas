using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
    public class Monitor
    {
        private int id;
        private DateTime fecha_ini;
        private DateTime fecha_fin;
        private string status;
        private int id_instancia;

        public Monitor(int id, DateTime fecha_ini, DateTime fecha_fin, string status, int id_instancia)
        {
            this.Id = id;
            this.Fecha_ini = fecha_ini;
            this.Fecha_fin = fecha_fin;
            this.Status = status;
            this.Id_instancia = id_instancia;
        }

        public int Id
        {
            get{ return id; }
            set{ id = value; }
        }

        public DateTime Fecha_ini
        {
            get{ return fecha_ini; }
            set{ fecha_ini = value; }
        }

        public DateTime Fecha_fin
        {
            get{ return fecha_fin; }
            set{ fecha_fin = value; }
        }

        public string Status
        {
            get{ return status; }
            set{ status = value; }
        }

        public int Id_instancia
        {
            get{ return id_instancia; }
            set{ id_instancia = value; }
        }
    }
}
