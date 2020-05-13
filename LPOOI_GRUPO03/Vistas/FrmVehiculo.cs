using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
