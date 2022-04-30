using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        //datos del usuario
        private int usr_Id;
        private string usr_Nombre;
        private string usr_Password;
   
        private string usr_ApellidoNombre;

        public string Usr_ApellidoNombre
        {
            get { return usr_ApellidoNombre; }
            set { usr_ApellidoNombre = value; }
        }

        public string Usr_Password
        {
            get { return usr_Password; }
            set { usr_Password = value; }
        }

        public string Usr_Nombre
        {
            get { return usr_Nombre; }
            set { usr_Nombre = value; }
        }
        
        public int Usr_Id
        {
            get { return usr_Id; }
            set { usr_Id = value; }
        }
        //constructor
        public Usuario(string username,string password, string ApellidoNombre){
            Usr_Nombre = username;
            Usr_Password = password;
            Usr_ApellidoNombre = ApellidoNombre;
        }
    }
}
