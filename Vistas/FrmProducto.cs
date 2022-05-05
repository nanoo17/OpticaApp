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
    public partial class FrmProducto : Form
    {
        public FrmProducto()
        {
            InitializeComponent();
        }

        private void button_Cargar_Click(object sender, EventArgs e)
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

            string prodCodigo = textBox_ProdCodigo.Text;
            string prodCategoria = textBox_ProdCategoria.Text;
            string prodDescripcion = textBox_ProdDescripcion.Text;
            // TODO: Manejo de errores en el decimal
            decimal prodPrecio = Convert.ToDecimal(textBox_ProdPrecio.Text);

            // TODO: Validaciones de los campos ingresados

            // Creando el producto
            Producto nuevoProducto = new Producto(prodCodigo, prodCategoria, prodDescripcion, prodPrecio);
            string mensajeExito = "El producto fue guardado con éxito:"
                + "\nCodigo: " + nuevoProducto.Prod_Codigo
                + "\nCategoria: " + nuevoProducto.Prod_Categoria
                + "\nDescripcion: " + nuevoProducto.Prod_Descripcion
                + "\nPrecio: " + nuevoProducto.Prod_Precio;

            MessageBox.Show(mensajeExito, titulo);
        }
    }
}
