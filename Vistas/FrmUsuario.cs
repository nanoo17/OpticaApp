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
            load_combo_roles();

            load_usuarios();
        }

        private void load_combo_roles()
        {
            DataTable dt = TrabajarUsuario.list_roles();
            comboBox1.DisplayMember = "Rol_Descripcion";
            comboBox1.ValueMember = "Rol_Codigo";
            comboBox1.DataSource = dt;

            if (dt.Rows.Count == 0)
            {
                button1_Guardar.Enabled = false;
                button2_Eliminar.Enabled = false;
            }
        }

        private void button1_Guardar_Click(object sender, EventArgs e)
        {

            // Parametros del messageBox
            string mensaje = "¿Está seguro de modificar el Usuario?";
            string titulo = "Modificar usuario";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            MessageBoxIcon icono = MessageBoxIcon.Question;

            // Mostrar messageBox de confirmación
            DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, icono);

            // Verificar el resultado del messageBox
            if (resultado == DialogResult.No) return;

            // Se hace la modificacion

            // Creamos el obj Cliente para modificar
            string usu_ApellidoNombre = textBox1_ApellidoNombre.Text;
            string usu_NombreUsuario = textBox4_Usuario.Text;
            string usu_Contraseña = textBox5_Contraseña.Text;
            int usu_Rol = Int32.Parse(comboBox1.SelectedValue.ToString());
            int usu_id = Int32.Parse(textBox1_id.Text);

            Usuario usu = new Usuario(usu_NombreUsuario, usu_Contraseña, usu_ApellidoNombre, usu_Rol);
            usu.Usu_ID = usu_id;

            // Guardar al Usuario en la base de datos
            try
            {
                TrabajarUsuario.modificarUsuario(usu);
                string mensajeExito = "El usuario fue modificado con exito"
                     + "\n Usuario: " + usu.Usu_NombreUsuario
                     + "\n Contraseña " + usu.Usu_Clave
                     + "\n Nombre y Apellido: " + usu.Usu_ApellidoNombre
                     + "\n Rol: " + usu.Rol;
                MessageBox.Show(mensajeExito, titulo);
                load_usuarios();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error en la modificacion del cliente", titulo);
                MessageBox.Show(err.ToString(), titulo);
            }

        }

        // Cargar los usuario al grid
        private void load_usuarios()
        {
            DataTable dtUsuario = TrabajarUsuario.obtenerUsuarios();
            dataGridView_Usuario.DataSource = dtUsuario;

            // Deshabilitar las columnas sensibles
            dataGridView_Usuario.Columns[0].ReadOnly = true; // ID
            dataGridView_Usuario.Columns[4].ReadOnly = true; // Rol

            // Deshabilitar los botones de busqueda, modificar y eliminar si no hay registros
            if (dtUsuario.Rows.Count == 0)
            {
                button1_Guardar.Enabled = false;
                button2_Eliminar.Enabled = false;
                button1.Enabled = false;
            }
        }

        private void button2_Eliminar_Click(object sender, EventArgs e)
        {
            // Parametros del messageBox
            string mensaje = "¿Está seguro de eliminar el usuario?";
            string titulo = "Eliminar Usuario";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            MessageBoxIcon icono = MessageBoxIcon.Question;

            // Mostrar messageBox de confirmación
            DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, icono);

            // Verificar el resultado del messageBox
            if (resultado == DialogResult.No) return;

            // Eliminar cliente
            
            int usu_id = Int32.Parse(textBox1_id.Text);
            try
            {
                TrabajarUsuario.eliminarUsuario(usu_id);
                
                string mensajeExito = "El usuario fue eliminado con exito";
                MessageBox.Show(mensajeExito, titulo);

                // Recargar la ventana
                load_usuarios();
            }
            catch (Exception)
            {
                MessageBox.Show("Error en la eliminacion del cliente", titulo);
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usu_Usuario = textBox1_UsuarioBuscar.Text.Trim();

            if (usu_Usuario.Trim() != "")
            {
                dataGridView_Usuario.DataSource = TrabajarUsuario.buscarUsuarioTabla(usu_Usuario);
            }
            else
            {
                load_usuarios();
            }
        }

        private void dataGridView_Usuario_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataGridView_Usuario.CurrentRow != null)
            {
                DataGridViewRow currentRow = dataGridView_Usuario.CurrentRow;

                textBox1_id.Text = currentRow.Cells["Usu_ID"].Value.ToString();
                textBox4_Usuario.Text = currentRow.Cells["Usu_NombreUsuario"].Value.ToString();
                textBox5_Contraseña.Text = currentRow.Cells["Usu_Contraseña"].Value.ToString();
                textBox1_ApellidoNombre.Text = currentRow.Cells["Usu_ApellidoNombre"].Value.ToString();
                comboBox1.SelectedValue = currentRow.Cells["Rol_Codigo"].Value.ToString();
            }
        }
       
    }
}
