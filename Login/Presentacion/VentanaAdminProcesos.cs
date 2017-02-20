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
    public partial class VentanaAdminProcesos : Form
    {
        NpgsqlDataAdapter dadapter;
        DataSet dset;
        BindingSource bs;
        NpgsqlDataAdapter dadapter2;
        DataSet dsTiendas;


        public VentanaAdminProcesos()
        {
            InitializeComponent();
            mostrarProcesos();
        }

        public void mostrarProcesos()
        {
            DAOProceso dao = new DAOProceso();
            dadapter = dao.recuperaProcesos();
            dset = new DataSet();
            dadapter.Fill(dset);
            bs = new BindingSource();
            bs.DataSource = dset.Tables[0].DefaultView;
            bindingNavigator1.BindingSource = bs;
            dataGridView1.DataSource = bs;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
