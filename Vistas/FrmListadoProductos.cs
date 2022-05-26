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
            guardar = false;
            llenarFormulario();
        }

        private void button_Guardar_Click(object sender, EventArgs e)
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
            DataTable dtProducto = TrabajarProducto.buscarProductoPorCodigo(nuevoProducto.Prod_Codigo);
            if (dtProducto.Rows.Count != 0)
            {
                MessageBox.Show("Ya existe un producto con ese codigo", titulo);
                return;
            }
            if (guardar == true)
            {
                guardarProducto(nuevoProducto,titulo);
            }
            else
            {
                modificarProducto(nuevoProducto,titulo);
            }
        }
        public void guardarProducto(Producto nuevoProducto, string titulo)
        {
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

        public void modificarProducto(Producto producto, string titulo)
        {
            // Guardar al Usuario en la base de datos
            try
            {
                TrabajarProducto.modificarProducto(producto);
                string mensajeExito = "El producto fue modificado con exito"
                    + "\n Codigo:" + producto.Prod_Codigo
                    + "\n Categoria:" + producto.Prod_Categoria
                    + "\nDescripcion:" + producto.Prod_Descripcion
                    + "\n Precio:" + producto.Prod_Precio;
                    
                MessageBox.Show(mensajeExito, titulo);

                cargarProductos();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error en la modificacion del cliente", titulo);
                MessageBox.Show(err.ToString(), titulo);
            }
            
        }

        private void button_Ordenar_Click(object sender, EventArgs e)
        {
            if (radioButton_Descripcion.Checked == true)
            {
                DataTable dtProductos = TrabajarProducto.ordenarProductosDescripcion();
                dataGridView_Productos.DataSource = dtProductos;
                dataGridView_Productos.Columns["Prod_Descripcion"].DisplayIndex = 0;
            }
            else if (radioButton_Categoria.Checked == true)
            {
                DataTable dtProductos = TrabajarProducto.ordenarProductosCategoria();
                dataGridView_Productos.DataSource = dtProductos;
                dataGridView_Productos.Columns["Prod_Categoria"].DisplayIndex = 0;
            }
        }

        private void textBox_Precio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //validacion dentro del textbox de precio
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
        private void dataGridView_Productos_CurrentCellChanged(object sender, EventArgs e)
        {
            llenarFormulario();
        }
        private void llenarFormulario()
        {
            if (dataGridView_Productos.CurrentRow != null)
            {
                DataGridViewRow currentRow = dataGridView_Productos.CurrentRow;
                textBox_Codigo.Text = currentRow.Cells["Prod_Codigo"].Value.ToString();
                textBox_Categoria.Text = currentRow.Cells["Prod_Categoria"].Value.ToString();
                textBox_Descripcion.Text = currentRow.Cells["Prod_Descripcion"].Value.ToString();
                textBox_Precio.Text = currentRow.Cells["Prod_Precio"].Value.ToString();
            }
        }

        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            string mensaje = "¿Está seguro de eliminar el producto?";
            string titulo = "Eliminar Producto";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            MessageBoxIcon icono = MessageBoxIcon.Question;

            // Mostrar messageBox de confirmación
            DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, icono);

            // Verificar el resultado del messageBox
            if (resultado == DialogResult.No) return;

            // Eliminar Producto
            string producto_codigo = textBox_Codigo.Text;
            try
            {
                TrabajarProducto.eliminarProducto(producto_codigo);
                string mensajeExito = "El producto fue eliminado con exito";
                MessageBox.Show(mensajeExito, titulo);

                // Recargar la ventana
                cargarProductos();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error en la eliminacion del producto", titulo);
                MessageBox.Show(err.ToString(), titulo);
            }
        
        }

    }

       
}
