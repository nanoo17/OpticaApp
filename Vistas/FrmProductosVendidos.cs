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
    public partial class FrmProductosVendidos : Form
    {
        public FrmProductosVendidos()
        {
            InitializeComponent();
        }

        private void FrmProductosVendidos_Load(object sender, EventArgs e)
        {
            cargarComboClientes();
        }

        private void cargarComboClientes()
        {
            comboBox_Clientes.DisplayMember = "Cli_Nombre";
            comboBox_Clientes.ValueMember = "Cli_DNI";
            comboBox_Clientes.DataSource = TrabajarCliente.obtenerClientes();
        }

        private void comboBox_Clientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string dniCliente = comboBox_Clientes.SelectedValue.ToString();

            DataTable dt = TrabajarProducto.obtenerProductosVendidosPorCliente(dniCliente);

            dataGridView_Productos.DataSource = dt;
            dataGridView_Productos.Columns[0].HeaderText = "Dni Cliente";
            dataGridView_Productos.Columns[1].HeaderText = "Nombre Cliente";
            dataGridView_Productos.Columns[2].HeaderText = "Apellido Cliente";
            dataGridView_Productos.Columns[3].HeaderText = "Categoria Producto";
            dataGridView_Productos.Columns[4].HeaderText = "Descripcion Producto";
            dataGridView_Productos.Columns[5].HeaderText = "Fecha de Venta";

            label_ProductosVendidos.Text = "Cantidad de productos vendidos por este cliente: " + dt.Rows.Count + " Productos";
        }

        private void button_FiltrarFecha_Click(object sender, EventArgs e)
        {
            DateTime desde = dateTimePicker_Desde.Value;
            DateTime hasta = dateTimePicker_Hasta.Value;

            DataTable dt = TrabajarProducto.obtenterProductosPorFecha(desde, hasta);

            dataGridView_Productos.DataSource = dt;
            dataGridView_Productos.Columns[0].HeaderText = "Dni Cliente";
            dataGridView_Productos.Columns[1].HeaderText = "Nombre Cliente";
            dataGridView_Productos.Columns[2].HeaderText = "Apellido Cliente";
            dataGridView_Productos.Columns[3].HeaderText = "Categoria Producto";
            dataGridView_Productos.Columns[4].HeaderText = "Descripcion Producto";
            dataGridView_Productos.Columns[5].HeaderText = "Fecha de Venta";

            label_ProductosVendidos.Text = "Cantidad de productos vendidos en este rango de fechas: " + dt.Rows.Count + " Productos";
        }
    }
}
