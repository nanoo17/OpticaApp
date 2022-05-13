using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarUsuario
    {
        public static void insertarCliente(Cliente cliente)
        {
            SqlConnection db = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand query = new SqlCommand();
            query.CommandText = "INSERT INTO Cliente (cli_dni, cli_nombre) VALUES (@dni, @nombre)";
            query.CommandType = CommandType.Text;
            query.Connection = db;

            // Paramatros
            query.Parameters.AddWithValue("@dni", cliente.Cli_DNI);
            query.Parameters.AddWithValue("@nombre", cliente.Cli_Nombre);

            // Ejecutar la query
            db.Open();
            query.ExecuteNonQuery();
            db.Close();
        }
    }
}
