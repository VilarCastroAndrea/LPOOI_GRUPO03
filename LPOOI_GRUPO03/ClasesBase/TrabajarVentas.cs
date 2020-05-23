using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            SqlParameter cliDni;
            cliDni = new SqlParameter("@cliDni", SqlDbType.VarChar);
            cliDni.Direction = ParameterDirection.Input;
            cliDni.Value = venta.Cli_DNI;

            SqlParameter matricula;
            matricula = new SqlParameter("@matricula", SqlDbType.VarChar);
            matricula.Direction = ParameterDirection.Input;
            matricula.Value = venta.Veh_Matricula;

            SqlParameter userId;
            userId = new SqlParameter("@usuId", SqlDbType.Int);
            userId.Direction = ParameterDirection.Input;
            userId.Value = venta.Usu_ID;

            SqlParameter bdFecha;
            bdFecha = new SqlParameter("@fecha", SqlDbType.Date);
            bdFecha.Direction = ParameterDirection.Input;
            bdFecha.Value = venta.Vta_Fecha;

            SqlParameter bdFormaDePago;
            bdFormaDePago = new SqlParameter("@formaDePago", SqlDbType.VarChar);
            bdFormaDePago.Direction = ParameterDirection.Input;
            bdFormaDePago.Value = venta.Vta_FormaPago;

            SqlParameter bdPrecioFinal;
            bdPrecioFinal = new SqlParameter("@precioFinal", SqlDbType.Decimal);
            bdPrecioFinal.Direction = ParameterDirection.Input;
            bdPrecioFinal.Value = venta.Vta_PrecioFinal;

            cmd.Parameters.Add(cliDni);
            cmd.Parameters.Add(matricula);
            cmd.Parameters.Add(userId);
            cmd.Parameters.Add(bdFecha);
            cmd.Parameters.Add(bdFormaDePago);
            cmd.Parameters.Add(bdPrecioFinal);


            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable listaVenta()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "ListaVentas";

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable buscarVenta(string sPattern,string dni, DateTime desde, DateTime hasta)
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