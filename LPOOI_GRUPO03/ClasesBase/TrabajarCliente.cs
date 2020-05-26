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

        public static DataTable ListaCliente()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listaClientes";
            cmd.CommandType = CommandType.StoredProcedure;


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


        public static void InsertarCliente(Cliente cliente)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insertarCliente";
            cmd.CommandType = CommandType.StoredProcedure;
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

        public static DataTable buscarClienteAproximado(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "buscarClienteAproximado";
            cmd.CommandType = CommandType.StoredProcedure;
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
            cmd.CommandText = "buscarCliente";

            cmd.CommandType = CommandType.StoredProcedure;
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
            cmd.CommandText = "eliminarCliente";
            cmd.CommandType = CommandType.StoredProcedure;
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
            cmd.CommandText = "modificarCliente";
            cmd.CommandType = CommandType.StoredProcedure;
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
