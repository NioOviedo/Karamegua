using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TuNamespace.CapaNegocios;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace CapaPresentacion
{
    public partial class Form1 : Form
    {
        CN_Productos objetoCN = new CN_Productos();
        private string idProducto = null;
        private bool Editar = false;

        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load); //
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MostrarProdctos();
        }

        private void MostrarProdctos()
        {

            CN_Productos objeto = new CN_Productos();
            dataGridView1.DataSource = objeto.MostrarProd();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();

                if (!string.IsNullOrEmpty(idProducto))
                {
                    try
                    {
                        objetoCN.EliminarProd(idProducto); // Asegúrate de que el método EliminarPRod acepta una cadena
                        MessageBox.Show("Producto eliminado correctamente.");
                        MostrarProdctos(); // Actualiza la grilla después de eliminar
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("No se pudo eliminar el producto: " + ex.Message);
                    }
                }
                else
                {
                    MessageBox.Show("El ID del producto no es válido.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor.");
            }
        }

        private void limpiarForm()
        {
            txtDescripcion.Clear();
            txtMarca.Text = "";
            txtPrecio.Clear();
            txtStock.Clear();
            txtNombre.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //INSERTAR
            if (Editar == false)
            {
                try
                {
                    objetoCN.InsertarProd(txtNombre.Text, txtDescripcion.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text);
                    MessageBox.Show("se inserto correctamente");
                    MostrarProdctos();
                    limpiarForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo insertar los datos por: " + ex);
                }
            }
            //EDITAR
            if (Editar == true)
            {
                try
                {
                    objetoCN.EditarProd(idProducto, txtNombre.Text, txtDescripcion.Text, txtMarca.Text, txtPrecio.Text, txtStock.Text);
                    MessageBox.Show("se edito correctamente");
                    MostrarProdctos();
                    limpiarForm();
                    Editar = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("no se pudo editar los datos por: " + ex);
                }
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                Editar = true;

                idProducto = dataGridView1.CurrentRow.Cells["Id"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["Nombre"].Value.ToString();
                txtMarca.Text = dataGridView1.CurrentRow.Cells["Marca"].Value.ToString();
                txtDescripcion.Text = dataGridView1.CurrentRow.Cells["Descripcion"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["Precio"].Value.ToString();
                txtStock.Text = dataGridView1.CurrentRow.Cells["Stock"].Value.ToString();             
            }
            else
                MessageBox.Show("seleccione una fila por favor");
        }
    }
}
