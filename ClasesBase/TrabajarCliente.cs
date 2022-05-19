using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarCliente
    {
        public static void insertarCliente(Cliente cliente)
        {
            SqlConnection db = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand query = new SqlCommand();
            query.CommandText = "INSERT INTO Cliente (Cli_DNI, Cli_Nombre, Cli_Apellido, Cli_Direccion, OS_CUIT, Cli_NroCarnet) VALUES (@dni, @nombre, @apellido, @direccion, @cuit, @nroCarnet)";
            query.CommandType = CommandType.Text;
            query.Connection = db;

            // Paramatros
            query.Parameters.AddWithValue("@dni", cliente.Cli_DNI);
            query.Parameters.AddWithValue("@nombre", cliente.Cli_Nombre);
            query.Parameters.AddWithValue("@apellido", cliente.Cli_Apellido);
            query.Parameters.AddWithValue("@direccion", cliente.Cli_Direccion);
            query.Parameters.AddWithValue("@cuit", cliente.OS_CUIT1);
            query.Parameters.AddWithValue("@nroCarnet", cliente.Cli_NroCarnet);

            // Ejecutar la query
            db.Open();
            query.ExecuteNonQuery();
            db.Close();
        }
    }
}
