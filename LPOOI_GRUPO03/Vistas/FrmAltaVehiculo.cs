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
    public partial class FrmAltaVehiculo : Form
    {
        private List<Vehiculo> listaDeVehiculos = new List<Vehiculo>();
        public FrmAltaVehiculo()
        {
            InitializeComponent();
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

        private void btnAltaVeh_Click(object sender, EventArgs e)
        {
            String opcionGPS = "No";
            if (cmbModelo.Text != "" && cmbCantPuert.Text != "" && cmbColor.Text != "" && txtALinea.Text != "" && txtAMarca.Text != "" && txtAMatricula.Text != "" && txtATipo.Text != "" && txtAPrecio.Text != "" && txtAClase.Text != "")
            {
                int m = Convert.ToInt32(cmbModelo.Text);
                int p = Convert.ToInt32(cmbCantPuert.Text);
                Decimal precio = Convert.ToDecimal(txtAPrecio.Text);
                Vehiculo vehiculo = new Vehiculo(txtAMatricula.Text, txtAMarca.Text, txtALinea.Text, m, cmbColor.Text, p, checkGps.Checked, txtATipo.Text, txtAClase.Text, precio);
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
                    TrabajarVehiculo.insertarVehiculo(vehiculo);
                    txtAMatricula.Text = "";
                    txtAMarca.Text = "";
                    txtALinea.Text = "";
                    cmbModelo.Text = "";
                    cmbColor.Text = "";
                    cmbCantPuert.Text = "";
                    checkGps.Checked = false;
                    txtATipo.Text = "";
                    txtAClase.Text = "";
                    txtAPrecio.Text = "";
                    Form frmListaVehiculo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmListaVehiculo);
                    if (frmListaVehiculo != null)
                    {
                        ((FrmListaVehiculo)frmListaVehiculo).dataVehiculos.DataSource = null;
                        ((FrmListaVehiculo)frmListaVehiculo).dataVehiculos.DataSource = listaDeVehiculos;
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
    }
}
