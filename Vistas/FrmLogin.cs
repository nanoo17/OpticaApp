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
            Boolean bUserFound = false;
            // Creacion de usuarios
            Usuario oUser1 = new Usuario(1, "nano", "123", "Mariano Rodriguez", 1);
            Usuario oUser2 = new Usuario(2, "juan", "456", "Juan Perez", 2);

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

            // Verificar si el usuario fue encontrado
            if(bUserFound)
            {
                MessageBox.Show("Bienvenido/a :: " + txtUserName.Text);
                oFrmMain.Show();
                this.Hide();
                // this.FormClosing(); // TODO: genera un error, buscar que es
            }
            else
            {
                MessageBox.Show("Datos de acceso incorrectos");
            }
        }

      

       
    }
}
