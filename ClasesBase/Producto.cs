using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Producto
    {
        private string prod_Codigo;
        private string prod_Categoria;
        private string prod_Descripcion;
        private decimal prod_Precio;

        public string Prod_Codigo
        {
            get { return prod_Codigo; }
            set { prod_Codigo = value; }
        }
      
        public string Prod_Categoria
        {
            get { return prod_Categoria; }
            set { prod_Categoria = value; }
        }

        public string Prod_Descripcion
        {
            get { return prod_Descripcion; }
            set { prod_Descripcion = value; }
        }
        
        public decimal Prod_Precio
        {
            get { return prod_Precio; }
            set { prod_Precio = value; }
        }

        public Producto(string prod_codigo, string prod_categoria, string prod_descripcion, decimal prod_precio)
        {
            Prod_Codigo = prod_codigo;
            Prod_Categoria = prod_categoria;
            Prod_Descripcion = prod_descripcion;
            Prod_Precio = prod_precio;
        }
    }
}
