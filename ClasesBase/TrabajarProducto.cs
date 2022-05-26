using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarProducto
    {
        public static DataTable obtenerProductos()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_productos";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static DataTable ordenarProductosDescripcion()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_productos_descripcion";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable ordenarProductosCategoria()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_productos_categoria";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static void 
            insertarProducto(Producto producto)
        {
            SqlConnection db = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand query = new SqlCommand();
            query.CommandText = "INSERT INTO Producto (Prod_Codigo,Prod_Categoria,Prod_Descripcion,Prod_Precio) VALUES (@codigo,@categoria, @descripcion, @precio)";
            query.CommandType = CommandType.Text;
            query.Connection = db;

            // Paramatros
            query.Parameters.AddWithValue("@codigo", producto.Prod_Codigo);
            query.Parameters.AddWithValue("@categoria", producto.Prod_Categoria);
            query.Parameters.AddWithValue("@descripcion", producto.Prod_Descripcion);
            query.Parameters.AddWithValue("@precio", producto.Prod_Precio);

            // Ejecutar la query
            db.Open();
            query.ExecuteNonQuery();
            db.Close();
        }
        public static void eliminarProducto(string codigo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Producto WHERE Prod_Codigo = @codigo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Paramatros
            cmd.Parameters.AddWithValue("@codigo", codigo);

            // Ejecutar la query
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
        public static void modificarProducto(Producto producto)
        {
            SqlConnection db = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand query = new SqlCommand();
            query.CommandText = "UPDATE Producto SET Prod_Categoria=@categoria,Prod_Descripcion=@descripcion,Prod_Precio=@precio WHERE Prod_Codigo = @codigo";
            query.CommandType = CommandType.Text;
            query.Connection = db;

            // Paramatros
            query.Parameters.AddWithValue("@codigo", producto.Prod_Codigo);
            query.Parameters.AddWithValue("@categoria", producto.Prod_Categoria);
            query.Parameters.AddWithValue("@descripcion", producto.Prod_Descripcion);
            query.Parameters.AddWithValue("@precio", producto.Prod_Precio);

            // Ejecutar la query
            db.Open();
            query.ExecuteNonQuery();
            db.Close();
        }
    }
}
