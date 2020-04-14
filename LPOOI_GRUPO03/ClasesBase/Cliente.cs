using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cliente
    {
        private string cli_DNI;
        private string cli_Nombre;
        private string cli_Apellido;
        private string cli_Direccion;
        private string cli_Telefono;

        public string Cli_DNI { get => cli_DNI; set => cli_DNI = value; }
        public string Cli_Nombre { get => cli_Nombre; set => cli_Nombre = value; }
        public string Cli_Apellido { get => cli_Apellido; set => cli_Apellido = value; }
        public string Cli_Direccion { get => cli_Direccion; set => cli_Direccion = value; }
        public string Cli_Telefono { get => cli_Telefono; set => cli_Telefono = value; }

    }
}