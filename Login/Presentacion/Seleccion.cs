using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
using System.Configuration;

namespace Login
{
    public partial class Seleccion : Form
    {
        NpgsqlDataAdapter dadapter;
        DataSet dset;
        BindingSource bs;

        public Seleccion()
        {
            InitializeComponent();
            desplegaCadenas();
        }
        
        private void seleccionarButton_MouseHover(object sender, EventArgs e)
        {
            seleccionarButton.BackgroundImage = (System.Drawing.Image)(Properties.Resources.botonNormal_6);
            seleccionarButton.Refresh();
        }

        private void seleccionarButton_MouseLeave(object sender, EventArgs e)
        {
            seleccionarButton.BackgroundImage = (System.Drawing.Image)(Properties.Resources.botonSobre_6);
            seleccionarButton.Refresh();
        }

        /* SELECCIÓN */
        private void seleccionarButton_Click(object sender, EventArgs e)
        {
            seleccionarButton.BackgroundImage = (System.Drawing.Image)(Properties.Resources.botonClic_6);
            seleccionarButton.Refresh();
            System.Threading.Thread.Sleep(80);

            /*AQUI VA LA LOGICA DE GUARDAR LA CADENA SELECCIONADA PARA EL TEXTBOX */
            dameCadena();
            Seleccion.ActiveForm.Close();
        }

        /*Obtine el Nomnbre de la cadena del Grid*/
        public void dameCadena()
        {
            VentanaProgramarCadenas.f1.cargaCadena("NUEVA CADENA *_*");
        }

        public void desplegaCadenas()
        {
            
            string connstring = ConfigurationManager.ConnectionStrings["conexion_db_pmc"].ConnectionString;

            dadapter = new NpgsqlDataAdapter("select * from pmc_cat_enc_cadena", connstring);
            dset = new DataSet();
            dadapter.Fill(dset);
            bs = new BindingSource();
            bs.DataSource = dset.Tables[0].DefaultView;
            bindingNavigator1.BindingSource = bs;
            dataGridView1.DataSource = bs;
        }
    }
}
