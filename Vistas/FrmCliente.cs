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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void button1_Confirmar_Click(object sender, EventArgs e)
        {
            // Parametros del messageBox
            string mensaje = "¿Quiere guardar este Ciente?";
            string titulo = "Guardar Cliente";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            MessageBoxIcon icono = MessageBoxIcon.Question;

            // Mostrar messageBox de confirmación
            DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, icono);

            // Verificar el resultado del messageBox
            if (resultado == DialogResult.No)
            {
                MessageBox.Show("La operación fue cancelada", titulo);
                return;
            }
            string cli_DNI = textBox_dni.Text;
            string cli_Apellido = textBox_apellido.Text;
            string cli_Nombre = textBox_nombre.Text;
            string OS_CUIT = textBox_cuit.Text;
            string cli_Direccion = textBox_direccion.Text;
            string cli_NroCarnet = textBox_nroCarnet.Text;
            Cliente cli = new Cliente(cli_DNI,cli_Apellido, cli_Nombre,OS_CUIT,cli_Direccion,cli_NroCarnet);

            // Guardar al cliente en la base de datos
            try
            {
                TrabajarUsuario.insertarCliente(cli);
                string mensajeExito = "El cliente fue creado con exito"
                    + "\n Nombre: " + cli.Cli_Nombre
                    + "\n Apellido: " + cli.Cli_Apellido
                    + "\n DNI: " + cli.Cli_DNI
                    + "\n Direccion: " + cli.Cli_Direccion
                    + "\n CUIT: " + cli.OS_CUIT1
                    + "\n N°Carnet: " + cli.Cli_NroCarnet;
                MessageBox.Show(mensajeExito, titulo);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error en la creacion del cliente", titulo);
            }

        }
    }
}
