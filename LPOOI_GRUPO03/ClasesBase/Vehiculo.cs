using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Vehiculo
    {
        private string veh_Matricula;
        private string veh_Marca;
        private string veh_Linea;
        private int veh_Modelo;
        private string veh_Color;
        private int veh_Puertas;
        private bool veh_GPS;
        private string veh_TipoVehiculo;
        private string veh_ClaseVehiculo;
        private decimal veh_Precio;

        public string Veh_Matricula { get => veh_Matricula; set => veh_Matricula = value; }
        public string Veh_Marca { get => veh_Marca; set => veh_Marca = value; }
        public string Veh_Linea { get => veh_Linea; set => veh_Linea = value; }
        public int Veh_Modelo { get => veh_Modelo; set => veh_Modelo = value; }
        public string Veh_Color { get => veh_Color; set => veh_Color = value; }
        public int Veh_Puertas { get => veh_Puertas; set => veh_Puertas = value; }
        public bool Veh_GPS { get => veh_GPS; set => veh_GPS = value; }
        public string Veh_TipoVehiculo { get => veh_TipoVehiculo; set => veh_TipoVehiculo = value; }
        public string Veh_ClaseVehiculo { get => veh_ClaseVehiculo; set => veh_ClaseVehiculo = value; }
        public decimal Veh_Precio { get => veh_Precio; set => veh_Precio = value; }

        public Vehiculo() { }

        public Vehiculo(string matricula, string marca, string linea, int modelo, string color, int puertas, bool gps, string tipo, string clase, decimal precio)
        {
            Veh_Matricula = matricula;
            Veh_Marca = marca;
            Veh_Linea = linea;
            Veh_Modelo = modelo;
            Veh_Color = color;
            Veh_Puertas = puertas;
            Veh_GPS = gps;
            Veh_TipoVehiculo = tipo;
            Veh_ClaseVehiculo = clase;
            Veh_Precio = precio;
        }
    }
}