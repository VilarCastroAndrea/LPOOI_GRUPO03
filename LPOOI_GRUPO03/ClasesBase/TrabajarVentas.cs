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
            cmd.CommandText += " V.CLI_DNI as 'clidni', V.VEH_Matricula as 'vehmat', V.USU_ID as 'usuid', ";
            cmd.CommandText += " VTA_Fecha as 'VTAFecha', ";          
            cmd.CommandText += " VTA_FormaPago as 'VTAFormaPago', ";
            cmd.CommandText += " VTA_PrecioFinal as 'VTAPrecioFinal', ";
            cmd.CommandText += " C.CLI_Apellido as 'CLIApellido', USU_NombreUsuario as 'USUNombreUsuario' ";
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







    }
}
