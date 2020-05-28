using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarVehiculo
    {

        public static void insertarVehiculoSP(Vehiculo vehiculo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "insertarVehiculo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@matricula", vehiculo.Veh_Matricula);
            cmd.Parameters.AddWithValue("@marca", vehiculo.Veh_Marca);
            cmd.Parameters.AddWithValue("@linea", vehiculo.Veh_Linea);
            cmd.Parameters.AddWithValue("@modelo", vehiculo.Veh_Modelo);
            cmd.Parameters.AddWithValue("@color", vehiculo.Veh_Color);
            cmd.Parameters.AddWithValue("@puertas", vehiculo.Veh_Puertas);
            cmd.Parameters.AddWithValue("@GPS", vehiculo.Veh_GPS);
            cmd.Parameters.AddWithValue("@tipovehiculo", vehiculo.Veh_TipoVehiculo);
            cmd.Parameters.AddWithValue("@clasevehiculo", vehiculo.Veh_ClaseVehiculo);
            cmd.Parameters.AddWithValue("@precio", vehiculo.Veh_Precio);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void modificarVehiculoSP(Vehiculo vehiculo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "modificarVehiculo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@matricula", vehiculo.Veh_Matricula);
            cmd.Parameters.AddWithValue("@marca", vehiculo.Veh_Marca);
            cmd.Parameters.AddWithValue("@linea", vehiculo.Veh_Linea);
            cmd.Parameters.AddWithValue("@modelo", vehiculo.Veh_Modelo);
            cmd.Parameters.AddWithValue("@color", vehiculo.Veh_Color);
            cmd.Parameters.AddWithValue("@puertas", vehiculo.Veh_Puertas);
            cmd.Parameters.AddWithValue("@GPS", vehiculo.Veh_GPS);
            cmd.Parameters.AddWithValue("@tipovehiculo", vehiculo.Veh_TipoVehiculo);
            cmd.Parameters.AddWithValue("@clasevehiculo", vehiculo.Veh_ClaseVehiculo);
            cmd.Parameters.AddWithValue("@precio", vehiculo.Veh_Precio);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static void eliminarVehiculoSP(string matricula)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "eliminarVehiculo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@matricula", matricula);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable buscarVehiculo(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "buscarVehiculo";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable buscarVehiculoAproximado(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "buscarVehiculoAproximado";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@pattern", "%" + sPattern + "%");

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable ListaVehiculo()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "SELECT * FROM ListarVehiculo";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable ListaMarca()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "listaMarca";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable ordenarVporMarca()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "ordenarVehiculoPorMarca";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public static DataTable ordenarVporLinea()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);
            SqlCommand cmd = new SqlCommand();

            cmd.CommandText = "ordenarVporLinea";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

    }

}
