using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private int usu_ID;
        private string usu_NombreUsuario;
        private string usu_Clave;
        private string usu_ApellidoNombre;
        private int rol_Codigo;

        public int Usu_ID
        {
            get { return usu_ID; }
            set { usu_ID = value; }
        }

        public string Usu_NombreUsuario
        {
            get { return usu_NombreUsuario; }
            set { usu_NombreUsuario = value; }
        }

        public string Usu_Clave
        {
            get { return usu_Clave; }
            set { usu_Clave = value; }
        }

        public string Usu_ApellidoNombre
        {
            get { return usu_ApellidoNombre; }
            set { usu_ApellidoNombre = value; }
        }

        public int Rol_Codigo
        {
            get { return rol_Codigo; }
            set { rol_Codigo = value; }
        }

        public Usuario(int usu_id, string usu_nombreUsuario, string usu_clave, string usu_apellidoNombre, int rol_Codigo)
        {
            Usu_ID = usu_id;
            Usu_NombreUsuario = usu_nombreUsuario;
            Usu_Clave = usu_clave;
            Usu_ApellidoNombre = usu_apellidoNombre;
            Rol_Codigo = rol_Codigo;
        }
    }
}
