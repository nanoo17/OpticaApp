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

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //funcion del boton aceptar
        private void Aceptar_Click(object sender, EventArgs e)
       {
            Boolean bUserFound = false;
            //creando usuarios para validar
            Usuario oUser1 = new Usuario("nano", "123", "Mariano Rodriguez");
            Usuario oUser2 = new Usuario("juan", "456", "Juan Perez");

            FrmMain oFrmMain = new FrmMain();
            if(oUser1.Usr_Nombre == txtUserName.Text && oUser1.Usr_Password == txtPassword.Text)
            {
                bUserFound = true;
            }
            else if (oUser2.Usr_Nombre == txtUserName.Text && oUser2.Usr_Password == txtPassword.Text)
            {
                bUserFound = true;
            }
            if(bUserFound)
            {
                MessageBox.Show("Bienvenido/a :: " + txtUserName.Text);
                oFrmMain.Show();
                this.FormClosing();
            }
            else
            {
                MessageBox.Show("Datos de acceso incorrectos");
            }
        }

      

       
    }
}
