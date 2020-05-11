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
                    tablaVehiculo.Rows[i]["Marca"].ToString() + " | " + tablaVehiculo.Rows[i]["Linea"].ToString()
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
            txtPrecio.Text = cadena[8];
            txtPrecio.Text = txtPrecio.Text.TrimStart();
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (validarCampos())
            {
                Venta nuevaVenta = new Venta();
                nuevaVenta.Cli_DNI = primerValorCombobox(cmbClientesDNI.Text);
                nuevaVenta.Veh_Matricula = primerValorCombobox(cmbVehiculos.Text);
                nuevaVenta.Vta_Fecha = dtpFecha.Value;
                //TO DO session
                nuevaVenta.Usu_ID = 1;
                nuevaVenta.Vta_FormaPago = cmbMedioDePago.Text;
                nuevaVenta.Vta_PrecioFinal = Convert.ToDecimal(txtPrecio.Text);
                TrabajarVentas.InsertarVenta(nuevaVenta);
                limpiarCampos();
            }
            else
            {
                MessageBox.Show("alerta");
            }
        }

        private bool validarCampos()
        {
            if(cmbClientesDNI.Text!="" && cmbClientesDNI.Text.Split('|').Length == 3)
            {
                if(cmbVehiculos.Text != "" && cmbVehiculos.Text.Split('|').Length == 9)
                {
                    if (cmbMedioDePago.Text != ""|| cmbMedioDePago.Text=="Tarjeta De Credito"||
                        cmbMedioDePago.Text == "Efectivo"||cmbMedioDePago.Text == "Credito Personal")
                    {
                        if(txtPrecio.Text != "")
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        private string primerValorCombobox(string textoCombo)
        {
           return textoCombo.Split('|')[0].TrimEnd();
        }

        private void limpiarCampos()
        {
            cmbClientesDNI.Text = "";
            cmbVehiculos.Text = "";
            dtpFecha.Value = DateTime.Now;
            cmbMedioDePago.Text = "";
            txtPrecio.Text = "";
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
