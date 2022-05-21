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
    public partial class FrmUsuarioCargar : Form
    {
        public FrmUsuarioCargar()
        {
            InitializeComponent();
        }

        private void button1_guardar_Click(object sender, EventArgs e)
        {
            Usuario oUsuario = new Usuario();

            oUsuario.Rol = Int32.Parse(comboBox1.SelectedValue.ToString());
            oUsuario.Usu_ApellidoNombre = textBox1_ApellidoNombre.Text;
            oUsuario.Usu_NombreUsuario = textBox2_Usuario.Text;
            oUsuario.Usu_Clave = textBox3_Contraseña.Text;


            // Parametros del messageBox
            string mensaje = "¿Quiere guardar este Usuario?";
            string titulo = "Guardar Usuario";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            MessageBoxIcon icono = MessageBoxIcon.Question;

            // Mostrar messageBox de confirmación
            DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, icono);

            // Verificar el resultado del messageBox
            if (resultado == DialogResult.No) return;

            try
            {
                TrabajarUsuario.insertarUsuario(oUsuario);
                string mensajeExito = "El usuario fue creado con exito"
                    + "\n Apellido y Nombre: " + oUsuario.Usu_ApellidoNombre
                    + "\n Nombre de Usuario: " + oUsuario.Usu_NombreUsuario;
                MessageBox.Show(mensajeExito, titulo);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error en la carga de usuario", titulo);
                MessageBox.Show(err.ToString(), titulo);
            }
        }

        private void FrmUsuarioCargar_Load(object sender, EventArgs e)
        {
            load_combo_roles();
        }

        private void load_combo_roles()
        {
            comboBox1.DisplayMember = "Rol_Descripcion";
            comboBox1.ValueMember = "Rol_Codigo";
            comboBox1.DataSource = TrabajarUsuario.list_roles();
        }
    }
}
