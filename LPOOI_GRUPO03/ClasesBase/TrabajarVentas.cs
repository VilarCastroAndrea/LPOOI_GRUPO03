using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarVentas
    {

        public static DataTable listaVentas()
        {
             //CONEXION
             SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);
            /*
             //CONFIGURACION DE LA CONSULTA
             SqlCommand cmd = new SqlCommand();
             cmd.CommandText = "SELECT FROM";
             cmd.CommandType = CommandType.Text;
             cmd.Connection = cnn;

             // CREACION DE LA TABLA

             DataTable dt = new DataTable();

             //CREACION DEL ADAPTADOR 

             SqlDataAdapter da = new SqlDataAdapter(cmd);

             //LLENAR TABLA CON LA CONEXION ESTABLECIDA 

             da.Fill(dt);

             //DEVOLVER TABLA
             return dt;  
            */
           SqlCommand cmd = new SqlCommand();
            cmd.CommandText =  "SELECT ";
            cmd.CommandText += " VTA_ID as 'IDVENTA', ";
            cmd.CommandText += " V.CLI_DNI as 'DNI', V.VEH_Matricula as 'Matricula', V.USU_ID as 'ID Usuario', ";
            cmd.CommandText += " VTA_Fecha as 'Fecha Venta', ";          
            cmd.CommandText += " VTA_FormaPago as 'FormaPago', ";
            cmd.CommandText += " VTA_PrecioFinal as 'Precio Final', ";
            cmd.CommandText += " C.CLI_Apellido as 'Apellido', USU_NombreUsuario as 'Nombre Usuario' ";
            cmd.CommandText += " FROM Venta as V";
            cmd.CommandText += " LEFT JOIN Cliente as C ON (C.CLI_DNI=V.CLI_DNI)";
            cmd.CommandText += " LEFT JOIN Vehiculo as VE ON (VE.VEH_Matricula=V.VEH_Matricula)";
            cmd.CommandText += " LEFT JOIN Usuario as U ON (U.USU_ID=V.USU_ID)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
            
        }

        public static void InsertarVenta(Venta venta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Venta(CLI_DNI,VEH_Matricula," +
                "USU_ID,VTA_Fecha,VTA_FormaPago,VTA_PrecioFinal) values(@dni," +
                "@matricula,@usuId,@fecha,@formaDePago,@precioFinal)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;


            cmd.Parameters.AddWithValue("@dni", venta.Cli_DNI);
            cmd.Parameters.AddWithValue("@matricula", venta.Veh_Matricula);
            cmd.Parameters.AddWithValue("@usuId", venta.Usu_ID);
            cmd.Parameters.AddWithValue("@fecha", venta.Vta_Fecha);
            cmd.Parameters.AddWithValue("@formaDePago", venta.Vta_FormaPago);
            cmd.Parameters.AddWithValue("@precioFinal", venta.Vta_PrecioFinal);


            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable ListaVenta()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT";
            cmd.CommandText += " VTA_ID as 'vtaId', ";
            cmd.CommandText += " CLI_DNI as 'dni', ";
            cmd.CommandText += " VEH_Matricula as 'matricula', ";
            cmd.CommandText += " USU_ID as 'usuId', ";
            cmd.CommandText += " VTA_Fecha as 'fecha', ";
            cmd.CommandText += " VTA_FormaPago as 'formaDePago', ";
            cmd.CommandText += " VTA_PrecioFinal as 'precioFinal' ";
            cmd.CommandText += " FROM Venta as V";


            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable buscarVenta(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT";
            cmd.CommandText += " VTA_ID as 'vtaId', ";
            cmd.CommandText += " CLI_DNI as 'dni', ";
            cmd.CommandText += " VEH_Matricula as 'matricula', ";
            cmd.CommandText += " USU_ID as 'usuId', ";
            cmd.CommandText += " VTA_Fecha as 'fecha', ";
            cmd.CommandText += " VTA_FormaPago as 'formaDePago', ";
            cmd.CommandText += " VTA_PrecioFinal as 'precioFinal' ";
            cmd.CommandText += " FROM Venta as V";

            cmd.CommandText += " WHERE";
            cmd.CommandText += " VTA_ID LIKE @pattern ";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
