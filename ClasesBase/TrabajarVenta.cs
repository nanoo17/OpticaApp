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
        public static void insertarVenta(Venta venta)
        {
            SqlConnection db = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand query = new SqlCommand();
            query.CommandText = "INSERT INTO Venta (Ven_Nro, Ven_Fecha, Cli_DNI) VALUES (@nro, @fecha, @dni)";
            query.CommandType = CommandType.Text;
            query.Connection = db;

            // Paramatros
            query.Parameters.AddWithValue("@nro", venta.Ven_Nro);
            query.Parameters.AddWithValue("@fecha", venta.Ven_Fecha);
            query.Parameters.AddWithValue("@dni", venta.Cli_DNI);

            // Ejecutar la query
            db.Open();
            query.ExecuteNonQuery();
            db.Close();
        }
    }
}
