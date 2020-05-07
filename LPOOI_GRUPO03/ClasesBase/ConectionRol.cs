using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace ClasesBase
{
    class ConectionRol
    {
        public static DataTable ListRol()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Rol";
           
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            
            DataTable dt = new DataTable();
            sda.Fill(dt);

            return dt;
        }
    }
}
