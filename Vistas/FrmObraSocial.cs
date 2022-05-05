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
    public partial class FrmObraSocial : Form
    {
        public FrmObraSocial()
        {
            InitializeComponent();
        }

        private void button_confirmar_Click(object sender, EventArgs e)
        {
            // Parametros del messageBox
            string mensaje = "¿Quiere guardar esta Obra Social?";
            string titulo = "Guardar Obra Social";
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
            string os_cuit = textBox_cuit.Text;
            string os_razonSocial = textBox_razonSocial.Text;
            string os_telefono = textBox_telefono.Text;
            string os_direccion = textBox_direccion.Text;
            ObraSocial obra = new ObraSocial(os_cuit,os_razonSocial,os_telefono,os_direccion);
            string mensajeExito = "La Obra Social fue creada con exito"
                + "\n CUIT: " + obra.OS_CUIT1
                + "\n Razon Social: " + obra.OS_RazonSocial1
                + "\n Telefono: " + obra.OS_Telefono1
                + "\n Direccion: " + obra.OS_Direccion1;
            MessageBox.Show(mensajeExito, titulo);
        }
    }
}
