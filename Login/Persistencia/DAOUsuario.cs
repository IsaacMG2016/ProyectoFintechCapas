using Npgsql;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    class DAOUsuario
    {
        NpgsqlDataAdapter dadapter;
        DataSet dset;
        BindingSource bs;
        NpgsqlDataAdapter dadapter2;
        DataSet dsTiendas;
        private object convert;
        private SqlConnection conn;
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando = new SqlCommand();


        /*Metodo para agregar usuarios a la base de datos, se hace un INSERT a la tabla usuario*/
        public Boolean agregarUsuario(Usuario user)
        {
            
            string connstring = ConfigurationManager.ConnectionStrings["conexion_db_pmc"].ConnectionString;
            NpgsqlConnection conn = new NpgsqlConnection(connstring);
            conn.Open();
            string consulta = "INSERT INTO public.pmc_cat_sec_usuario(nombre, apellido, nombre_usuario, contraseña, cve_clave, area, perfil, bn_activo, fec_fecha_hora_alta, fec_fecha_hora_baja) values('" +
                user.getNombre() + "','" +
                user.getapellido() + "','" +
                user.getNomUsuario() + "','" +
                user.getContraseña() + "','" +
                user.getClave() + "','" +
                user.getArea() + "','" +
                user.getPerfil() + "','" +
                user.getBn_activo() + "',@fecha_alta,@fecha_baja)";
            NpgsqlCommand comm = new NpgsqlCommand(consulta, conn);
            comm.Parameters.Add("@fecha_alta", NpgsqlTypes.NpgsqlDbType.Date);
            comm.Parameters.Add("@fecha_baja", NpgsqlTypes.NpgsqlDbType.Date);
            comm.Parameters["@fecha_alta"].Value = DateTime.Now.Date;
            comm.Parameters["@fecha_baja"].Value = DateTime.Now.Date;
            int NFilas=comm.ExecuteNonQuery();
            if (NFilas > 0)
            {
                //MessageBox.Show("datos Almacenados exitosamente");
                return true;
            }else
            {
                //MessageBox.Show("FALLO AL GENERAR LA CONSULTA");
                return false;
            }

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

        public NpgsqlDataAdapter recuperaUsuarios()
        {
            
            string connstring = ConfigurationManager.ConnectionStrings["conexion_db_pmc"].ConnectionString;

            dadapter = new NpgsqlDataAdapter("select * from pmc_cat_sec_usuario", connstring);
            return dadapter;
        }
    }
}
