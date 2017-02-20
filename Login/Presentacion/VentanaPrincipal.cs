using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class VentanaPrincipal : Form
    {
        private ControlVentanaPrincipal control;

        /*public VentanaPrincipal()
        {
            InitializeComponent();
            mostrarUltimasEjecuciones();
            //control = new ControlVentanaPrincipal();
        }*/
        public class Busqueda
        {
            public string nombre;
            public int num_ejec;
            public string clasificacion;
            public string status;
            public string fecha_ini;
            public string fecha_fin;
            public string periodo_fec_ini;

        }

        public VentanaPrincipal(ControlVentanaPrincipal control)
        {
            InitializeComponent();
            this.control = control;
            mostrarUltimasEjecuciones();
            
        }

        private void VentanaPrincipal_Load(object sender, EventArgs e)
        {
            dateTimePickerInicio.MaxDate = DateTime.Now;
            dateTimePickerFin.MaxDate = DateTime.Now;
            // llenar combox categorias
            // Agrego la opcion de "Todas"
            DataTable categorias_c = new DataTable();
            categorias_c.Columns.Add("id_categoria", typeof(Int32));
            categorias_c.Columns.Add("nombre", typeof(String));
            categorias_c.Rows.Add(0, "Todas");
            categorias_c.Merge(control.llenarCategorias());
            comboBoxClasificacion.DataSource = categorias_c;
            comboBoxClasificacion.ValueMember = "id_categoria";
            comboBoxClasificacion.DisplayMember = "nombre";
        }

        private void crearCadenas_Click(object sender, EventArgs e)
        {
            //control = new ControlVentanaPrincipal();
            control.crearCadenas();

        }

        private void programarCadenas_Click(object sender, EventArgs e)
        {
            //control = new ControlVentanaPrincipal();
            control.programarCadenas();
        }

        private void ejecutarCadenas_Click(object sender, EventArgs e)
        {
            control.ejecutarCadenas();
        }

        private void administrar_Click(object sender, EventArgs e)
        {
            //control = new ControlVentanaPrincipal();
            control.administrarUsuarios();
        }

        private void mostrarUltimasEjecuciones()
        {
            historicoDataGridView.DataSource =  control.consultarUltimasEjecuciones();
        }

        /* Metodos para realizar la busqueda de ejecuciones
         * 
         * 
        */
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Busqueda busqueda = new Busqueda();
            busqueda.nombre = string.IsNullOrEmpty(textBoxNombre.Text)? "": textBoxNombre.Text;
            busqueda.clasificacion = (comboBoxClasificacion.SelectedValue.Equals(0))? "": comboBoxClasificacion.SelectedValue.ToString();
            busqueda.status = (comboBoxEstatus.SelectedItem.ToString().Equals("Todos"))? "": comboBoxEstatus.SelectedItem.ToString();
            if (dateTimePickerInicio.Checked && dateTimePickerFin.Checked)
            {
                if (dateTimePickerInicio.Value < dateTimePickerFin.Value)
                    busqueda.periodo_fec_ini = (NpgsqlTypes.NpgsqlDateTime)Convert.ToDateTime(dateTimePickerInicio.Value.ToShortDateString()) + "' AND '" +
                                               (NpgsqlTypes.NpgsqlDateTime)Convert.ToDateTime(dateTimePickerFin.Value.ToShortDateString() + " 23:59:59");
                else
                {
                    MessageBox.Show("La fecha de inicio es mayor que la de termino","Error de busqueda");
                    return;
                }
            }
            else
            {
                busqueda.periodo_fec_ini = "";
                busqueda.fecha_ini = (!dateTimePickerInicio.Checked) ? "" : ((NpgsqlTypes.NpgsqlDateTime)Convert.ToDateTime(dateTimePickerInicio.Value.ToShortDateString())) + "' AND '" + // todo el dia
                                                                            ((NpgsqlTypes.NpgsqlDateTime)Convert.ToDateTime(dateTimePickerInicio.Value.ToShortDateString() + " 23:59:59 "));
                busqueda.fecha_fin = (!dateTimePickerFin.Checked) ? "" : ((NpgsqlTypes.NpgsqlDateTime)Convert.ToDateTime(dateTimePickerFin.Value.ToShortDateString())) + "' AND '" +
                                                                         ((NpgsqlTypes.NpgsqlDateTime)Convert.ToDateTime(dateTimePickerFin.Value.ToShortDateString() + " 23:59:59 "));
            }
            busqueda.num_ejec = textBoxNumEjecuciones.Text.Equals("") ? 0 : Int32.Parse(textBoxNumEjecuciones.Text);
            historicoDataGridView.DataSource = control.buscar(busqueda);
        }

        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            textBoxNombre.Clear();
            textBoxNumEjecuciones.Clear();
            comboBoxClasificacion.SelectedValue = 0;
            comboBoxEstatus.SelectedIndex = 0;
            dateTimePickerInicio.Checked = false;
            dateTimePickerFin.Checked = false;
        }

        
    }
}