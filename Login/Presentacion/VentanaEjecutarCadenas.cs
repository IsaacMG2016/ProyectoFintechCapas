using System;
using System.Collections;
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
        private ControlVentanaEjecutarCadenas control;

        private DataSet panel_seleccion;
        private NodoPanel seleccionado;
        private ListViewItem.ListViewSubItem parametro_selec;

        public VentanaEjecutarCadenas(ControlVentanaEjecutarCadenas control)
        {
            InitializeComponent();
            this.control = control;
            Muestra_cadenas_procesos();
        }

        // GENERA LOS ARBOLES DE SELECCION DE PROCESOS Y CADENAS
        private void Muestra_cadenas_procesos()
        {
            TreeNode raiz_categoria;
            NodoPanel info_categ, info_proc;

            panel_seleccion = control.Obtener_panel_cad_proc();              // tablas: 0->categorias, 1->cadenas, 2->procesos
            foreach (DataRow proceso in panel_seleccion.Tables[2].Rows)      // GENERA ARBOL DE TODOS LOS PROCESOS DISPONIBLES
            {                                                                // PROCESOS NO CATEGORIZADOS
                info_proc = Generar_info_nodo(proceso, "proceso");
                treeViewProcesos.Nodes.Add(Generar_nodo(info_proc));         
            }
            foreach (DataRow categoria in panel_seleccion.Tables[0].Rows)    // GENERA ARBOL DE CADENAS Y PROCESOS CATEGORIZADOS
            {                                                                
                info_categ = Generar_info_nodo(categoria, "categoria");
                raiz_categoria = Generar_nodo(info_categ);                   // Inserta CATEGORIAS COMO RAIZ
                Generar_ramas(raiz_categoria, 1, info_categ.Id);             // Inserta CADENAS COMO RAMAS   1
                Generar_ramas(raiz_categoria, 2, info_categ.Id);             // iNSERTA PROCESOS COMO RAMAS  2
                treeViewClasificados.Nodes.Add(raiz_categoria);
            }
        }

        // agrega nodos de tabla_origen a raiz
        // tabla_origen: 1->cadenas, 2->procesos
        private void Generar_ramas(TreeNode raiz, int tabla_origen, int id_raiz)
        {
            NodoPanel info_cad;
            string elemento;
            DataRow[] cad_cat = panel_seleccion.Tables[tabla_origen].Select("id_categoria = " + id_raiz);
            if (tabla_origen == 1)
                elemento = "cadena";
            else
                elemento = "proceso";
            foreach (DataRow cadena in cad_cat)
            {
                info_cad = Generar_info_nodo(cadena, elemento);
                raiz.Nodes.Add(Generar_nodo(info_cad));
            }

        }

        // PARA GUARDAR EN LA PROPIEDAD TAG DEL TREENODE Y OBTENER DATOS SOBRE EL PROCESO O CADENA 
        // PRINCIPALMENTE SI ES QUE NECESITA PARAMETROS
        private NodoPanel Generar_info_nodo(DataRow datos_nodo, string elemento)
        {
            NodoPanel nuevo = new NodoPanel();

            nuevo.Id = Int32.Parse(datos_nodo[0].ToString());
            nuevo.Nombre = datos_nodo[1].ToString(); 
            nuevo.Elemento = elemento;             // PARA DIFERENCIAR
            if (!elemento.Equals("categoria"))     // PARA CADENAS Y PROCESOS SE REQUIERE DESPLEGAR MAS DETALLE Y SABER SI REQUIEREN PARAMETROS
            {
                nuevo.Descripcion = datos_nodo[2].ToString();
                nuevo.Parametros = Boolean.Parse(datos_nodo[3].ToString());
                if (datos_nodo[4] != null)
                    nuevo.Id_categoria = Int32.Parse(datos_nodo[4].ToString());
            }
            return nuevo;
        }

        // GENERA EL NODO CON LA INFORMACION EN LA PROPIEDAD TAG OBTENIDA DEL METODO Generar_info_nodo
        private TreeNode Generar_nodo(NodoPanel info_nodo)
        {
            TreeNode nodo = new TreeNode(info_nodo.Nombre);
            nodo.Name = info_nodo.Nombre;
            nodo.Tag = info_nodo;
            return nodo;
        }
        
        private void treeViewClasificados_DoubleClick(object sender, EventArgs e)
        {
            if (treeViewClasificados.SelectedNode.Level != 0) //level 0 -> categorias
            {
                listViewParametros.Clear();
                listViewParametros.Controls.Clear();
                textBoxNombre.Text = treeViewClasificados.SelectedNode.Name;      // MOSTRAR NOMBRE DEL PROCESO SELECCIONADO
                seleccionado = (NodoPanel)treeViewClasificados.SelectedNode.Tag;  // SE HACE EL CAST PARA OBTENER INFO SOBRE EL PROCESO SELECCIONADO
                textBoxDescripcion.Text = seleccionado.Descripcion;               // MOSTRAR DESCRICPCION DEL PROCESO SELECCIONADO
                if (seleccionado.Parametros)        // SI NECESITA PARAMETROS PARA EXTRAERLOS DE LA BD
                {
                    if (seleccionado.Elemento.Equals("proceso")) // SI ES PROCESO SE EXTRAEN LOS PARAMAMETROS CORRESPONDIENTES
                    {
                        DataTable parametros = control.Obtener_parametros(seleccionado.Id);
                        listViewParametros.View = View.Details;  // MOSTRAR INFO SOBRE EL PARAMETRO REQUERIDO
                        LLenaListParametros(listViewParametros, parametros); // LLENAR LISTVIEW CON LA INFORMACION DE CADA PARAMETRO
                        listViewParametros.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                    }
                    else // SI ES CADENA SE BUSCAN LOS PROCESOs QUE LA INTEGRAN Y LUEGO LOS PARAMETROS COREESPONDIENTES A CADA UNO
                    {
                        /* SI LA CADENA CONTIENE CADENAS
                        // falta agregar bd esta caracteristica
                        if (seleccionado.contiene_cadenas)
                        {

                        }
                        else // SI LA CADENA CONTIENE SOLO PROCESOS
                        {*/
                            // BUSCA CADA PROCESO QUE FORMA PARTE DE LA CADENA
                            DataTable procesos_encadenados = control.Obtener_procesos_encadenados(seleccionado.Id);
                            DataTable parametros = new DataTable();
                            // EXTRAER LOS PARAMETROS DE CADA PROCESO Y FUCIONARLOS EN UNA TABLA
                            procesos_encadenados.AsEnumerable().ToList().ForEach(row =>
                            {
                                parametros.Merge(control.Obtener_parametros(Int32.Parse(row["id_proceso"].ToString())));

                            });

                            listViewParametros.View = View.Details;
                            LLenaListParametros(listViewParametros, parametros);
                        //}
                    }

                }
            }
        }

        private void treeViewProcesos_DoubleClick(object sender, EventArgs e)
        {
            listViewParametros.Clear();
            listViewParametros.Controls.Clear();
            textBoxNombre.Text = treeViewProcesos.SelectedNode.Name;      // MOSTRAR NOMBRE DEL PROCESO SELECCIONADO
            seleccionado = (NodoPanel)treeViewProcesos.SelectedNode.Tag;  // SE HACE EL CAST PARA OBTENER INFO SOBRE EL PROCESO SELECCIONADO
            textBoxDescripcion.Text = seleccionado.Descripcion;               // MOSTRAR DESCRICPCION DEL PROCESO SELECCIONADO
            if (seleccionado.Parametros)        // SI NECESITA PARAMETROS PARA EXTRAERLOS DE LA BD
            {
                if (seleccionado.Elemento.Equals("proceso")) // SI ES PROCESO SE EXTRAEN LOS PARAMAMETROS CORRESPONDIENTES
                {
                    DataTable parametros = control.Obtener_parametros(seleccionado.Id);
                    listViewParametros.View = View.Details;  // MOSTRAR INFO SOBRE EL PARAMETRO REQUERIDO
                    LLenaListParametros(listViewParametros, parametros); // LLENAR LISTVIEW CON LA INFORMACION DE CADA PARAMETRO
                    listViewParametros.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
                }
            }
        }

        private void LLenaListParametros(ListView info_parametros, DataTable parametros)
        {
            // TITULO DE LAS COLUMNAS (MODO, TIPO DE DATO, NOMBRE)
            parametros.Columns.Cast<DataColumn>().ToList().ForEach(column => info_parametros.Columns.Add(column.Caption));
            // COLUMNA DONDE SE INGRESARA EL VALOR PARA EL PARAMETRO
            info_parametros.Columns.Add("Valor", 300);
            // IFORMACION DE LOS PARAMETROS
            ListViewItem item;
            parametros.AsEnumerable().ToList().ForEach(row =>
            {
                item = new ListViewItem(Convert.ToString(row[0]));
                row.ItemArray.ToList().Skip(1).ToList().ForEach(value => item.SubItems.Add(Convert.ToString(value)));
                item.SubItems.Add("");
                info_parametros.Items.Add(item);
            });

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

        private void buttonEjecutar_Click(object sender, EventArgs e)
        {
            // crear arreglo de parametros
            ArrayList val_parametros = new ArrayList();
            if (seleccionado.Parametros)    // si el proceso a ejecutar requiere parametros
            {
                foreach (ListViewItem param in listViewParametros.Items)
                {
                    if (param.SubItems[3].Text.Equals(""))
                    {
                        val_parametros.Add(null); // se pueden ejecutar stored's procedures sin algunos parametros
                    }                             // pero se le tiene que pasar null                      
                    else
                    {
                        val_parametros.Add(param.SubItems[3].Text);
                    }
                }
                // si es proceso
                control.Ejecutar_proceso(seleccionado.Nombre, val_parametros);
            }
        }

        private void listViewParametros_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ListView lv = (ListView)sender;
            ListViewHitTestInfo hit_test = lv.HitTest(e.X, e.Y);
            parametro_selec = hit_test.SubItem; // subitem(item) seleccionado {texto}
            if (hit_test.Item.SubItems.IndexOf(hit_test.SubItem) > 2) // solo se modificara la columna de "valor" (3)
            {
                // crea textbox donde se ingresara el valor
                TextBox textBox_param = new TextBox();
                textBox_param.Width = lv.Columns[hit_test.Item.SubItems.IndexOf(hit_test.SubItem)].Width;
                textBox_param.Left = (lv.Left + hit_test.SubItem.Bounds.Left + 3);
                textBox_param.Top = (hit_test.SubItem.Bounds.Top);
                textBox_param.Text = hit_test.SubItem.Text;
                textBox_param.Parent = lv;
                textBox_param.Focus();
                textBox_param.SelectAll();
                textBox_param.BackColor = SystemColors.ActiveCaption;

                textBox_param.KeyUp += new KeyEventHandler(textBox_param_KeyUp);
            }
        }

        private void textBox_param_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyData)
            {
                case Keys.Return: parametro_selec.Text = ((TextBox)sender).Text;
                    ((TextBox)sender).Hide();
                    
                    break;
                case Keys.Escape: ((TextBox)sender).Hide();
                    break;
                default:
                    break;
            }
        }
    }
}