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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarCliente>().FirstOrDefault();
            FrmMostrarCliente frmMostrarCliente = form ?? new FrmMostrarCliente();
            AddFormInPanel(frmMostrarCliente);

            cargarCliente();
        }

        private void btnACliente_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmAltaCliente>().FirstOrDefault();
            FrmAltaCliente frmAltaCliente = form ?? new FrmAltaCliente();
            AddFormInPanel(frmAltaCliente);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarCliente>().FirstOrDefault();
            FrmMostrarCliente frmMostrarCliente = form ?? new FrmMostrarCliente();
            AddFormInPanel(frmMostrarCliente);
        }

        private void AddFormInPanel(Form fh)
        {
            if (this.panelCliente.Controls.Count > 0)
                this.panelCliente.Controls.RemoveAt(0);
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelCliente.Controls.Add(fh);
            this.panelCliente.Tag = fh;
            fh.Show();
        }

        public void cargarCliente()
        {
            dataCliente.DataSource = TrabajarCliente.ListaCliente();
        }

        private void btnBusacar_Click(object sender, EventArgs e)
        {
            if(txtBuscarC.Text != "")
            {
                dataCliente.DataSource = TrabajarCliente.buscarCliente(txtBuscarC.Text);
            }
            else
            {
                cargarCliente();
            }
        }

        private void dataCliente_CurrentCellChanged(object sender, EventArgs e)
        {
            if( dataCliente.CurrentRow != null )
            {
                FrmMostrarCliente mc = new FrmMostrarCliente();
                Cliente c = new Cliente();
                c.Cli_DNI = dataCliente.CurrentRow.Cells["Dni"].Value.ToString();
                c.Cli_Nombre = dataCliente.CurrentRow.Cells["Nombre"].Value.ToString();
                c.Cli_Apellido = dataCliente.CurrentRow.Cells["Apellido"].Value.ToString();
                c.Cli_Direccion = dataCliente.CurrentRow.Cells["Direccion"].Value.ToString();
                c.Cli_Telefono = dataCliente.CurrentRow.Cells["Telefono"].Value.ToString();
                mc.mostrarCliente(c);
                txtMuestra.Text = dataCliente.CurrentRow.Cells["Dni"].Value.ToString();
                this.Refresh();
            }
        }

        private void dataCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
