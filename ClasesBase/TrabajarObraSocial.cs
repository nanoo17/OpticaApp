using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarObraSocial
    {
        public static DataTable obtenerObraSocial()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM ObraSocial";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static DataTable obtenerClientesObraSocial() {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Vista_Listar_Clientes_ObraSocial";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static DataTable obtenerObraSocialDetalle()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT OS_CUIT + ' '+'|' + ' '+  OS_RazonSocial as detalle, OS_CUIT FROM ObraSocial";
            cmd.CommandType = CommandType.Text; 
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr[0] = "Todas";
            dt.Rows.Add(dr);

            return dt;
        }
        public static DataTable obtenerObraSocialEspecifica(string os_cuit) {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Vista_Listar_Clientes_ObraSocial WHERE OS_CUIT = @cuit";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@cuit", os_cuit);
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void cargarObraSocial(ObraSocial obra) {

            SqlConnection db = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand query = new SqlCommand();
            query.CommandText = "INSERT INTO ObraSocial (OS_CUIT, OS_RazonSocial, OS_Direccion, OS_Telefono) VALUES (@cuit,@razon,@direccion,@telefono)";
            query.CommandType = CommandType.Text;
            query.Connection = db;

            // Paramatros
            query.Parameters.AddWithValue("@cuit", obra.OS_CUIT1);
            query.Parameters.AddWithValue("@razon", obra.OS_RazonSocial1);
            query.Parameters.AddWithValue("@direccion", obra.OS_Direccion1);
            query.Parameters.AddWithValue("@telefono", obra.OS_Telefono1);
          

            // Ejecutar la query
            db.Open();
            query.ExecuteNonQuery();
            db.Close();
        }
    }
}
