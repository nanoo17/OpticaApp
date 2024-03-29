﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarUsuario
    {



        public static DataTable list_roles()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Roles";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
       

        public static void insertarUsuario(Usuario usuario)
        {
            SqlConnection db = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand query = new SqlCommand();
            query.CommandText = "INSERT INTO Usuario (Usu_NombreUsuario,Usu_Contraseña,Usu_ApellidoNombre,Rol_Codigo) VALUES (@usuario,@contraseña, @apellidoNombre, @rol)";
            query.CommandType = CommandType.Text;
            query.Connection = db;

            // Paramatros
            query.Parameters.AddWithValue("@usuario", usuario.Usu_NombreUsuario);
            query.Parameters.AddWithValue("@contraseña", usuario.Usu_Clave);
            query.Parameters.AddWithValue("@apellidoNombre", usuario.Usu_ApellidoNombre);
            query.Parameters.AddWithValue("@rol", usuario.Rol);
           
            // Ejecutar la query
            db.Open();
            query.ExecuteNonQuery();
            db.Close();
        }

        public static DataTable obtenerUsuarios()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT dbo.Usuario.Usu_ID, dbo.Usuario.Usu_NombreUsuario, dbo.Usuario.Usu_Contraseña, dbo.Usuario.Usu_ApellidoNombre, dbo.Usuario.Rol_Codigo, dbo.Roles.Rol_Descripcion FROM dbo.Roles INNER JOIN dbo.Usuario ON dbo.Roles.Rol_Codigo = dbo.Usuario.Rol_Codigo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void eliminarUsuario(Int32 id)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Usuario WHERE Usu_ID = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Paramatros
            cmd.Parameters.AddWithValue("@id", id);

            // Ejecutar la query
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void modificarUsuario(Usuario usuario)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Usuario SET Usu_NombreUsuario = @usuario,Usu_Contraseña = @contraseña,Usu_ApellidoNombre = @apellidoNombre,Rol_Codigo = @rol WHERE Usu_ID = @id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            // Paramatros
            cmd.Parameters.AddWithValue("@id", usuario.Usu_ID);
            cmd.Parameters.AddWithValue("@usuario", usuario.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@contraseña", usuario.Usu_Clave);
            cmd.Parameters.AddWithValue("@apellidoNombre", usuario.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", usuario.Rol);
            // Ejecutar la query
            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable buscarUsuario(string usuario, string password)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario WHERE Usu_NombreUsuario = @usuario AND Usu_Contraseña = @password";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@password", password);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable buscarUsuarioTabla(string usuario)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT dbo.Usuario.Usu_ID, dbo.Usuario.Usu_NombreUsuario, dbo.Usuario.Usu_Contraseña, dbo.Usuario.Usu_ApellidoNombre, dbo.Usuario.Rol_Codigo, dbo.Roles.Rol_Descripcion FROM dbo.Roles INNER JOIN dbo.Usuario ON dbo.Roles.Rol_Codigo = dbo.Usuario.Rol_Codigo WHERE Usu_NombreUsuario LIKE @usuario";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@usuario", "%"+usuario+"%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable obtenerUsuarioPorNombreUsuario(string usuario)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.opticaConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario WHERE Usu_NombreUsuario = @usuario";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@usuario", usuario);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
