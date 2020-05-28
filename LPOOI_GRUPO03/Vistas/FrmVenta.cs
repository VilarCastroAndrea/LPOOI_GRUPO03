using ClasesBase;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmVenta : Form
    {
        public FrmVenta()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Carga las ventas y sub formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Carga dgv con una lista de ventas
        /// </summary>
        public void cargarVentas()
        {
            dataVenta.DataSource = TrabajarVentas.listaVenta();
        }

        /// <summary>
        /// Llama a sub formulario
        /// </summary>
        /// <param name="fh"></param>
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

        /// <summary>
        /// Llama al formulario registrar venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmRegistrarVenta>().FirstOrDefault();
            FrmRegistrarVenta frmRegistrarVenta = form ?? new FrmRegistrarVenta();
            AddFormInPanel(frmRegistrarVenta);
        }

        /// <summary>
        /// Llama al formulario mostrar venta
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /*private void btnMostrar_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarVenta>().FirstOrDefault();
            FrmMostrarVenta frmVenta = form ?? new FrmMostrarVenta();
            AddFormInPanel(frmVenta);
        }*/

        /// <summary>
        /// Carga una lista con clientes
        /// </summary>
        /// <param name="tablaCliente"></param>
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

        /// <summary>
        /// Carga una lisra de marca
        /// </summary>
        /// <param name="tablaVehiculo"></param>
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


        private void btnBusacar_Click(object sender, EventArgs e)
        {
            dataVenta.DataSource = TrabajarVentas.buscarVenta(cmbMarca.Text, primerValorCombobox(cmbClientes.Text), dtpDesde.Value, dtpHasta.Value);
        }

        private string primerValorCombobox(string textoCombo)
        {
            return textoCombo.Split('|')[0].TrimEnd();
        }

    }

}
