using Login.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login.Presentacion
{
    public partial class VentanaAgregarUsuario : Form
    {
        public VentanaAgregarUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            DateTime fechaalta = DateTime.Now.Date;
            DateTime fechabaja = DateTime.Now.Date;
            if (string.IsNullOrEmpty(textBox1.Text) || string.IsNullOrEmpty(textBox2.Text) || string.IsNullOrEmpty(textBox3.Text)
                || string.IsNullOrEmpty(textBox4.Text) || string.IsNullOrEmpty(textBox5.Text)
                 || string.IsNullOrEmpty(textBox6.Text) || string.IsNullOrEmpty(textBox7.Text)
                  || comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Debe llenar todos los campos");
            }
            else
            {
                string name = textBox1.Text;
                string apellido = textBox2.Text;
                string usuario = textBox3.Text;
                string password = textBox4.Text;
                string cve = textBox5.Text;
                string area = textBox6.Text;
                string perfil = textBox7.Text;
                string bn_activo = comboBox1.SelectedItem.ToString();
                ControlVentanaAgregarUsuario control = new ControlVentanaAgregarUsuario();
                control.agregarUsuario(name, apellido, usuario, password, cve, area, perfil, bn_activo, fechaalta, fechabaja);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }
    }
}
