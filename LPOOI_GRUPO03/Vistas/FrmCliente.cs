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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmListaCliente>().FirstOrDefault();
            FrmListaCliente frmLista = form ?? new FrmListaCliente();
            AddFormInPanel(frmLista);
        }

        private void AddFormInPanel(Form fh)
        {
            if (this.panelContenedor2.Controls.Count > 0)
                this.panelContenedor2.Controls.RemoveAt(0);
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor2.Controls.Add(fh);
            this.panelContenedor2.Tag = fh;
            fh.Show();
        }

        private void btnAltaCliente_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmAltaCliente>().FirstOrDefault();
            FrmAltaCliente frmAltaCliente = form ?? new FrmAltaCliente();
            AddFormInPanel(frmAltaCliente);
        }

        private void btnListaCliente_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmListaCliente>().FirstOrDefault();
            FrmListaCliente frmLista = form ?? new FrmListaCliente();
            AddFormInPanel(frmLista);
        }
    }
}
