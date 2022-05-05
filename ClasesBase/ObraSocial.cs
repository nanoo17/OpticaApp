using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class ObraSocial
    {
        private string OS_CUIT;
        private string OS_RazonSocial;
        private string OS_Telefono;
        private string OS_Direccion;

        public ObraSocial(string os_cuit, string os_razonSocial, string os_telefono, string os_direccion)
        {
            OS_CUIT1 = os_cuit;
            OS_RazonSocial1 = os_razonSocial;
            OS_Telefono1 = os_telefono;
            OS_Direccion1 = os_direccion;
        }

        public string OS_CUIT1
        {
            get { return OS_CUIT; }
            set { OS_CUIT = value; }
        }

        public string OS_RazonSocial1
        {
            get { return OS_RazonSocial; }
            set { OS_RazonSocial = value; }
        }

        public string OS_Direccion1
        {
            get { return OS_Direccion; }
            set { OS_Direccion = value; }
        }

        public string OS_Telefono1
        {
            get { return OS_Telefono; }
            set { OS_Telefono = value; }
        }
    }
}
