using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace ClasesBase
{
   public  class TrabajoRol
    {
        public static DataTable cargarRol()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);

            SqlCommand cmd = new SqlCommand("SELECT * FROM Rol", cnn);
                      
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet(); 
          
            da.Fill(ds);
            return ds.Tables[0];




           
          
        }

    }
}
