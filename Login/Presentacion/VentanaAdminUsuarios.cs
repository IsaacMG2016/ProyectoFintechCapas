using Login.Negocio;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Login.Presentacion
{
    public partial class VentanaAdminUsuarios : Form
    {
        NpgsqlDataAdapter dadapter;
        DataSet dset;
        BindingSource bs;
        NpgsqlDataAdapter dadapter2;
        DataSet dsTiendas;
        ControlVentanaAdminUsuarios control;

        public VentanaAdminUsuarios()
        {
            InitializeComponent();
            mostrarUsuarios();
        }

        public void mostrarUsuarios()
        {
            DAOUsuario dao = new DAOUsuario();
            dadapter=dao.recuperaUsuarios();
            dset = new DataSet();
            dadapter.Fill(dset);
            bs = new BindingSource();
            bs.DataSource = dset.Tables[0].DefaultView;
            bindingNavigator2.BindingSource = bs;
            dataGridView2.DataSource = bs;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string indice=dataGridView2.SelectedCells[0].RowIndex.ToString();
            control = new ControlVentanaAdminUsuarios();
            control.editarUsuarios(indice);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            control = new ControlVentanaAdminUsuarios();
            control.agregarUsuarios();
        }
    }
}
