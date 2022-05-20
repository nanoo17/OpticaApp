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
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            
        }

        private void sistemaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente oFrmCliente = new FrmCliente();
            oFrmCliente.Show();
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

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuario oFrmUsuario = new FrmUsuario();
            oFrmUsuario.Show();
        }

        
    }
}
