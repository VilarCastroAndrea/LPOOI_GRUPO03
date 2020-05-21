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
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmRegistrarVenta>().FirstOrDefault();
            FrmRegistrarVenta frmRegistrarVenta = form ?? new FrmRegistrarVenta();
            AddFormInPanel(frmRegistrarVenta);
            cargarVentas();

            cargarBoxCliente(TrabajarCliente.ListaCliente());
            cargarBoxMarca(TrabajarVehiculo.ListaMarca());
            dtpDesde.MinDate = new DateTime(2010, 1, 1);
            dtpDesde.MaxDate = DateTime.Today;
            dtpHasta.MinDate = new DateTime(2010, 1, 1);
            dtpHasta.MaxDate = DateTime.Today;
        }

        public void cargarVentas()
        {
            dataVenta.DataSource = TrabajarVentas.listaVentas();
        }

        private void AddFormInPanel(Form fh)
        {
            if (this.panelVenta.Controls.Count > 0)
                this.panelVenta.Controls.RemoveAt(0);
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelVenta.Controls.Add(fh);
            this.panelVenta.Tag = fh;
            fh.Show();
         
        }
        
        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmRegistrarVenta>().FirstOrDefault();
            FrmRegistrarVenta frmRegistrarVenta = form ?? new FrmRegistrarVenta();
            AddFormInPanel(frmRegistrarVenta);
        }
        
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarVenta>().FirstOrDefault();
            FrmMostrarVenta frmVenta = form ?? new FrmMostrarVenta();
            AddFormInPanel(frmVenta);
        }


        private void cargarBoxCliente(DataTable tablaCliente)
        {
            cmbClientes.Items.Clear();
            cmbClientes.SelectionStart = cmbClientes.Text.Length;
            for (int i = 0; i < tablaCliente.Rows.Count; i++)
            {
                cmbClientes.Items.Add(tablaCliente.Rows[i]["DNI"].ToString() + " | " +
                    tablaCliente.Rows[i]["Nombre"].ToString() + " | " + tablaCliente.Rows[i]["Apellido"].ToString());
            }
        }

        private void cargarBoxMarca(DataTable tablaVehiculo)
        {
            cmbMarca.Items.Clear();
            cmbMarca.SelectionStart = cmbMarca.Text.Length;
            for (int i = 0; i < tablaVehiculo.Rows.Count; i++)
            {
                cmbMarca.Items.Add(tablaVehiculo.Rows[i][0].ToString());
            }
        }

        private void cmbClientes_TextUpdate(object sender, EventArgs e)
        {
            cargarBoxCliente(TrabajarCliente.buscarClienteAproximado(cmbClientes.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dtpDesde.Value = new DateTime(2010, 1, 1);
        }

        private void btnBusacar_Click(object sender, EventArgs e)
        {

                dataVenta.DataSource = TrabajarVentas.buscarVentaMarca(cmbMarca.Text, primerValorCombobox(cmbClientes.Text),dtpDesde.Value.ToString("yyyyMMdd"), dtpHasta.Value.ToString("yyyyMMdd"));
        }

        private string primerValorCombobox(string textoCombo)
        {
            return textoCombo.Split('|')[0].TrimEnd();
        }
    }


}
