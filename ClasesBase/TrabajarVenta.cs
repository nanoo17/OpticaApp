using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarVenta
    {
        public static int insertarVenta(Venta venta)
        {
            SqlConnection db = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand query = new SqlCommand();
            query.CommandText = "INSERT INTO Venta (Ven_Fecha, Cli_DNI) VALUES (@fecha, @dni); SELECT SCOPE_IDENTITY()";
            query.CommandType = CommandType.Text;
            query.Connection = db;

            // Paramatros
            query.Parameters.AddWithValue("@fecha", venta.Ven_Fecha);
            query.Parameters.AddWithValue("@dni", venta.Cli_DNI);

            // Ejecutar la query
            db.Open();
            int modified = Convert.ToInt32(query.ExecuteScalar());
            //query.ExecuteNonQuery();
            db.Close();
            return modified;
        }

        public static void insertarVentaDetalle(VentaDetalle venta)
        {
            SqlConnection db = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand query = new SqlCommand();
            query.CommandText = "INSERT INTO VentaDetalle (Ven_Nro, Prod_Codigo, Det_Precio, Det_Cantidad, Det_Total) VALUES (@Vnro, @PCodigo, @precio, @cantidad, @total)";
            query.CommandType = CommandType.Text;
            query.Connection = db;

            // Paramatros
            query.Parameters.AddWithValue("@Vnro", venta.Ven_Nro);
            query.Parameters.AddWithValue("@PCodigo", venta.Prod_Codigo);
            query.Parameters.AddWithValue("@precio", venta.Det_Precio);
            query.Parameters.AddWithValue("@cantidad", venta.Det_Cantidad);
            query.Parameters.AddWithValue("@total", venta.Det_Total);

            // Ejecutar la query
            db.Open();
            query.ExecuteNonQuery();
            db.Close();
        }

        public static DataTable obtenerVentas()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT Ven_Nro, Ven_Fecha, Cliente.Cli_DNI, Cliente.Cli_Nombre FROM Venta INNER JOIN Cliente ON Cliente.Cli_DNI = Venta.Cli_DNI";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
