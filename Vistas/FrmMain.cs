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
            this.Close();
        }

        
    }
}
