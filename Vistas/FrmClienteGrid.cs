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
    public partial class FrmClienteGrid : Form
    {
        public FrmClienteGrid()
        {
            InitializeComponent();
        }

        private void FrmClienteGrid_Load(object sender, EventArgs e)
        {
            // Cargar usuario a la grilla
            cargarClientes();
            // Cargar ComboBox de obrasocial
            DataTable dt = ClasesBase.TrabajarObraSocial.obtenerObraSocial();
            comboBox_ObraSocial.DataSource = dt;
            comboBox_ObraSocial.DisplayMember = "OS_RazonSocial";
            comboBox_ObraSocial.ValueMember = "OS_CUIT";

            // Deshabilitar los botones de busqueda, modificar y eliminar si no hay registros
            DataTable dtClientes = TrabajarCliente.obtenerClientes();
            if (dtClientes.Rows.Count == 0)
            {
                button_Buscar.Enabled = false;
                button_Eliminar.Enabled = false;
                button_modificar.Enabled = false;
            }
        }

        private void cargarClientes()
        {
            dataGridView_Cliente.DataSource = TrabajarCliente.obtenerClientes();
        }

        // Boton para modificar
        private void button_modificar_Click(object sender, EventArgs e)
        {
            // Parametros del messageBox
            string mensaje = "¿Está seguro de modificar el cliente?";
            string titulo = "Modificar cliente";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            MessageBoxIcon icono = MessageBoxIcon.Question;

            // Mostrar messageBox de confirmación
            DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, icono);

            // Verificar el resultado del messageBox
            if (resultado == DialogResult.No) return;

            // Se hace la modificacion

            // Creamos el obj Cliente para modificar
            string cli_DNI = textBox_Dni.Text;
            string cli_Apellido = textBox_Apellido.Text;
            string cli_Nombre = textBox_Nombre.Text;
            string OS_CUIT = comboBox_ObraSocial.SelectedValue.ToString();
            string cli_Direccion = textBox_Direccion.Text;
            string cli_NroCarnet = textBox_Carnet.Text;

            Cliente cli = new Cliente(cli_DNI,cli_Apellido, cli_Nombre,OS_CUIT,cli_Direccion,cli_NroCarnet);

            // Guardar al cliente en la base de datos
            try
            {
                TrabajarCliente.modificarCliente(cli);
                string mensajeExito = "El cliente fue modificado con exito"
                    + "\n Nombre: " + cli.Cli_Nombre
                    + "\n Apellido: " + cli.Cli_Apellido
                    + "\n DNI: " + cli.Cli_DNI
                    + "\n Direccion: " + cli.Cli_Direccion
                    + "\n CUIT: " + cli.OS_CUIT1
                    + "\n N°Carnet: " + cli.Cli_NroCarnet;
                MessageBox.Show(mensajeExito, titulo);

                cargarClientes();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error en la modificacion del cliente", titulo);
                MessageBox.Show(err.ToString(), titulo);
            }
        }

        // Boton Eliminar Cliente
        private void button_Eliminar_Click(object sender, EventArgs e)
        {
            // Parametros del messageBox
            string mensaje = "¿Está seguro de eliminar el cliente?";
            string titulo = "Eliminar cliente";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            MessageBoxIcon icono = MessageBoxIcon.Question;

            // Mostrar messageBox de confirmación
            DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, icono);

            // Verificar el resultado del messageBox
            if (resultado == DialogResult.No) return;

            // Eliminar cliente
            string cli_DNI = textBox_Dni.Text;

            try
            {
                TrabajarCliente.eliminarCliente(cli_DNI);
                string mensajeExito = "El cliente fue eliminado con exito";
                MessageBox.Show(mensajeExito, titulo);

                // Recargar la ventana
                cargarClientes();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error en la eliminacion del cliente", titulo);
                MessageBox.Show(err.ToString(), titulo);
            }
        }

        // Busqueda con dos campos
        private void button_Buscar_Click(object sender, EventArgs e)
        {
            string dni = textBox_BuscarDni.Text.Trim();
            string apellido = textBox_BuscarApellido.Text.Trim();
         
            dataGridView_Cliente.DataSource = TrabajarCliente.buscarClientes(dni, apellido);
        }

        // Llenar el formulario cuando seleccionamos una celda
        private void dataGridView_Cliente_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView_Cliente.CurrentRow != null)
            {
                DataGridViewRow currentRow = dataGridView_Cliente.CurrentRow;

                textBox_Dni.Text = currentRow.Cells["Cli_DNI"].Value.ToString();
                textBox_Nombre.Text = currentRow.Cells["Cli_Nombre"].Value.ToString();
                textBox_Apellido.Text = currentRow.Cells["Cli_Apellido"].Value.ToString();
                textBox_Direccion.Text = currentRow.Cells["Cli_Direccion"].Value.ToString();
                comboBox_ObraSocial.SelectedValue = currentRow.Cells["OS_CUIT"].Value.ToString();
                textBox_Carnet.Text = currentRow.Cells["Cli_NroCarnet"].Value.ToString();

            }
        }
    }
}
