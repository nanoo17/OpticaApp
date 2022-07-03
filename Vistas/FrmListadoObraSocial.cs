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
    public partial class FrmListadoObraSocial : Form
    {
        public FrmListadoObraSocial()
        {
            InitializeComponent();
        }

        private void FrmListadoObraSocial_Load(object sender, EventArgs e)
        {
            cargarTabla();
            cargarCombo();
        }
        private void cargarTabla() {
            DataTable tabla = TrabajarObraSocial.obtenerClientesObraSocial();
            dataGridView1.DataSource = tabla;
            dataGridView1.Columns[0].HeaderText = "CUIT";
            dataGridView1.Columns[1].HeaderText = "Razon Social";
            dataGridView1.Columns[2].HeaderText = "Nro de Carnet";
            dataGridView1.Columns[3].HeaderText = "Nombre";
            dataGridView1.Columns[4].HeaderText = "Apellido";
            dataGridView1.Columns[5].HeaderText = "DNI";
            lbl_Clientes.Text = tabla.Rows.Count.ToString() ;
        }
        private void cargarCombo() {
            DataTable dt = ClasesBase.TrabajarObraSocial.obtenerObraSocialDetalle();
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "detalle";
            comboBox1.ValueMember = "OS_CUIT";
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string cuit = comboBox1.SelectedValue.ToString();
            if(cuit.Trim() == "Todas"){
                cargarTabla();
            }
        else if(cuit.Trim() != ""){
    DataTable dt = TrabajarObraSocial.obtenerObraSocialEspecifica(cuit);
    dataGridView1.DataSource = dt;
    lbl_Clientes.Text = dataGridView1.Rows.Count.ToString();
    }
            else{
            cargarTabla();
        }
        }
    }
}
