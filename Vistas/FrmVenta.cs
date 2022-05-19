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
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            // Cargar el comboBox
            DataTable dt = ClasesBase.TrabajarCliente.obtenerClientes();
            comboBox_Cliente.DataSource = dt;
            comboBox_Cliente.DisplayMember = "Cli_Nombre";
            comboBox_Cliente.ValueMember = "cli_DNI";
        }

        private void button_Guardar_Click(object sender, EventArgs e)
        {
            // Parametros del messageBox
            string mensaje = "¿Está seguro de guardar esta venta?";
            string titulo = "Guardar Venta";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            MessageBoxIcon icono = MessageBoxIcon.Question;

            // Mostrar messageBox de confirmación
            DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, icono);

            // Verificar el resultado del messageBox
            if (resultado == DialogResult.No) return;

            // Guardar la venta
            int numeroVenta;
            string clienteDNI = comboBox_Cliente.SelectedValue.ToString();
            DateTime fechaVenta = dateTimePicker_FechaVenta.Value;

            // Verificar que el numeroVenta es un int
            try
            {
                numeroVenta = Int32.Parse(textBox_NumeroVenta.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("El numero de venta no es un valor entero", titulo);
                return;
            }

            // Crear obj venta
            Venta nuevaVenta = new Venta(numeroVenta, fechaVenta, clienteDNI);

            // Almacenar la venta en la base de datos
            try
            {
                TrabajarVenta.insertarVenta(nuevaVenta);
                string mensajeExito = "La venta fue guardada con exito"
                   + "\nNro venta: " + nuevaVenta.Ven_Nro
                   + "\nFecha de Venta: " + nuevaVenta.Ven_Fecha
                   + "\nDNI del cliente: " + nuevaVenta.Cli_DNI;
                MessageBox.Show(mensajeExito, titulo);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error al guardar la venta", titulo);
                MessageBox.Show(err.ToString(), titulo);
            }
        }
    }
}
