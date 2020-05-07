using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace ClasesBase
{
    class ConectionUser
    {
        public static void InsertUser( Usuario user)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario(USU_NombreUsuario,USU_Password,USU_ApellidoNombre,ROL_Codigo) values(@name,@pswd,@ayn,@rol)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@name",user.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@pswd", user.Usu_Contraseña);
            cmd.Parameters.AddWithValue("@ayn", user.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", user.Rol_Codigo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();


        }
    }
}
