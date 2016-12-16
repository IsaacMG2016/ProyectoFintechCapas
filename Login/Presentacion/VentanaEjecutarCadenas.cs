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
    public partial class VentanaEjecutarCadenas : Form
    {
        public VentanaEjecutarCadenas()
        {
            InitializeComponent();
            //iniDatos()
        }

        /*private void iniDatos()
        {
            throw new NotImplementedException();
        }*/

        private void treeViewClasificados_DoubleClick(object sender, EventArgs e)
        {
            if (treeViewClasificados.SelectedNode.Level != 0)
            {
                panelParametros.Controls.Clear();
                textBoxNombre.Text = treeViewClasificados.SelectedNode.Text;
                textBoxDescripcion.Text = treeViewClasificados.SelectedNode.Tag.ToString();
                //agregaEleParam(5);
            }
        }

        private void listBoxProcesos_DoubleClick(object sender, EventArgs e)
        {
            panelParametros.Controls.Clear();
            textBoxNombre.Text = listBoxProcesos.SelectedItem.ToString();
            TreeNode tn = (TreeNode)listBoxProcesos.SelectedItem;
            textBoxDescripcion.Text = tn.Tag.ToString();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            TreeNode[] buscado = treeViewClasificados.Nodes.Find(textBoxBuscar.Text, true);
            if (buscado.Length == 0)
                if (textBoxBuscar.Text.Equals(""))
                    MessageBox.Show("Ingrese el nombre del reporte");
                else
                    MessageBox.Show("No se encontro");
            else
            {
                treeViewClasificados.SelectedNode = buscado[0];
                treeViewClasificados.SelectedNode.Expand();
                treeViewClasificados.Select();

            }
        }

//------- Comienzo de  etiquetas y cajas de texto para intorucir los parametros
//------------------------------------------------------------------------------
        private void agregaEleParam(int n)
        {
            Point[] posicion = new Point[n];                 //230,20 tamaño textbox; 60,20 tamaño label 

            for (int i = 0; i < n; i++)
            {
                posicion[i].X = 8;
                posicion[i].Y = i * 40 + 20;
                TextBox paramTexBox = creaTextBox(posicion[i], new Size(230, 20));
                Label paramLabel = creaLabel(posicion[i], new Size(90, 20), "parametro" + i.ToString());
                paramTexBox.Parent = panelParametros;
                paramLabel.Parent = panelParametros;
                paramTexBox.Text = "";
            }

        }
        private TextBox creaTextBox(Point posicion, Size tam)
        {
            TextBox textBoxParam = new TextBox();
            posicion.X += 100;
            textBoxParam.Location = posicion;
            textBoxParam.Size = tam;
            textBoxParam.TextChanged += new System.EventHandler(TextBoxOnTextChanged);
            return textBoxParam;
        }

        private Label creaLabel(Point posicion, Size tam, string nombre)
        {
            Label paramLabel = new Label();
            paramLabel.Location = posicion;
            paramLabel.Size = tam;
            paramLabel.Text = nombre;
            paramLabel.TextChanged += new System.EventHandler(LabelOnTextChanged);
            return paramLabel;

        }

        private void LabelOnTextChanged(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
        }

        private void TextBoxOnTextChanged(object sender, EventArgs e)
        {
            TextBox ptb = (TextBox)sender;
        }
//------Fin del codigo necesario para la introuduccion de los parametros
    }
}
