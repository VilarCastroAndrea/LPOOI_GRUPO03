using ClasesBase;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmAltaVehiculo : Form
    {

        public FrmAltaVehiculo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Agrega un vehiculo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAltaVeh_Click(object sender, EventArgs e)
        {
            String opcionGPS = "No";
            if (cmbModelo.Text != "" && cmbCantPuert.Text != "" && cmbColor.Text != "" && txtALinea.Text != "" && cmbMarca.Text != "" && txtAMatricula.Text != "" && cmbTipo.Text != "" && txtAPrecio.Text != "" && cmbClase.Text != "")
            {
                int m = Convert.ToInt32(cmbModelo.Text);
                int p = Convert.ToInt32(cmbCantPuert.Text);
                Decimal precio = Convert.ToDecimal(txtAPrecio.Text);
                Vehiculo vehiculo = new Vehiculo(txtAMatricula.Text, cmbMarca.Text, txtALinea.Text, m, cmbColor.Text, p, checkGps.Checked, cmbTipo.Text, cmbClase.Text, precio);
                if (vehiculo.Veh_GPS == true)
                {
                    opcionGPS = "Si";
                }
                DialogResult result = MessageBox.Show("Los Datos ingresados son correctos? " + "\n" +
                                                       "Matricula: " + vehiculo.Veh_Matricula + "\n" +
                                                       "Marca: " + vehiculo.Veh_Marca + "\n" +
                                                       "Linea: " + vehiculo.Veh_Linea + "\n" +
                                                       "Modelo: " + vehiculo.Veh_Modelo + "\n" +
                                                       "Color: " + vehiculo.Veh_Color + "\n" +
                                                       "Puertas: " + vehiculo.Veh_Puertas + "\n" +
                                                       "GPS: " + opcionGPS + "\n" +
                                                       "Tipo de Vehiculo: " + vehiculo.Veh_TipoVehiculo + "\n" +
                                                       "Clase de Vehiculo: " + vehiculo.Veh_ClaseVehiculo + "\n" +
                                                       "Precio: " + vehiculo.Veh_Precio, "Agregar Cliente", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    // TrabajarVehiculo.insertarVehiculo(vehiculo);

                    //STORED PROCEDURE
                    TrabajarVehiculo.insertarVehiculoSP(vehiculo);

                    txtAMatricula.Text = "";
                    cmbMarca.Text = "";
                    txtALinea.Text = "";
                    cmbModelo.Text = "";
                    cmbColor.Text = "";
                    cmbCantPuert.Text = "";
                    checkGps.Checked = false;
                    cmbTipo.Text = "";
                    cmbClase.Text = "";
                    txtAPrecio.Text = "";
                    Form frmListaVehiculo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmVehiculo);
                    if (frmListaVehiculo != null)
                    {
                        ((FrmVehiculo)frmListaVehiculo).dataVehiculo.DataSource = null;
                        ((FrmVehiculo)frmListaVehiculo).dataVehiculo.DataSource = TrabajarVehiculo.ListaVehiculo();
                    }
                }
                else
                {
                    MessageBox.Show("Se cancelo el alta del cliente", "Cancelado");
                    result = new DialogResult();
                }
            }
            else
            {
                MessageBox.Show("complete todos los campos");
            }
        }

        /// <summary>
        /// Valida campos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtAMarca_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
        }

        private void txtAColor_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
        }

        private void txtATipo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
        }

        private void txtAClase_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
        }

        private void txtAModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void txtAPuertas_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void txtAPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
            Validar.numerosDecimales(e);
        }
    }
}
