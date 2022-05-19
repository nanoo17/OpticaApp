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

        public static DataTable obtenerClientes()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Cliente";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void eliminarCliente(Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Cliente WHERE Cli_DNI = @dni";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Paramatros
            cmd.Parameters.AddWithValue("@dni", cliente.Cli_DNI);

            // Ejecutar la query
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void modificarCliente(Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Cliente SET Cli_Nombre = @nombre, Cli_Apellido = @apellido, Cli_Direccion = @direccion, OS_CUIT = @cuit, Cli_NroCarnet = @nroCarnet WHERE Cli_DNI = @dni";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Paramatros
            cmd.Parameters.AddWithValue("@nombre", cliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@apellido", cliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@direccion", cliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@cuit", cliente.OS_CUIT1);
            cmd.Parameters.AddWithValue("@nroCarnet", cliente.Cli_NroCarnet);
            cmd.Parameters.AddWithValue("@dni", cliente.Cli_DNI);

            // Ejecutar la query
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
