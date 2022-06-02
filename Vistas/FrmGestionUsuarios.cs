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
    public partial class FrmGestionUsuarios : Form
    {
        public FrmGestionUsuarios()
        {
            InitializeComponent();
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            load_combo_roles();
            load_usuarios();
        }

        // Cargar los roles
        private void load_combo_roles()
        {
            DataTable dt = TrabajarUsuario.list_roles();
            comboBox1.DisplayMember = "Rol_Descripcion";
            comboBox1.ValueMember = "Rol_Codigo";
            comboBox1.DataSource = dt;

            // Si no hay roles cargados deshabilitar botones
            if (dt.Rows.Count == 0)
            {
                button1_Guardar.Enabled = false;
                button2_Eliminar.Enabled = false;
            }
        }

        // Boton para guardar datos
        private void button1_Guardar_Click(object sender, EventArgs e)
        {
            // Parametros del messageBox
            string mensaje = "¿Está seguro de guardar estos datos?";
            string titulo = "Guardar datos del usuario";
            MessageBoxButtons botones = MessageBoxButtons.YesNo;
            MessageBoxIcon icono = MessageBoxIcon.Question;

            // Mostrar messageBox de confirmación
            DialogResult resultado = MessageBox.Show(mensaje, titulo, botones, icono);

            // Verificar el resultado del messageBox
            if (resultado == DialogResult.No) return;

            // Creamos el obj Cliente para modificar
            string usu_ApellidoNombre = textBox1_ApellidoNombre.Text;
            string usu_NombreUsuario = textBox4_Usuario.Text;
            string usu_Contraseña = textBox5_Contraseña.Text;
            int usu_Rol = Int32.Parse(comboBox1.SelectedValue.ToString());
            int usu_id = Int32.Parse(textBox1_id.Text);

            Usuario usu = new Usuario(usu_NombreUsuario, usu_Contraseña, usu_ApellidoNombre, usu_Rol);

            // Verificamos si se está creando un usuario o modificando
            // Si el ID = 0 se esta creando un usuario
            if (usu_id == 0)
            {
                guardarUsuario(usu, titulo);
                return;
            }

            // Se esta modificando un usuario
            usu.Usu_ID = usu_id;

            modificarUsuario(usu, titulo);
        }

        // Cargar los usuario al grid
        private void load_usuarios()
        {
            DataTable dtUsuario = TrabajarUsuario.obtenerUsuarios();
            dataGridView_Usuario.DataSource = dtUsuario;
            dataGridView_Usuario.Columns[0].HeaderText = "ID";
            dataGridView_Usuario.Columns[1].HeaderText = "Nombre de usuario";
            dataGridView_Usuario.Columns[2].HeaderText = "Contraseña";
            dataGridView_Usuario.Columns[3].HeaderText = "Apellido y Nombre";
            dataGridView_Usuario.Columns[4].Visible = false;
            dataGridView_Usuario.Columns[5].HeaderText = "Rol";
            // Deshabilitar las columnas sensibles
            dataGridView_Usuario.Columns[0].ReadOnly = true; // ID
            dataGridView_Usuario.Columns[4].ReadOnly = true; // Rol

            // Deshabilitar los botones de busqueda, modificar y eliminar si no hay registros
            if (dtUsuario.Rows.Count == 0)
            {
                button1_Guardar.Enabled = false;
                button2_Eliminar.Enabled = false;
                button1.Enabled = false;
                textBox1_UsuarioBuscar.Enabled = false;
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
            catch (Exception err)
            {
                MessageBox.Show("Error en la eliminacion del cliente", titulo);
                MessageBox.Show(err.ToString(), titulo);
            }
        
        }

        // Buscar usuarios por nombre de usuario
        private void button1_Click(object sender, EventArgs e)
        {
            string usu_Usuario = textBox1_UsuarioBuscar.Text.Trim();

            if (usu_Usuario.Trim() != "")
            {
                dataGridView_Usuario.DataSource = TrabajarUsuario.buscarUsuarioTabla(usu_Usuario);
                dataGridView_Usuario.Columns[0].HeaderText = "ID";
                dataGridView_Usuario.Columns[1].HeaderText = "Nombre de usuario";
                dataGridView_Usuario.Columns[2].HeaderText = "Contraseña";
                dataGridView_Usuario.Columns[3].HeaderText = "Apellido y Nombre";
                dataGridView_Usuario.Columns[4].Visible = false;
                dataGridView_Usuario.Columns[5].HeaderText = "Rol";
            }
            else
            {
                load_usuarios();
            }
        }

        // Evento de cambio de celda
        private void dataGridView_Usuario_CurrentCellChanged(object sender, EventArgs e)
        {
           llenarFormulario();     
        }

        // Llenar formulario segun celda
        private void llenarFormulario()
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

        private void button_NuevoUsuario_Click(object sender, EventArgs e)
        {
            // Limpiar el formulario
            textBox1_id.Text = "0";
            textBox4_Usuario.Text = "";
            textBox5_Contraseña.Text = "";
            textBox1_ApellidoNombre.Text = "";

            load_combo_roles();

            // Cambiar estado de controles
            cambiarEstadoDeControles(false);
            button1_Guardar.Enabled = true;
        }

        // Se habilita o deshabilitan controles segun el parametro
        private void cambiarEstadoDeControles(bool estado)
        {
            // Controles
            button1.Enabled = estado;
            button2_Eliminar.Enabled = estado;
            button_NuevoUsuario.Enabled = estado;
            textBox1_UsuarioBuscar.Enabled = estado;
            dataGridView_Usuario.Enabled = estado;

            // Otro estado
            button_CancelarCarga.Visible = !estado;
        }

        // Cancelar la carga de usuario
        private void button_CancelarCarga_Click(object sender, EventArgs e)
        {
            cambiarEstadoDeControles(true);

            // Deshabilitar controles
            if (dataGridView_Usuario.Rows.Count == 0)
            {
                button1_Guardar.Enabled = false;
                button2_Eliminar.Enabled = false;
                button1.Enabled = false;
                textBox1_UsuarioBuscar.Enabled = false;
            }

            llenarFormulario();
        }

        // Guardar al usuario en la base de datos
        private void guardarUsuario(Usuario usu, string titulo)
        {
            try
            {
                // Validar que el nombre de usuario sea unico
                DataTable dtNombreUsuario = TrabajarUsuario.obtenerUsuarioPorNombreUsuario(usu.Usu_NombreUsuario);

                // Existe un usuario con ese nombreUsuario
                if (dtNombreUsuario.Rows.Count != 0)
                {
                    MessageBox.Show("Ese nombre de usuario ya está registrado", titulo);
                    return;
                }

                TrabajarUsuario.insertarUsuario(usu);
                string mensajeExito = "El usuario fue creado con exito"
                     + "\nUsuario: " + usu.Usu_NombreUsuario
                     + "\nContraseña " + usu.Usu_Clave
                     + "\nNombre y Apellido: " + usu.Usu_ApellidoNombre
                     + "\nRol: " + usu.Rol;
                MessageBox.Show(mensajeExito, titulo);

                load_usuarios();
                // Habilitar los controles
                cambiarEstadoDeControles(true);
            }
            catch (Exception err)
            {
                MessageBox.Show("Error en la creacion del usuario", titulo);
                MessageBox.Show(err.ToString(), titulo);
            }
        }

        // Modificar al usuario
        private void modificarUsuario(Usuario usu, string titulo)
        {
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

    }
}
