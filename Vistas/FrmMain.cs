using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmMain : Form
    {
        public FrmMain(int rol_codigo)
        {
            InitializeComponent();
            if (rol_codigo == 1)
            {
                ventasToolStripMenuItem.Visible = false;
                clientesToolStripMenuItem.Visible = false;
            }
            if (rol_codigo == 2)
            {
                usuariosToolStripMenuItem.Visible = false;
                cargarProductoToolStripMenuItem.Visible = false;
            }
           
        }

        private void registrarObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmObraSocial oFrmObraSocial = new FrmObraSocial();
            oFrmObraSocial.Show();
        }

        private void cargarProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProducto oFrmProducto = new FrmProducto();
            oFrmProducto.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Parametros del messageBox
            string mensaje = "¿Está seguro de salir del sistema?";
            string titulo = "Salir del sistema";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            MessageBoxIcon icono = MessageBoxIcon.Question;

            // Mostrar messageBox de confirmación
            DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, icono);

            // Verificar el resultado del messageBox
            if (resultado == DialogResult.No) return;

            // Cerramos el sistema
            this.Close();
        }


        private void cargarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarioCargar oFrmUsuarioCargar = new FrmUsuarioCargar();
            oFrmUsuarioCargar.Show();
        }

        private void registrarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmCliente oFrmCliente = new FrmCliente();
            oFrmCliente.Show();
        }

        private void modificarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmClienteGrid oFrmClienteGrid = new FrmClienteGrid();
            oFrmClienteGrid.Show();
        }

        private void modificarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario oFrmUsuario = new FrmUsuario();
            oFrmUsuario.Show();
        }

        private void cargarUnaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVenta oFrmVenta = new FrmVenta();
            oFrmVenta.Show();
        }

        private void verVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListadoVentas oFrmListadoVentas = new FrmListadoVentas();
            oFrmListadoVentas.Show();
           
        }

        private void verVentaDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVentaDetalle oFrmVentaDetalle = new FrmVentaDetalle();
            oFrmVentaDetalle.Show();
        }

     

        
    }
}
