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

        public static DataTable listaVenta()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT";
            cmd.CommandText += " venta.VTA_ID as 'ID de la Venta', ";

            cmd.CommandText += " cliente.CLI_DNI as 'DNI', cliente.CLI_Nombre as 'Nombre'," +
                " cliente.CLI_Apellido as 'Apellido', cliente.CLI_Direccion as 'Direccion'," +
                " cliente.CLI_Telefono as 'Telefono', ";

            cmd.CommandText += " vehiculo.VEH_Matricula as 'Matricula', ";
            cmd.CommandText += " vehiculo.VEH_Marca as 'Marca', ";
            cmd.CommandText += " vehiculo.VEH_Linea as 'Linea', ";
            cmd.CommandText += " vehiculo.VEH_Modelo as 'Modelo', ";
            cmd.CommandText += " vehiculo.VEH_Color as 'Color', ";
            cmd.CommandText += " vehiculo.VEH_Puertas as 'Puertas', ";
            cmd.CommandText += " vehiculo.VEH_GPS as 'Gps', ";
            cmd.CommandText += " vehiculo.VEH_TipoVehiculo as 'Tipo de Vehiculo', ";
            cmd.CommandText += " vehiculo.VEH_ClaseVehiculo as 'Clase de Vehiculo', ";
            cmd.CommandText += " vehiculo.VEH_Precio as 'Precio', ";

            cmd.CommandText += " usuario.USU_ApellidoNombre as 'Apellido y Nombre', ";


            cmd.CommandText += " venta.VTA_Fecha as 'Fecha de Venta', ";
            cmd.CommandText += " venta.VTA_FormaPago as 'Forma de Pago', ";
            cmd.CommandText += " venta.VTA_PrecioFinal as 'Precio Final' ";

            cmd.CommandText += " FROM Venta as venta";
            cmd.CommandText += " INNER JOIN Vehiculo as vehiculo ON Venta.VEH_Matricula = Vehiculo.VEH_Matricula ";
            cmd.CommandText += " INNER JOIN Usuario as usuario ON Venta.USU_ID = Usuario.USU_ID ";
            cmd.CommandText += " INNER JOIN Cliente as cliente ON Venta.CLI_DNI = cliente.CLI_DNI ";



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
            cmd.CommandText += " CLI_DNI LIKE @pattern ";


            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable buscarVentaMarca(string sPattern,string dni, string desde, string hasta)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT";
            cmd.CommandText += " venta.VTA_ID as 'ID de la Venta', ";

            cmd.CommandText += " cliente.CLI_DNI as 'DNI', cliente.CLI_Nombre as 'Nombre'," +
                " cliente.CLI_Apellido as 'Apellido', cliente.CLI_Direccion as 'Direccion'," +
                " cliente.CLI_Telefono as 'Telefono', ";

            cmd.CommandText += " vehiculo.VEH_Matricula as 'Matricula', ";
            cmd.CommandText += " vehiculo.VEH_Marca as 'Marca', ";
            cmd.CommandText += " vehiculo.VEH_Linea as 'Linea', ";
            cmd.CommandText += " vehiculo.VEH_Modelo as 'Modelo', ";
            cmd.CommandText += " vehiculo.VEH_Color as 'Color', ";
            cmd.CommandText += " vehiculo.VEH_Puertas as 'Puertas', ";
            cmd.CommandText += " vehiculo.VEH_GPS as 'Gps', ";
            cmd.CommandText += " vehiculo.VEH_TipoVehiculo as 'Tipo de Vehiculo', ";
            cmd.CommandText += " vehiculo.VEH_ClaseVehiculo as 'Clase de Vehiculo', ";
            cmd.CommandText += " vehiculo.VEH_Precio as 'Precio', ";

            cmd.CommandText += " usuario.USU_ApellidoNombre as 'Apellido y Nombre', ";

            
            cmd.CommandText += " venta.VTA_Fecha as 'Fecha de Venta', ";
            cmd.CommandText += " venta.VTA_FormaPago as 'Forma de Pago', ";
            cmd.CommandText += " venta.VTA_PrecioFinal as 'Precio Final' ";

            cmd.CommandText += " FROM Venta as venta";
            cmd.CommandText += " INNER JOIN Vehiculo as vehiculo ON Venta.VEH_Matricula = Vehiculo.VEH_Matricula ";
            cmd.CommandText += " INNER JOIN Usuario as usuario ON Venta.USU_ID = Usuario.USU_ID ";
            cmd.CommandText += " INNER JOIN Cliente as cliente ON Venta.CLI_DNI = cliente.CLI_DNI ";
            cmd.CommandText += " WHERE";
            cmd.CommandText += " Vehiculo.VEH_Marca LIKE @pattern ";
            cmd.CommandText += " AND Venta.CLI_DNI LIKE @dni" ;
            cmd.CommandText += " AND Venta.VTA_Fecha between @desde and @hasta;";


            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");
            cmd.Parameters.AddWithValue("@dni", "%" + dni + "%");
            cmd.Parameters.AddWithValue("@desde",  desde);
            cmd.Parameters.AddWithValue("@hasta",  hasta);


            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
    }
}
