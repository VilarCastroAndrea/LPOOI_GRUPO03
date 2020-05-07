using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ClasesBase;

namespace Vistas
{
    public partial class FrmRegistrarVenta : Form
    {
        public FrmRegistrarVenta()
        {
            InitializeComponent();
        }


        private void FrmRegistrarVenta_Load(object sender, EventArgs e)
        {
            cargarBoxCliente(TrabajarCliente.ListaCliente());
            cargarBoxVehiculo(TrabajarVehiculo.ListaVehiculo());
        }


        private void cargarBoxVehiculo(DataTable tablaVehiculo)
        {
            cmbVehiculos.Items.Clear();
            cmbVehiculos.SelectionStart = cmbVehiculos.Text.Length;
            for (int i = 0; i < tablaVehiculo.Rows.Count; i++)
            {
                cmbVehiculos.Items.Add(tablaVehiculo.Rows[i]["Matricula"].ToString() + " , " +
                    tablaVehiculo.Rows[i]["Marca"].ToString() + " , " + tablaVehiculo.Rows[i]["Linea"].ToString()
                    + " , " + tablaVehiculo.Rows[i]["Modelo"].ToString() + " , " + tablaVehiculo.Rows[i]["Color"].ToString()
                    + " , " + tablaVehiculo.Rows[i]["Puertas"].ToString() + " , " + tablaVehiculo.Rows[i]["TipoVehiculo"].ToString()
                    + " , " + tablaVehiculo.Rows[i]["ClaseVehiculo"].ToString() + " , " + tablaVehiculo.Rows[i]["Precio"].ToString());
            }
        }


        private void cargarBoxCliente(DataTable tablaCliente)
        {
            cmbClientesDNI.Items.Clear();
            cmbClientesDNI.SelectionStart = cmbClientesDNI.Text.Length;
            for (int i = 0; i < tablaCliente.Rows.Count; i++)
            {
                cmbClientesDNI.Items.Add(tablaCliente.Rows[i]["DNI"].ToString() + " , " +
                    tablaCliente.Rows[i]["Nombre"].ToString() + " , " + tablaCliente.Rows[i]["Apellido"].ToString());
            }
        }

        private void cmbClientesDNI_TextUpdate(object sender, EventArgs e)
        {
            
            cargarBoxCliente(TrabajarCliente.buscarClienteAproximado(cmbClientesDNI.Text));
        }

        private void cmbVehiculos_TextUpdate(object sender, EventArgs e)
        {
            cargarBoxVehiculo(TrabajarVehiculo.buscarVehiculoAproximado(cmbVehiculos.Text));
        }
    }
}
