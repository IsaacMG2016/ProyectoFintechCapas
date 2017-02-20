namespace Login
{
    class Cadena : Encadenamieto
    {
        /*private string nombre;
        private string descripcion;
        private int categoria;*/

        private Proceso[] procesos;


        public Cadena(string nombre, string descripcion, bool disponible, int categoria, bool bn_parametro, Proceso[] procesos)
            : base(nombre, descripcion, disponible, categoria, bn_parametro)
        {
            this.procesos = procesos;
        }
        public Proceso[] Procesos
        {
            get{ return procesos; }
            set{ procesos = value; }
        }
    }
}