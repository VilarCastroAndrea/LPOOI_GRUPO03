using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Venta
    {
        private int vta_ID;
        private string cli_DNI;
        private string veh_Matricula;
        private int usu_ID;
        private DateTime vta_Fecha;
        private string vta_FormaPago;
        private decimal vta_PrecioFinal;

        public int Vta_ID { get => vta_ID; set => vta_ID = value; }
        public string Cli_DNI { get => cli_DNI; set => cli_DNI = value; }
        public string Veh_Matricula { get => veh_Matricula; set => veh_Matricula = value; }
        public int Usu_ID { get => usu_ID; set => usu_ID = value; }
        public DateTime Vta_Fecha { get => vta_Fecha; set => vta_Fecha = value; }
        public string Vta_FormaPago { get => vta_FormaPago; set => vta_FormaPago = value; }
        public decimal Vta_PrecioFinal { get => vta_PrecioFinal; set => vta_PrecioFinal = value; }
    }
}