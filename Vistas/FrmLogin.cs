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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        // Evento "click" del boton aceptar
        private void Aceptar_Click(object sender, EventArgs e)
       {
            string usuario = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();

            DataTable dtUsuarios = TrabajarUsuario.buscarUsuario(usuario, password);

            // Si no encuentra un usuario porque no existe o los datos son incorrectos
            if (dtUsuarios.Rows.Count == 0)
            { 
                MessageBox.Show("Datos de acceso incorrectos", "Acceso Incorrecto");
                return;
            }

            // El usuario fue encontrado

            // Validar el tipo de rol y condicionar los botones
            int rolCodigo = Int32.Parse(dtUsuarios.Rows[0]["Rol_Codigo"].ToString());
            string nombreUsuario = dtUsuarios.Rows[0]["Usu_NombreUsuario"].ToString();

            // Abrir Menu Principal
            MessageBox.Show("Bienvenido/a :: " + nombreUsuario, "Acceso Exitoso");
            FrmMain FrmMain = new FrmMain(rolCodigo);
            FrmMain.Show();
            this.Close();
        }

        // Evento "mouseHover"
        private void Aceptar_MouseHover(object sender, EventArgs e)
        {
            Aceptar.BackColor = Color.LightGray;
            Aceptar.Cursor = Cursors.Hand;
        }

        // Evento "mouseLeave"
        private void Aceptar_MouseLeave(object sender, EventArgs e)
        {
            Aceptar.BackColor = Color.LightGreen;
            Aceptar.Cursor = Cursors.Arrow;
        }
    }
}
