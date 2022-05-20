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
    public partial class FrmVentaDetalle : Form
    {
        public FrmVentaDetalle()
        {
            InitializeComponent();
        }

        private void FrmVentaDetalle_Load(object sender, EventArgs e)
        {
            // Cargar ComboBox de producto y venta
            DataTable dt = ClasesBase.TrabajarVenta.obtenerVentas();
            comboBox_NumeroVenta.DataSource = dt;
            comboBox_NumeroVenta.DisplayMember = "Ven_Nro";
            comboBox_NumeroVenta.ValueMember = "Ven_Nro";

            DataTable dtProductos = ClasesBase.TrabajarProducto.obtenerProductos();
            dataGridView_Producto.DataSource = dtProductos;

            // Deshabilitar botones si no hay ventas o productos
            if (dt.Rows.Count == 0 || dtProductos.Rows.Count == 0)
            {
                comboBox_NumeroVenta.Enabled = false;
                button_Guardar.Enabled = false;
            }

            // MessageBox.Show(dtProductos.Rows[0]["Prod_Categoria"].ToString());
        }

        // Rellenar el precio del producto
        private void dataGridView_Producto_SelectionChanged(object sender, EventArgs e)
        {
            var row = (sender as DataGridView).CurrentRow;

            textBox_CodigoProd.Text = row.Cells[0].Value.ToString();
            textBox_Precio.Text = row.Cells[3].Value.ToString();
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

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            // Parametros del messageBox
            string mensaje = "¿Está seguro de guardar estos detalles de la venta?";
            string titulo = "Guardar Detalles Venta";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            MessageBoxIcon icono = MessageBoxIcon.Question;

            // Mostrar messageBox de confirmación
            DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, icono);

            // Verificar el resultado del messageBox
            if (resultado == DialogResult.No) return;

            // Crear obj ventaDetalle
            VentaDetalle nuevaVentaDetalle = new VentaDetalle();

            // Campos
            int numeroDetalle;
            int numeroVenta;
            string prodCodigo = textBox_CodigoProd.Text;
            decimal precio = Decimal.Parse(textBox_Precio.Text);
            decimal cantidad = Decimal.Parse(textBox_Cantidad.Text);
            decimal total = Decimal.Parse(textBox_Total.Text);

            // Verificar que los campos sean int o decimal
            try
            {
                numeroDetalle = Int32.Parse(textBox_DetalleNumero.Text);
                numeroVenta = Int32.Parse(comboBox_NumeroVenta.SelectedValue.ToString());
            }
            catch (Exception)
            {
                MessageBox.Show("Los valores deben ser decimales", titulo);
                return;
            }

            // Llenar el obj
            nuevaVentaDetalle.Det_Nro = numeroDetalle;
            nuevaVentaDetalle.Ven_Nro = numeroVenta;
            nuevaVentaDetalle.Prod_Codigo = prodCodigo;
            nuevaVentaDetalle.Det_Precio = precio;
            nuevaVentaDetalle.Det_Total = total;
            nuevaVentaDetalle.Det_Cantidad = cantidad;

            // Almacenar la venta en la base de datos
            try
            {
                TrabajarVenta.insertarVentaDetalle(nuevaVentaDetalle);
                string mensajeExito = "Los detalles de la venta fueron guardados con exito"
                 + "\nNro Detalle de Venta: " + nuevaVentaDetalle.Det_Nro
                 + "\nNro Venta: " + nuevaVentaDetalle.Ven_Nro
                 + "\nNro Producto: " + nuevaVentaDetalle.Prod_Codigo
                 + "\nPrecio: " + nuevaVentaDetalle.Det_Precio
                 + "\nCantidad: " + nuevaVentaDetalle.Det_Cantidad
                 + "\nPrecio Final: " + nuevaVentaDetalle.Det_Total;
                MessageBox.Show(mensajeExito, titulo);
        
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al guardar la venta", titulo);
                MessageBox.Show(err.ToString(), titulo);
            }
        }

     
    

    }
}
