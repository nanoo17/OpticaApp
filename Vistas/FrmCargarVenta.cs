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
    public partial class FrmCargarVenta : Form
    {
        public FrmCargarVenta()
        {
            InitializeComponent();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            cargarComboClientes();
            cargarProductosGrid();
        }

        // Cargar el comboBox de clientes
        private void cargarComboClientes()
        {
            DataTable dt = ClasesBase.TrabajarCliente.obtenerClientes();
            comboBox_Cliente.DataSource = dt;
            comboBox_Cliente.DisplayMember = "Cli_Nombre";
            comboBox_Cliente.ValueMember = "cli_DNI";

            if (dt.Rows.Count == 0)
            {
                button_Guardar.Enabled = false;
            }
        }

        // Cargar los productos al grid
        private void cargarProductosGrid()
        {
            DataTable dtProductos = ClasesBase.TrabajarProducto.obtenerProductos();
            dataGridView_Producto.DataSource = dtProductos;

            // Deshabilitar botones si no hay productos
            if (dtProductos.Rows.Count == 0)
            {
                button_Guardar.Enabled = false;
            }
        }

        // Guardar venta y detalleVenta
        private void button_Guardar_Click(object sender, EventArgs e)
        {
            // Parametros del messageBox
            string mensaje = "¿Está seguro de guardar esta venta?";
            string titulo = "Guardar Venta";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            MessageBoxIcon icono = MessageBoxIcon.Question;

            // Mostrar messageBox de confirmación
            DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, icono);

            // Verificar el resultado del messageBox
            if (resultado == DialogResult.No) return;

            // Guardar la venta
            string clienteDNI = comboBox_Cliente.SelectedValue.ToString();
            DateTime fechaVenta = dateTimePicker_FechaVenta.Value;

            // Crear obj venta
            Venta nuevaVenta = new Venta(fechaVenta, clienteDNI);

            // Almacenar la venta en la base de datos
            try
            {
                int ventaNro = TrabajarVenta.insertarVenta(nuevaVenta);

                // Guardamos los detalles de la venta
                VentaDetalle nuevaVentaDetalle = new VentaDetalle();

                // Llenar el obj
                nuevaVentaDetalle.Ven_Nro = ventaNro;
                nuevaVentaDetalle.Prod_Codigo = textBox_CodigoProd.Text;
                nuevaVentaDetalle.Det_Precio = Decimal.Parse(textBox_Precio.Text);
                nuevaVentaDetalle.Det_Total = Decimal.Parse(textBox_Total.Text);
                nuevaVentaDetalle.Det_Cantidad = Decimal.Parse(textBox_Cantidad.Text);

                TrabajarVenta.insertarVentaDetalle(nuevaVentaDetalle);

                string mensajeExito = "***La venta fue guardada con exito***"
                   + "\nNro de la venta: " + ventaNro
                   + "\nFecha de Venta: " + nuevaVenta.Ven_Fecha
                   + "\nDNI del cliente: " + nuevaVenta.Cli_DNI
                   + "\n***DETALLES DE LA VENTA***"
                   + "\nCodigo del producto: " + nuevaVentaDetalle.Prod_Codigo
                   + "\nPrecio: " + nuevaVentaDetalle.Det_Precio
                   + "\nCantidad: " + nuevaVentaDetalle.Det_Cantidad
                   + "\nTotal: " + nuevaVentaDetalle.Det_Total;
                MessageBox.Show(mensajeExito, titulo);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al guardar la venta", titulo);
                MessageBox.Show(err.ToString(), titulo);
            }
        }

        // Rellenar datos del producto cuando es seleccionado
        private void dataGridView_Producto_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView_Producto.CurrentRow != null)
            {
                DataGridViewRow currentRow = dataGridView_Producto.CurrentRow;

                textBox_CodigoProd.Text = currentRow.Cells["Prod_Codigo"].Value.ToString();
                textBox_Precio.Text = currentRow.Cells["Prod_Precio"].Value.ToString();
            }
        }

        // Calcular el precio total segun la cantidad de elementos
        private void textBox_Cantidad_TextChanged(object sender, EventArgs e)
        {
            if (textBox_Cantidad.Text.Trim() != "")
            {
                int total = Int32.Parse(textBox_Precio.Text) * Int32.Parse(textBox_Cantidad.Text);
                textBox_Total.Text = total.ToString();
            }
            else
            {
                textBox_Total.Text = "";
            }
        }

        // Metodo que no permite el ingreso de letras o simbolos, solo acepta numeros
        private void textBox_Cantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
