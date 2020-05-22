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
    public partial class FrmVehiculo : Form
    {
        public FrmVehiculo()
        {
            InitializeComponent();
        }

        private void FrmVehiculo_Load(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarVehiculo>().FirstOrDefault();
            FrmMostrarVehiculo frmLista = form ?? new FrmMostrarVehiculo();
            AddFormInPanel(frmLista);
            dataVehiculo.DataSource = TrabajarVehiculo.ListaVehiculo();
            dataVehiculo.Refresh();
        }

        private void AddFormInPanel(Form fh)
        {
            if (this.panelVehiculo.Controls.Count > 0)
                this.panelVehiculo.Controls.RemoveAt(0);
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelVehiculo.Controls.Add(fh);
            this.panelVehiculo.Tag = fh;
            fh.Show();
        }

        private void btnListaVeh_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarVehiculo>().FirstOrDefault();
            FrmMostrarVehiculo frmLista = form ?? new FrmMostrarVehiculo();
            AddFormInPanel(frmLista);
        }

        private void btnAVeh_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmAltaVehiculo>().FirstOrDefault();
            FrmAltaVehiculo frmAltaVehi = form ?? new FrmAltaVehiculo();
            AddFormInPanel(frmAltaVehi);
        }

        private void dataVehiculo_CurrentCellChanged(object sender, EventArgs e)
        {
            if (this.dataVehiculo.CurrentRow != null) {
                FrmMostrarVehiculo frmMosVehiculo = new FrmMostrarVehiculo();
                Form frmMostrarVehiculo = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmMostrarVehiculo);
                if (frmMostrarVehiculo != null) {
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).txtAMatricula.Text = dataVehiculo.CurrentRow.Cells[0].Value.ToString();
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).txtAMarca.Text = dataVehiculo.CurrentRow.Cells[1].Value.ToString();
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).txtALinea.Text = dataVehiculo.CurrentRow.Cells[2].Value.ToString();
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).cmbModelo.Text = dataVehiculo.CurrentRow.Cells[3].Value.ToString();
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).cmbColor.Text = dataVehiculo.CurrentRow.Cells[4].Value.ToString();
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).cmbCantPuert.Text = dataVehiculo.CurrentRow.Cells[5].Value.ToString();
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).cGps.Checked = dataVehiculo.CurrentRow.Cells[6].Selected;
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).txtATipo.Text = dataVehiculo.CurrentRow.Cells[7].Value.ToString();
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).txtAClase.Text = dataVehiculo.CurrentRow.Cells[8].Value.ToString();
                    ((FrmMostrarVehiculo)frmMostrarVehiculo).txtAPrecio.Text = dataVehiculo.CurrentRow.Cells[9].Value.ToString();
                }
            }
        }

        private void btnBusacar_Click(object sender, EventArgs e)
        {
            string buscarvehiculo = txtBuscarVehiculo.Text;
            if (txtBuscarVehiculo.Text != "")
            {
                dataVehiculo.DataSource = TrabajarVehiculo.buscarVehiculo(txtBuscarVehiculo.Text);
            }
            else
            {
                dataVehiculo.DataSource = TrabajarVehiculo.ListaVehiculo();
                dataVehiculo.Refresh();
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
           
            if (rbtnMarca.Checked==true)
            {
                dataVehiculo.DataSource = TrabajarVehiculo.ordenarVporMarca();
            }
            else if (rbtnLinea.Checked==true)
            {
                dataVehiculo.DataSource = TrabajarVehiculo.ordenarVporLinea();
            }
        }

        }
    }
}
