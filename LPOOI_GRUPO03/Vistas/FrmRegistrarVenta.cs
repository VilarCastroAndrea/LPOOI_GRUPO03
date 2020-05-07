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
                cmbVehiculos.Items.Add(tablaVehiculo.Rows[i]["Matricula"].ToString() + " | " +
                    tablaVehiculo.Rows[i]["Marca"].ToString() + " , " + tablaVehiculo.Rows[i]["Linea"].ToString()
                    + " | " + tablaVehiculo.Rows[i]["Modelo"].ToString() + " | " + tablaVehiculo.Rows[i]["Color"].ToString()
                    + " | " + tablaVehiculo.Rows[i]["Puertas"].ToString() + " | " + tablaVehiculo.Rows[i]["TipoVehiculo"].ToString()
                    + " | " + tablaVehiculo.Rows[i]["ClaseVehiculo"].ToString() + " | " + tablaVehiculo.Rows[i]["Precio"].ToString());
            }
        }


        private void cargarBoxCliente(DataTable tablaCliente)
        {
            cmbClientesDNI.Items.Clear();
            cmbClientesDNI.SelectionStart = cmbClientesDNI.Text.Length;
            for (int i = 0; i < tablaCliente.Rows.Count; i++)
            {
                cmbClientesDNI.Items.Add(tablaCliente.Rows[i]["DNI"].ToString() + " | " +
                    tablaCliente.Rows[i]["Nombre"].ToString() + " | " + tablaCliente.Rows[i]["Apellido"].ToString());
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

        private void cmbVehiculos_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] cadena = cmbVehiculos.Text.Split('|');
            txtPrecio.Text = cadena[7];
            txtPrecio.Text = txtPrecio.Text.TrimStart();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            string[] cadenaVehiculo = cmbVehiculos.Text.Split('|');
            string[] cadenaCliente = cmbClientesDNI.Text.Split('|');
            Venta nuevaVenta = new Venta();

            nuevaVenta.Cli_DNI = cadenaCliente[0].TrimEnd();
            nuevaVenta.Veh_Matricula = cadenaVehiculo[0].TrimEnd();
            nuevaVenta.Vta_Fecha = dtpFecha.Value;
            //TO DO coneccion a bd y session
            nuevaVenta.Usu_ID = 1;
            nuevaVenta.Vta_FormaPago = cmbMedioDePago.Text;
            nuevaVenta.Vta_PrecioFinal = Convert.ToDecimal(txtPrecio.Text);
            TrabajarVentas.InsertarVenta(nuevaVenta);
        }
    }
}
