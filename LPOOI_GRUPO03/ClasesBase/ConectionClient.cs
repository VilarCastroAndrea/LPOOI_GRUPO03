using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase
{
    class ConectionClient
    {
        public static void InsertClient(Cliente client)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Cliente(CLI_DNI,CLI_Nombre,CLI_Apellido,CLI_Direccion,CLI_Telefono) values(@dni,@name,@apll,@dir,@tel)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@dni", client.Cli_DNI);
            cmd.Parameters.AddWithValue("@name", client.Cli_Nombre);
            cmd.Parameters.AddWithValue("@apll", client.Cli_Apellido);
            cmd.Parameters.AddWithValue("@dir", client.Cli_Direccion);
            cmd.Parameters.AddWithValue("@tel", client.Cli_Telefono);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();


        }
    }
}
