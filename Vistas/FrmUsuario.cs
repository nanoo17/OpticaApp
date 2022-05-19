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
            comboBox1.ValueMember = "Rol_Codigo";
            comboBox1.DataSource = TrabajarUsuario.list_roles();
        }

        private void button1_Guardar_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            Usuario oUsuario = new Usuario();
            oUsuario.Usu_ID = r.Next();
            oUsuario.Rol =(string)comboBox1.SelectedValue;
            oUsuario.Usu_ApellidoNombre = textBox1_ApellidoNombre.Text;
            oUsuario.Usu_NombreUsuario = textBox4_Usuario.Text;
            oUsuario.Usu_Clave = textBox5_Contraseña.Text;

            TrabajarUsuario.insertarUsuario(oUsuario);

            load_usuarios();
        }


        private void load_usuarios()
        {
            dataGridView1.DataSource = TrabajarUsuario.obtenerUsuarios();
        }

        
       

       

      
    }
}
