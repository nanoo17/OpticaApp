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
    public partial class FrmGestionClientes : Form
    {
        public FrmGestionClientes()
        {
            InitializeComponent();
        }

        private void FrmClienteGrid_Load(object sender, EventArgs e)
        {
            // Cargar clientes a la grilla
            cargarClientes();
            // Cargar ComboBox de obrasocial
            cargarComboObraSocial();
        }

        // Carga de clientes al grid
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
            

            // Deshabilitar los botones de busqueda, modificar y eliminar si no hay registros
            if (dtClientes.Rows.Count == 0)
            {
                button_Buscar.Enabled = false;
                button_Eliminar.Enabled = false;
                button_modificar.Enabled = false;
                textBox_BuscarApellido.Enabled = false;
            }
        }

        // Cargar el comboBox
        private void cargarComboObraSocial()
        {
            DataTable dt = ClasesBase.TrabajarObraSocial.obtenerObraSocial();
            comboBox_ObraSocial.DataSource = dt;
            comboBox_ObraSocial.DisplayMember = "OS_RazonSocial";
            comboBox_ObraSocial.ValueMember = "OS_CUIT";
        }

        // Boton para guardar
        private void button_modificar_Click(object sender, EventArgs e)
        {
            // Parametros del messageBox
            string mensaje = "¿Está seguro de guardar estos datos?";
            string titulo = "Guardar datos del cliente";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            MessageBoxIcon icono = MessageBoxIcon.Question;

            // Mostrar messageBox de confirmación
            DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, icono);

            // Verificar el resultado del messageBox
            if (resultado == DialogResult.No) return;

            // Creamos el obj Cliente para modificar
            string cli_DNI = textBox_Dni.Text;
            string cli_Apellido = textBox_Apellido.Text;
            string cli_Nombre = textBox_Nombre.Text;
            string OS_CUIT = comboBox_ObraSocial.SelectedValue.ToString();
            string cli_Direccion = textBox_Direccion.Text;
            string cli_NroCarnet = textBox_Carnet.Text;

            Cliente cli = new Cliente(cli_DNI,cli_Apellido, cli_Nombre,OS_CUIT,cli_Direccion,cli_NroCarnet);

            // Verificar si se esta modificando o creando un nuevo cliente
            // Si el textBox esta habilitado es porque se esta creando un cliente
            if (textBox_Dni.Enabled)
            {
                guardarCliente(cli, titulo);
                return;
            }

            // En este punto se esta modificando un cliente
            modificarCliente(cli, titulo);
        }

        // Boton para eliminar
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
            catch 
                //(Exception err)
            {
                MessageBox.Show("No se puede eliminar un cliente que tiene ventas asociadas", titulo);
                //MessageBox.Show(err.ToString(), titulo);
            }
        }

        // Busqueda con dos campos
        private void button_Buscar_Click(object sender, EventArgs e)
        {
            string busqueda = textBox_BuscarApellido.Text.Trim();
         
            dataGridView_Cliente.DataSource = TrabajarCliente.buscarClientes(busqueda);
        }

        // Llenar el formulario cuando seleccionamos una celda
        private void dataGridView_Cliente_CurrentCellChanged(object sender, EventArgs e)
        {
            llenarFormulario();
        }

        // 
        private void llenarFormulario()
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

        // Limpiar el formulario para un nuevo cliente
        private void button_NuevoCliente_Click(object sender, EventArgs e)
        {
            // Limpiar formulario
            textBox_Dni.Text = "";
            textBox_Nombre.Text = "";
            textBox_Apellido.Text = "";
            textBox_Direccion.Text = "";
            textBox_Carnet.Text = "";

            cargarComboObraSocial();
            // Cambiar el estado de controles
            cambiarEstadoDeControles(false);
            button_modificar.Enabled = true;
        }

        // Boton que cancela la carga de un nuevo cliente
        private void button_CancelarCarga_Click(object sender, EventArgs e)
        {
           cambiarEstadoDeControles(true);

            // Deshabilitar controles
            if (dataGridView_Cliente.Rows.Count == 0)
            {
                button_modificar.Enabled = false;
                button_Eliminar.Enabled = false;
                button_Buscar.Enabled = false;
                textBox_BuscarApellido.Enabled = false;
            }

            llenarFormulario();
        }

        // Se habilita o deshabilitan controles segun el parametro
        private void cambiarEstadoDeControles(bool estado)
        {
            // botones de búsqueda, eliminar, nuevo cliente y grid de clientes
            button_Buscar.Enabled = estado;
            button_Eliminar.Enabled = estado;
            button_NuevoCliente.Enabled = estado;
            dataGridView_Cliente.Enabled = estado;
            textBox_BuscarApellido.Enabled = estado;

            // Estado distinto
            textBox_Dni.Enabled = !estado;
            button_CancelarCarga.Visible = !estado;
        }

        // Metodo para guardar un cliente
        private void guardarCliente(Cliente cli, string titulo)
        {
            try
            {
                // Se busca un cliente con el DNI ingresado
                DataTable dtClienteDNI = TrabajarCliente.obtenerClientePorDNI(cli.Cli_DNI);

                // Existe un cliente con ese DNI
                if (dtClienteDNI.Rows.Count != 0) 
                {
                    MessageBox.Show("Un cliente con ese DNI ya está registrado", titulo);
                    return;
                }

                TrabajarCliente.insertarCliente(cli);
                string mensajeExito = "El cliente fue creado con exito"
                    + "\n Nombre: " + cli.Cli_Nombre
                    + "\n Apellido: " + cli.Cli_Apellido
                    + "\n DNI: " + cli.Cli_DNI
                    + "\n Direccion: " + cli.Cli_Direccion
                    + "\n CUIT: " + cli.OS_CUIT1
                    + "\n N°Carnet: " + cli.Cli_NroCarnet;
                MessageBox.Show(mensajeExito, titulo);

                cargarClientes();
                // Habilitamos los controles
                cambiarEstadoDeControles(true);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error en la creación del cliente", titulo);
                MessageBox.Show(err.ToString(), titulo);
            }
        }

        // Metodo para modificar un cliente
        private void modificarCliente(Cliente cli, string titulo)
        {
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

                // Se carga el grid nuevamente
                cargarClientes();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error en la modificacion del cliente", titulo);
                MessageBox.Show(err.ToString(), titulo);
            }
        }

        private void button_Ordenar_Click(object sender, EventArgs e)
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

        private void button_OrdenarApellido_Click(object sender, EventArgs e)
        {
            dataGridView_Cliente.Columns["Cli_Apellido"].DisplayIndex = 0;
            dataGridView_Cliente.Columns["Cli_Nombre"].DisplayIndex = 1;
            dataGridView_Cliente.Columns["Cli_DNI"].DisplayIndex = 2;
            DataTable dtClientes = TrabajarCliente.ordenarClientesApellido();
            dataGridView_Cliente.DataSource = dtClientes;
        }
    }
}
