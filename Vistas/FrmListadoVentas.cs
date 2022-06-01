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
    public partial class FrmListadoVentas : Form
    {
        public FrmListadoVentas()
        {
            InitializeComponent();
        }

        private void FrmListadoVentas_Load(object sender, EventArgs e)
        {
            // Cargar ventas
            cargarVentas();
            cargarComboClientes();
        }
        private void cargarVentas() { dataGridView_Listado.DataSource = TrabajarVenta.obtenerVentas(); }

   


        private void cargarComboClientes()
        {
            cmbCliente.DisplayMember = "Cli_Nombre";
            cmbCliente.ValueMember = "Cli_Nombre";
            cmbCliente.DataSource = TrabajarVenta.obtenerNombresVentas();
                
        }

        private void cmbCliente_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string cliente = cmbCliente.SelectedValue.ToString();
            if (cliente.Trim() == "Todos") {
                cargarVentas();
            }
            else if (cliente.Trim() != "")
            {
                dataGridView_Listado.DataSource = TrabajarVenta.obtenerVentasCliente(cliente);
            }
            else
            {
                cargarVentas();
            }
        }

        private void button_FiltrarFecha_Click(object sender, EventArgs e)
        {
            DateTime desde = dateTimePicker_Desde.Value;
            DateTime hasta = dateTimePicker_Hasta.Value;

            dataGridView_Listado.DataSource = TrabajarVenta.obtenterVentasPorFecha(desde, hasta);
        }
    }
}
