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

        public static DataTable ListaVentas()
        {
             //CONEXION
             SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);
            
             //CONFIGURACION DE LA CONSULTA
             SqlCommand cmd = new SqlCommand();
             cmd.CommandText = "SELECT * FROM Venta";
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
            
           /* SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT";
            cmd.CommandText += " VTA_ID as 'ID VENTA', ";
            cmd.CommandText += " CLI_DNI as 'CLI_DNI', ";
            cmd.CommandText += " VEH_Matricula as 'VEH_Matricula', ";
            cmd.CommandText += " USU_ID as 'USU_ID', ";
            cmd.CommandText += " VTA_Fecha as 'VTA_Fecha' ,";
          
            cmd.CommandText += " VTA_FormaPago as 'VTA_Forma Pago' ,";
            cmd.CommandText += " VTA_PrecioFinal as 'VTA_Precio Final' ";
            cmd.CommandText += " FROM Venta as V";


            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
            */
        }







    }
}
