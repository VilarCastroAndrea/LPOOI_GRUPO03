using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarCliente
    {

        public static void InsertarCliente(Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Cliente(CLI_DNI,CLI_Nombre,CLI_Apellido,CLI_Direccion,CLI_Telefono) values(@dni,@nombre,@apellido,@direccion,@telefono)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", cliente.Cli_DNI);
            cmd.Parameters.AddWithValue("@nombre", cliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@apellido", cliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@direccion", cliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@telefono", cliente.Cli_Telefono);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable ListaCliente()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT";
            cmd.CommandText += " CLI_DNI as 'Dni', ";
            cmd.CommandText += " CLI_Nombre as 'Nombre', ";
            cmd.CommandText += " CLI_Apellido as 'Apellido', ";
            cmd.CommandText += " CLI_Direccion as 'Direccion', ";
            cmd.CommandText += " CLI_Telefono as 'Telefono' ";
            cmd.CommandText += " FROM Cliente as C";


            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable ListaClientesPorApellido()
        {
             SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);

            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "ListarClientesApellido";
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;

                                                    
        }

        public static DataTable buscarClienteAproximado(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT";
            cmd.CommandText += " CLI_DNI as 'Dni', ";
            cmd.CommandText += " CLI_Nombre as 'Nombre', ";
            cmd.CommandText += " CLI_Apellido as 'Apellido', ";
            cmd.CommandText += " CLI_Direccion as 'Direccion', ";
            cmd.CommandText += " CLI_Telefono as 'Telefono' ";
            cmd.CommandText += " FROM Cliente as C ";

            cmd.CommandText += " WHERE";
            cmd.CommandText += " CLI_DNI LIKE @pattern";
            cmd.CommandText += " OR CLI_Apellido LIKE @pattern";
            cmd.CommandText += " OR CLI_Nombre LIKE @pattern";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        public static DataTable buscarCliente(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT";
            cmd.CommandText += " CLI_DNI as 'Dni', ";
            cmd.CommandText += " CLI_Nombre as 'Nombre', ";
            cmd.CommandText += " CLI_Apellido as 'Apellido', ";
            cmd.CommandText += " CLI_Direccion as 'Direccion', ";
            cmd.CommandText += " CLI_Telefono as 'Telefono' ";
            cmd.CommandText += " FROM Cliente as C ";

            cmd.CommandText += " WHERE";
            cmd.CommandText += " CLI_DNI LIKE @pattern or";
            cmd.CommandText += " CLI_Apellido LIKE @pattern2 "; 

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");
            cmd.Parameters.AddWithValue("@pattern2", "%" + sPattern + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static void eliminarCliente(string dniCliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Cliente WHERE CLI_DNI=@dni";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", dniCliente);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void modificarCliente(Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Cliente SET CLI_Nombre = @nombre, ";
            cmd.CommandText += " CLI_Apellido = @apellido, CLI_Direccion = @direccion, ";
            cmd.CommandText += " CLI_Telefono = @telefono WHERE CLI_DNI=@dni";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@dni", cliente.Cli_DNI);
            cmd.Parameters.AddWithValue("@nombre", cliente.Cli_Nombre);
            cmd.Parameters.AddWithValue("@apellido", cliente.Cli_Apellido);
            cmd.Parameters.AddWithValue("@direccion", cliente.Cli_Direccion);
            cmd.Parameters.AddWithValue("@telefono", cliente.Cli_Telefono);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }

    
}
