﻿using System;
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
                productosToolStripMenuItem.Visible = false;
            }
           
        }

        private void registrarObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmObraSocial oFrmObraSocial = new FrmObraSocial();
            oFrmObraSocial.Show();
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

        private void modificarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionClientes oFrmClienteGrid = new FrmGestionClientes();
            oFrmClienteGrid.Show();
        }

        private void modificarUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmGestionUsuarios oFrmUsuario = new FrmGestionUsuarios();
            oFrmUsuario.Show();
        }

        private void cargarUnaVentaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCargarVenta oFrmVenta = new FrmCargarVenta();
            oFrmVenta.Show();
        }

        private void verVentasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form oFrmListado = new FrmListadoVentas();
            oFrmListado.Show();
        }

        private void gestionarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form oFrmListadoProductos = new FrmListadoProductos();
            oFrmListadoProductos.Show();
        }

        private void productosVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FrmProductosVendidos = new FrmProductosVendidos();
            FrmProductosVendidos.Show();
        }

        private void listadoClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form FrmListadoClientes = new FrmListadoClientes();
            FrmListadoClientes.Show();
        }

        private void verObrasSocialesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmObraSocial = new FrmListadoObraSocial();
            frmObraSocial.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form frmLogin = new FrmLogin();
            frmLogin.Show();
            this.Close();
        }
        
    }
}
