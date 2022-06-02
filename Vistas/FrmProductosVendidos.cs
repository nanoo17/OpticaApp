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

            dataGridView_Productos.DataSource = TrabajarProducto.obtenerProductosVendidosPorCliente(dniCliente);
        }

        private void button_FiltrarFecha_Click(object sender, EventArgs e)
        {
            DateTime desde = dateTimePicker_Desde.Value;
            DateTime hasta = dateTimePicker_Hasta.Value;

            dataGridView_Productos.DataSource = TrabajarProducto.obtenterProductosPorFecha(desde, hasta);
        }
    }
}
