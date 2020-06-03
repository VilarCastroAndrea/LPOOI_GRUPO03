using System;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarVentas
    {

        public static void insertarVenta(Venta venta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "insertarVenta";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@cliDni", venta.Cli_DNI);
            cmd.Parameters.AddWithValue("@matricula", venta.Veh_Matricula);
            cmd.Parameters.AddWithValue("@usuId", venta.Usu_ID);
            cmd.Parameters.AddWithValue("@fecha", venta.Vta_Fecha);
            cmd.Parameters.AddWithValue("@formaDePago", venta.Vta_FormaPago);
            cmd.Parameters.AddWithValue("@precioFinal", venta.Vta_PrecioFinal);


            SqlDataAdapter da = new SqlDataAdapter(cmd);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable listaVenta()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "listaVentas";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable buscarVenta(string sPattern, string dni, DateTime desde, DateTime hasta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "buscarVenta";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            SqlParameter param;
            param = new SqlParameter("@pattern", SqlDbType.VarChar);
            param.Direction = ParameterDirection.Input;
            param.Value = sPattern;

            SqlParameter bDni;
            bDni = new SqlParameter("@dni", SqlDbType.VarChar);
            bDni.Direction = ParameterDirection.Input;
            bDni.Value = dni;

            SqlParameter bdDesde;
            bdDesde = new SqlParameter("@desde", SqlDbType.Date);
            bdDesde.Direction = ParameterDirection.Input;
            bdDesde.Value = desde;

            SqlParameter bdHasta;
            bdHasta = new SqlParameter("@hasta", SqlDbType.Date);
            bdHasta.Direction = ParameterDirection.Input;
            bdHasta.Value = hasta;

            da.SelectCommand.Parameters.Add(param);
            da.SelectCommand.Parameters.Add(bDni);
            da.SelectCommand.Parameters.Add(bdDesde);
            da.SelectCommand.Parameters.Add(bdHasta);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
