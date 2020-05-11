﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ClasesBase
{
    public class TrabajarVehiculo
    {
        public static void InsertarVehiculo(Vehiculo vehiculo)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "INSERT INTO Vehiculo(VEH_Matricula,VEH_Marca,VEH_Linea," +
                "VEH_Modelo,VEH_Color,VEH_Puertas,VEH_GPS,VEH_TipoVehiculo,VEH_ClaseVehiculo," +
                "VEH_Precio) values(@matricula,@marca,@linea,@modelo,@color,@puertas,@gps,@tipovehiculo" +
                ",@clasevehiculo,@precio)";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            cmd.Parameters.AddWithValue("@matricula", vehiculo.Veh_Matricula);
            cmd.Parameters.AddWithValue("@marca", vehiculo.Veh_Marca);
            cmd.Parameters.AddWithValue("@linea", vehiculo.Veh_Linea);
            cmd.Parameters.AddWithValue("@modelo", vehiculo.Veh_Modelo);
            cmd.Parameters.AddWithValue("@color", vehiculo.Veh_Color);
            cmd.Parameters.AddWithValue("@puertas", vehiculo.Veh_Puertas);
            cmd.Parameters.AddWithValue("@gps", vehiculo.Veh_GPS);
            cmd.Parameters.AddWithValue("@tipovehiculo", vehiculo.Veh_TipoVehiculo);
            cmd.Parameters.AddWithValue("@clasevehiculo", vehiculo.Veh_ClaseVehiculo);
            cmd.Parameters.AddWithValue("@precio", vehiculo.Veh_Precio);

            cnn.Open();
            cmd.ExecuteNonQuery();
            cnn.Close();
        }

        public static DataTable ListaVehiculo()
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT";
            cmd.CommandText += " VEH_Matricula as 'Matricula', ";
            cmd.CommandText += " VEH_Marca as 'Marca', ";
            cmd.CommandText += " VEH_Linea as 'Linea', ";
            cmd.CommandText += " VEH_Modelo as 'Modelo', ";
            cmd.CommandText += " VEH_Color as 'Color', ";
            cmd.CommandText += " VEH_Puertas as 'Puertas', ";
            cmd.CommandText += " VEH_GPS as 'Gps', ";
            cmd.CommandText += " VEH_TipoVehiculo as 'TipoVehiculo', ";
            cmd.CommandText += " VEH_ClaseVehiculo as 'ClaseVehiculo', ";
            cmd.CommandText += " VEH_Precio as 'Precio' ";
            cmd.CommandText += " FROM Vehiculo as V";


            cmd.CommandType = CommandType.Text;
            cmd.Connection = cnn;

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }

        public static DataTable buscarVehiculo(string sPattern)
        {
            SqlConnection cnn = new SqlConnection(ClasesBase.Properties.Settings.Default.AgenciaDBConnectionString);

            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "SELECT";
            cmd.CommandText += " VEH_Matricula as 'Matricula', ";
            cmd.CommandText += " VEH_Marca as 'Marca', ";
            cmd.CommandText += " VEH_Linea as 'Linea', ";
            cmd.CommandText += " VEH_Modelo as 'Modelo', ";
            cmd.CommandText += " VEH_Color as 'Color', ";
            cmd.CommandText += " VEH_Puertas as 'Puertas', ";
            cmd.CommandText += " VEH_GPS as 'Gps', ";
            cmd.CommandText += " VEH_TipoVehiculo as 'TipoVehiculo', ";
            cmd.CommandText += " VEH_ClaseVehiculo as 'ClaseVehiculo', ";
            cmd.CommandText += " VEH_Precio as 'Precio' ";
            cmd.CommandText += " FROM Vehiculo as V";

            cmd.CommandText += " WHERE";
            cmd.CommandText += " VEH_Matricula LIKE @pattern ";

            cmd.CommandType = CommandType.Text;
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
            cmd.CommandText = "SELECT";
            cmd.CommandText += " VEH_Matricula as 'Matricula', ";
            cmd.CommandText += " VEH_Marca as 'Marca', ";
            cmd.CommandText += " VEH_Linea as 'Linea', ";
            cmd.CommandText += " VEH_Modelo as 'Modelo', ";
            cmd.CommandText += " VEH_Color as 'Color', ";
            cmd.CommandText += " VEH_Puertas as 'Puertas', ";
            cmd.CommandText += " VEH_GPS as 'Gps', ";
            cmd.CommandText += " VEH_TipoVehiculo as 'TipoVehiculo', ";
            cmd.CommandText += " VEH_ClaseVehiculo as 'ClaseVehiculo', ";
            cmd.CommandText += " VEH_Precio as 'Precio' ";
            cmd.CommandText += " FROM Vehiculo as V";

            cmd.CommandText += " WHERE";
            cmd.CommandText += " VEH_Matricula LIKE @pattern";
            cmd.CommandText += " OR VEH_Marca LIKE @pattern";
            cmd.CommandText += " OR VEH_Linea LIKE @pattern";
            cmd.CommandText += " OR VEH_Modelo LIKE @pattern";
            cmd.CommandText += " OR VEH_Color LIKE @pattern";
            cmd.CommandText += " OR VEH_Puertas LIKE @pattern";
            cmd.CommandText += " OR VEH_TipoVehiculo LIKE @pattern";
            cmd.CommandText += " OR VEH_ClaseVehiculo LIKE @pattern";
            cmd.CommandText += " OR VEH_Precio LIKE @pattern";

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