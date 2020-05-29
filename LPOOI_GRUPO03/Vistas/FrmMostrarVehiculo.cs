using ClasesBase;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmMostrarVehiculo : Form
    {
        public FrmMostrarVehiculo()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Modifique seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMVehiculo_Click(object sender, EventArgs e)
        {
            Vehiculo v = new Vehiculo();

            Form frmVehiculo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmVehiculo);
            if (frmVehiculo != null)
            {
                v.Veh_Matricula = txtAMatricula.Text;
                v.Veh_Marca = txtAMarca.Text;
                v.Veh_Linea = txtALinea.Text;
                v.Veh_Modelo = Convert.ToInt32(cmbModelo.Text);
                v.Veh_Color = cmbColor.Text;
                v.Veh_Puertas = Convert.ToInt32(cmbCantPuert.Text);
                v.Veh_TipoVehiculo = txtATipo.Text;
                v.Veh_ClaseVehiculo = txtAClase.Text;
                v.Veh_GPS = cGps.Checked;
                v.Veh_Precio = Convert.ToDecimal(txtAPrecio.Text);
                //TrabajarVehiculo.modificarVehiculo(v);
                //STORE PROCEDURE
                TrabajarVehiculo.modificarVehiculoSP(v);

                MessageBox.Show("Vehiculo Modificado");
                ((FrmVehiculo)frmVehiculo).dataVehiculo.DataSource = TrabajarVehiculo.ListaVehiculo();
            }
        }

        /// <summary>
        /// Elimina al vehiculo seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEVehiculo_Click(object sender, EventArgs e)
        {
            Form frmVehiculo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmVehiculo);
            if (frmVehiculo != null)
            {
                DataTable dt = new DataTable();
                dt = TrabajarVehiculo.buscarVehiculoVendido(txtAMatricula.Text);
                if (dt.Rows.Count !=0)
                {
                    MessageBox.Show("Vehiculo Ya Vendido");
                } else
                {
                    TrabajarVehiculo.eliminarVehiculoSP(txtAMatricula.Text);

                    MessageBox.Show("Vehiculo Eliminado");
                    ((FrmVehiculo)frmVehiculo).dataVehiculo.DataSource = TrabajarVehiculo.ListaVehiculo();
                }
              
               
            }
        }
    }
}
