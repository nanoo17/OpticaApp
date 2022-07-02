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
        private void cargarVentas() {
            DataTable dt = TrabajarVenta.obtenerVentas();
            dataGridView_Listado.DataSource = dt;
            dataGridView_Listado.Columns[0].HeaderText = "Número de Venta";
            dataGridView_Listado.Columns[1].HeaderText = "Nombre del Cliente";
            dataGridView_Listado.Columns[2].HeaderText = "Apellido del Cliente";
            dataGridView_Listado.Columns[3].HeaderText = "Fecha de la Venta";
            label_CantidadVentas.Text = "Cantidad total de ventas: " + dt.Rows.Count + " Ventas";

        }

   


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
                DataTable dt = TrabajarVenta.obtenerVentasCliente(cliente);
                dataGridView_Listado.DataSource = dt;
                label_CantidadVentas.Text = "Cantidad de ventas realizadas por este cliente: " + dt.Rows.Count + " Ventas";
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

            DataTable dt = TrabajarVenta.obtenterVentasPorFecha(desde, hasta);

            dataGridView_Listado.DataSource = dt;

            label_CantidadVentas.Text = "Cantidad de ventas realizadas en este rango de fechas es: " + dt.Rows.Count + " Ventas";
        }

        private void dataGridView_Listado_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView_Listado.CurrentRow != null) {
                DataGridViewRow currentRow = dataGridView_Listado.CurrentRow;
                lbl_kcyo.Text = currentRow.Cells["Ven_Nro"].Value.ToString();
            }
            
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (lbl_kcyo.Text != null)
            {
                // Parametros del messageBox
                string mensaje = "¿Está seguro de eliminar la venta?";
                string titulo = "Eliminar Venta";
                MessageBoxButtons botones = MessageBoxButtons.YesNo;
                MessageBoxIcon icono = MessageBoxIcon.Question;

                // Mostrar messageBox de confirmación
                DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, icono);

                // Verificar el resultado del messageBox
                if (resultado == DialogResult.No) return;
                int nro = Convert.ToInt32(lbl_kcyo.Text);
                try
                {
                    TrabajarVenta.eliminarVenta(nro);
                    string mensajeExito = "La venta fue eliminada con exito";
                    MessageBox.Show(mensajeExito, titulo);

                    // Recargar la ventana
                    cargarVentas();
                }
                catch
                //(Exception err)
                {
                    MessageBox.Show("No se puede eliminar la venta", titulo);
                    //MessageBox.Show(err.ToString(), titulo);
                }
            }
        }
    }
}
