using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajoUsuario
    {

        public static DataTable cargarUsuario()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void AgregarUsuario(Usuario usuario)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Usuario(USU_NombreUsuario,USU_Password,USU_ApellidoNombre,ROL_Codigo) values (@nomUsu,@pass,@aynu,@rol)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@nomUsu", usuario.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@pass", usuario.Usu_Contraseña);
            cmd.Parameters.AddWithValue("@aynu", usuario.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", usuario.Rol_Codigo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable buscarUsuario(String nombreUsuario)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Usuario";
            cmd.CommandText += " WHERE USU_NombreUsuario LIKE @nombreUsuario";


            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@nombreUsuario", "%" + nombreUsuario + "%");
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sda.Fill(dt);


            return dt;
        }

        public static void eliminarUsuario(int idUsu)
        {
            
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);

           
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "DELETE FROM Usuario WHERE USU_Id=@id";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@id", idUsu);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable listaRoles()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT * FROM Rol";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static void modificarCliente(Usuario usuario)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "UPDATE Usuario SET USU_nombreUsuario = @nomUsu, ";
            cmd.CommandText += " USU_Password = @pass, USU_ApellidoNombre = @aynu,";
            cmd.CommandText += " ROL_Codigo = @rol WHERE USU_Id=@idu";

            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;
            cmd.Parameters.AddWithValue("@idu", usuario.Usu_ID);
            cmd.Parameters.AddWithValue("@nomUsu", usuario.Usu_NombreUsuario);
            cmd.Parameters.AddWithValue("@pass", usuario.Usu_Contraseña);
            cmd.Parameters.AddWithValue("@aynu", usuario.Usu_ApellidoNombre);
            cmd.Parameters.AddWithValue("@rol", usuario.Rol_Codigo);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }
    }
}
