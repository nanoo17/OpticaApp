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
            Roles rol1 = new Roles(1,"Administrador");
            Roles rol2 = new Roles(2, "Operador");
            Roles rol3 = new Roles(3, "Auditor");

            Boolean bUserFound = false;
            // Creacion de usuarios
            Usuario oUser1 = new Usuario(1, "nano", "123", "Mariano Rodriguez", rol1.Rol_Descripcion);
            Usuario oUser2 = new Usuario(2, "juan", "456", "Juan Perez", rol2.Rol_Descripcion);
            Usuario oUser3 = new Usuario(3, "mauro", "123", "Mauro Mamani",rol3.Rol_Descripcion);

            FrmMain oFrmMain = new FrmMain();

            // Buscar si existe un usuario con los datos del formulario login
            if(oUser1.Usu_NombreUsuario == txtUserName.Text && oUser1.Usu_Clave == txtPassword.Text)
            {
                bUserFound = true;
            }
            else if (oUser2.Usu_NombreUsuario == txtUserName.Text && oUser2.Usu_Clave == txtPassword.Text)
            {
                bUserFound = true;
            }
            else if (oUser3.Usu_NombreUsuario == txtUserName.Text && oUser3.Usu_Clave == txtPassword.Text)
            {
            bUserFound = true;
            }

            // Verificar si el usuario fue encontrado
            if(bUserFound)
            {
                MessageBox.Show("Bienvenido/a :: " + txtUserName.Text);
                oFrmMain.Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos de acceso incorrectos");
            }
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
            Aceptar.BackColor = SystemColors.ControlLightLight;
            Aceptar.Cursor = Cursors.Arrow;
        }
    }
}
