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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'opticaDataSet.Usuario' table. You can move, or remove it, as needed.
            //this.usuarioTableAdapter.Fill(this.opticaDataSet.Usuario);
            load_combo_roles();

            load_usuarios();
        }

        private void load_combo_roles()
        {
            comboBox1.DisplayMember = "Rol_Descripcion";
            comboBox1.ValueMember = "Rol_Descripcion";
            comboBox1.DataSource = TrabajarUsuario.list_roles();
        }

        private void button1_Guardar_Click(object sender, EventArgs e)
        {



            // Parametros del messageBox
            string mensaje = "¿Está seguro de modificar el Usuario?";
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
            string OS_CUIT = textBox_Cuit.Text;
            string cli_Direccion = textBox_Direccion.Text;
            string cli_NroCarnet = textBox_Carnet.Text;

            Cliente cli = new Cliente(cli_DNI, cli_Apellido, cli_Nombre, OS_CUIT, cli_Direccion, cli_NroCarnet);

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
                this.Refresh();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la modificacion del cliente", titulo);
            }


      






            load_usuarios();

        }


        private void load_usuarios()
        {
            dataGridView1.DataSource = TrabajarUsuario.obtenerUsuarios();
        }

        
       

       

      
    }
}
