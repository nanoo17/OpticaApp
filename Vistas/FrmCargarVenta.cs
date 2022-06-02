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
            dataGridView_Producto.Columns[0].HeaderText = "Codigo";
            dataGridView_Producto.Columns[1].HeaderText = "Categoria";
            dataGridView_Producto.Columns[2].HeaderText = "Descripcion";
            dataGridView_Producto.Columns[3].HeaderText = "Precio";

            // Deshabilitar botones si no hay productos
            if (dtProductos.Rows.Count == 0)
            {
                button_Guardar.Enabled = false;
            }
        }

        // Cargar los detalles al grid de detalles
        private void cargarDetallesGrid()
        {
            dataGridView_DetallesVenta.DataSource = null;
            dataGridView_DetallesVenta.DataSource = detallesCargados;

            if (detallesCargados.Count == 0) 
            {
                button_EliminarDetalle.Enabled = false;
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

            // Verificar que los detalles no esten vacios
            if (detallesCargados.Count == 0)
            {
                MessageBox.Show("Al menos un detalle debe estar cargado", titulo);
                return;
            }

            // Crear obj venta
            Venta nuevaVenta = new Venta(fechaVenta, clienteDNI);

            // Almacenar la venta en la base de datos
            try
            {
                int ventaNro = TrabajarVenta.insertarVenta(nuevaVenta);

                // Loop de los detalles de las ventas
                foreach (VentaDetalleGrid v in detallesCargados)
                {

                    // Guardamos los detalles de la venta
                    VentaDetalle nuevaVentaDetalle = new VentaDetalle();

                    // Llenar el obj
                    nuevaVentaDetalle.Ven_Nro = ventaNro;
                    nuevaVentaDetalle.Prod_Codigo = v.Prod_Codigo;
                    nuevaVentaDetalle.Det_Precio = v.Det_Precio;
                    nuevaVentaDetalle.Det_Total = v.Det_Total;
                    nuevaVentaDetalle.Det_Cantidad = v.Det_Cantidad;

                    TrabajarVenta.insertarVentaDetalle(nuevaVentaDetalle);
                }

                string mensajeExito = "***La venta fue guardada con exito***"
                   + "\nNro de la venta: " + ventaNro
                   + "\nFecha de Venta: " + nuevaVenta.Ven_Fecha
                   + "\nDNI del cliente: " + nuevaVenta.Cli_DNI;
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

                textBox_IdDetalle.Text = "0";
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

        List<VentaDetalleGrid> detallesCargados = new List<VentaDetalleGrid>();
        // Agregar el detalle al grid
        private void button_AgregarDetalle_Click(object sender, EventArgs e)
        {
            VentaDetalleGrid nuevaVentaDetalle = new VentaDetalleGrid();

            // Si el producto ya esta agregado solo hay que sumarle la cantidad
            foreach (VentaDetalleGrid v in detallesCargados)
            {
                if (v.Prod_Codigo == textBox_CodigoProd.Text)
                {
                    v.Det_Cantidad = Decimal.Parse(textBox_Cantidad.Text);
                    VentaDetalleGrid vAux = new VentaDetalleGrid();

                    vAux.Det_Cantidad = v.Det_Cantidad;
                    vAux.Det_Precio = v.Det_Precio;
                    vAux.Det_Total = v.Det_Total;
                    vAux.Id = v.Id;
                    vAux.Prod_Codigo = v.Prod_Codigo;

                    detallesCargados.Add(vAux);

                    detallesCargados.Remove(v);
                    cargarDetallesGrid();
                    return;
                }
            }

            // Si el id es 0 guardamos un detalle
            if (textBox_IdDetalle.Text == "0")
            {
                Random rnd = new Random();
                // Llenar el obj
                nuevaVentaDetalle.Id = rnd.Next();
                nuevaVentaDetalle.Prod_Codigo = textBox_CodigoProd.Text;
                nuevaVentaDetalle.Det_Precio = Decimal.Parse(textBox_Precio.Text);
                nuevaVentaDetalle.Det_Total = Decimal.Parse(textBox_Total.Text);
                nuevaVentaDetalle.Det_Cantidad = Decimal.Parse(textBox_Cantidad.Text);

                // Agregar al array
                detallesCargados.Add(nuevaVentaDetalle);

                // Recargar el grid
                cargarDetallesGrid();
                return;
            }
        }

        // Cargar el formulario con el elemento seleccionado
        private void dataGridView_DetallesVenta_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView_DetallesVenta.CurrentRow != null)
            {
                DataGridViewRow currentRow = dataGridView_DetallesVenta.CurrentRow;

                textBox_IdDetalle.Text = currentRow.Cells["Id"].Value.ToString();
                textBox_Cantidad.Text = currentRow.Cells["Det_Cantidad"].Value.ToString();
            }
        }

        // Quitar un elemento del grid detalles
        private void removerDetalle()
        {
            foreach (VentaDetalleGrid v in detallesCargados)
            {
                if (v.Id.ToString() == textBox_IdDetalle.Text)
                {
                    detallesCargados.Remove(v);
                    return;
                }
            }
        }

        // Evento para eliminar un detalle
        private void button_EliminarDetalle_Click(object sender, EventArgs e)
        {
            removerDetalle();
            cargarDetallesGrid();
            textBox_IdDetalle.Text = "";
        }

    }
}
