using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ClasesBase;

namespace Vistas
{
    public partial class FrmListadoProductos : Form
    {
        public bool guardar = false;
        public FrmListadoProductos()
        {
            InitializeComponent();
        }
        private void FrmListadoProductos_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        private void cargarProductos()
        {
             DataTable dtProductos = TrabajarProducto.obtenerProductos();
            dataGridView_Productos.DataSource = dtProductos;
            // Deshabilitar los botones de busqueda, modificar y eliminar si no hay registros
            if (dtProductos.Rows.Count == 0)
            {
                button_Ordenar.Enabled = false;
                radioButton_Categoria.Enabled = false;
                radioButton_Descripcion.Enabled = false;
                button_Eliminar.Enabled = false;
            }
        }
        // Se habilita o deshabilitan controles segun el parametro
        private void cambiarEstadoDeControles(bool estado)
        {
            // botones de búsqueda, eliminar, nuevo cliente y grid de Productos xd
            button_Ordenar.Enabled = estado;
            button_Eliminar.Enabled = estado;
            button_CargarProducto.Enabled = estado;
            radioButton_Categoria.Enabled = estado;
            radioButton_Descripcion.Enabled = estado;
            dataGridView_Productos.Enabled = estado;
            // Estado distinto
            textBox_Codigo.Enabled = !estado;
            button_Cancelar.Visible = !estado;
        }

        private void button_CargarProducto_Click(object sender, EventArgs e)
        {
            textBox_Codigo.Text = "";
            textBox_Categoria.Text = "";
            textBox_Descripcion.Text = "";
            textBox_Precio.Text = "";
            cambiarEstadoDeControles(false);
            guardar = true;
        }

        private void button_Cancelar_Click(object sender, EventArgs e)
        {
            cambiarEstadoDeControles(true);
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            if (guardar == true)
            {
                guardarProducto();
            }
            else
            {
                modificarProducto();
            }
        }
        public void guardarProducto()
        {
            // Parametros del messageBox
            string mensaje = "¿Quiere guardar el producto?";
            string titulo = "Guardar producto";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            MessageBoxIcon icono = MessageBoxIcon.Question;

            // Mostrar messageBox de confirmación
            DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, icono);

            // Verificar el resultado del messageBox
            if (resultado == DialogResult.No)
            {
                MessageBox.Show("La operación fue cancelada", titulo);
                return;
            }

            // Se procede al almacenamiento del producto

            string prodCodigo = textBox_Codigo.Text;
            string prodCategoria = textBox_Categoria.Text;
            string prodDescripcion = textBox_Descripcion.Text;
            // TODO: Manejo de errores en el decimal
            decimal prodPrecio = Convert.ToDecimal(textBox_Precio.Text);

            // TODO: Validaciones de los campos ingresados

            // Creando el producto
            Producto nuevoProducto = new Producto(prodCodigo, prodCategoria, prodDescripcion, prodPrecio);
            try
            {
                TrabajarProducto.insertarProducto(nuevoProducto);
                string mensajeExito = "El producto fue guardado con éxito:"
               + "\nCodigo: " + nuevoProducto.Prod_Codigo
               + "\nCategoria: " + nuevoProducto.Prod_Categoria
               + "\nDescripcion: " + nuevoProducto.Prod_Descripcion
               + "\nPrecio: " + nuevoProducto.Prod_Precio;
                MessageBox.Show(mensajeExito, titulo);
                guardar = false;
                cambiarEstadoDeControles(true);
                cargarProductos();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error en la creación del producto", titulo);
                MessageBox.Show(err.ToString(), titulo);
            }
        }

        public void modificarProducto()
        {
            string titulo = "Guardar producto";
            MessageBox.Show("Error en la creación del producto", titulo);
            
        }
    }
}
