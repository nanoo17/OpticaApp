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
            query.CommandText = "insertar_producto";
            query.CommandType = CommandType.StoredProcedure;
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
            cmd.CommandText = "eliminar_producto";
            cmd.CommandType = CommandType.StoredProcedure;
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
            query.CommandText = "modificar_producto";
            query.CommandType = CommandType.StoredProcedure;
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
        public static DataTable buscarProductoPorCodigo(string codigo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "buscar_producto";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@codigo", codigo);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable obtenerProductosVendidosPorCliente(string dni)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_productos_por_cliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dni);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable obtenterProductosPorFecha(DateTime desde, DateTime hasta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listar_productos_fecha";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@desde", desde);
            cmd.Parameters.AddWithValue("@hasta", hasta);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
