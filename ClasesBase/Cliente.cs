using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cliente
    {
        private string cli_DNI;
        private string cli_Apellido;
        private string cli_Nombre;
        private string OS_CUIT;
        private string cli_Direccion;
        private string cli_NroCarnet;


        public Cliente(string cli_Dni, string cli_apellido, string cli_nombre, string os_CUIT, string cli_direccion,string cli_nroCarnet)
        {
            Cli_DNI = cli_Dni;
            Cli_Apellido = cli_apellido;
            Cli_Nombre = cli_nombre;
            OS_CUIT = os_CUIT;
            Cli_Direccion = cli_direccion;
            Cli_NroCarnet = cli_nroCarnet;
        }

        public string Cli_NroCarnet
        {
            get { return cli_NroCarnet; }
            set { cli_NroCarnet = value; }
        }

        public string Cli_Direccion
        {
            get { return cli_Direccion; }
            set { cli_Direccion = value; }
        }

        public string OS_CUIT1
        {
            get { return OS_CUIT; }
            set { OS_CUIT = value; }
        }

        public string Cli_DNI
        {
            get { return cli_DNI; }
            set { cli_DNI = value; }
        }

        public string Cli_Apellido
        {
            get { return cli_Apellido; }
            set { cli_Apellido = value; }
        }

        public string Cli_Nombre
        {
            get { return cli_Nombre; }
            set { cli_Nombre = value; }
        }
    }
}
