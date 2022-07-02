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
    public partial class FrmListadoClientes : Form
    {
        public FrmListadoClientes()
        {
            InitializeComponent();
        }

        private void FrmListadoClientes_Load(object sender, EventArgs e)
        {
            cargarClientes();
        }
  
        private void cargarClientes()
        {
            DataTable dtClientes = TrabajarCliente.obtenerClientes();

            dataGridView_Cliente.DataSource = dtClientes;
            //cambiar nombre de las columnas
            dataGridView_Cliente.Columns[0].HeaderText = "DNI";
            dataGridView_Cliente.Columns[1].HeaderText = "Nombre";
            dataGridView_Cliente.Columns[2].HeaderText = "Apellido";
            dataGridView_Cliente.Columns[3].HeaderText = "Direccion";
            dataGridView_Cliente.Columns[4].HeaderText = "OS CUIT";
            dataGridView_Cliente.Columns[5].HeaderText = "Nro de Carnet";

            // Deshabilitar las columnas sensibles
            dataGridView_Cliente.Columns[0].ReadOnly = true; // ID
            dataGridView_Cliente.Columns[4].ReadOnly = true; // Obra Social
        }

        private void button_OrdenarApellido_Click_1(object sender, EventArgs e)
        {
            dataGridView_Cliente.Columns["Cli_Apellido"].DisplayIndex = 0;
            dataGridView_Cliente.Columns["Cli_Nombre"].DisplayIndex = 1;
            dataGridView_Cliente.Columns["Cli_DNI"].DisplayIndex = 2;
            DataTable dtClientes = TrabajarCliente.ordenarClientesApellido();
            dataGridView_Cliente.DataSource = dtClientes;
        }

        private void button_Ordenar_Click_1(object sender, EventArgs e)
        {
            dataGridView_Cliente.Columns["Cli_DNI"].DisplayIndex = 0;
            dataGridView_Cliente.Columns["Cli_Nombre"].DisplayIndex = 1;
            dataGridView_Cliente.Columns["Cli_Apellido"].DisplayIndex = 2;
            dataGridView_Cliente.Columns["Cli_Direccion"].DisplayIndex = 3;
            dataGridView_Cliente.Columns["OS_CUIT"].DisplayIndex = 4;
            dataGridView_Cliente.Columns["Cli_NroCarnet"].DisplayIndex = 5;
            DataTable dtClientes = TrabajarCliente.obtenerClientes();
            dataGridView_Cliente.DataSource = dtClientes;
        }

        private void button_Buscar_Click(object sender, EventArgs e)
        {
            try {
                string busqueda = textBox_BuscarApellido.Text.Trim();
                dataGridView_Cliente.DataSource = TrabajarCliente.buscarClientes(busqueda);
            }
            catch {
                MessageBox.Show("Ingrese un dato para buscar","Error");
            }
          
        }

    }
}
