﻿using System.Data;
using System.Data.SqlClient;
namespace ClasesBase
{
    public class TrabajoRol
    {
        public static DataTable CargarRol()
        {

            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "listaRoles";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }

    }
}
