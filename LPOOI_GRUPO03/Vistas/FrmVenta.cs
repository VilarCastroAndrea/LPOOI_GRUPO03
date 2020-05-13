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



            var form = Application.OpenForms.OfType<FrmListaVenta>().FirstOrDefault();
            FrmListaVenta frmLista = form ?? new FrmListaVenta();
            AddFormInPanel(frmLista);
        }
        private void AddFormInPanel(Form fh)
        {
            if (this.panelContenedorListaVentas.Controls.Count > 0)
                this.panelContenedorListaVentas.Controls.RemoveAt(0);
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedorListaVentas.Controls.Add(fh);
            this.panelContenedorListaVentas.Tag = fh;
            fh.Show();
        }

        private void btnListaVenta_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmListaVenta>().FirstOrDefault();
            FrmListaVenta frmLista = form ?? new FrmListaVenta();
            AddFormInPanel(frmLista);
        }

        private void btnListaVeh_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmListaVenta>().FirstOrDefault();
            FrmListaVenta frmLista = form ?? new FrmListaVenta();
            AddFormInPanel(frmLista);
        }

        private void btnRegistrarVenta_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmRegistrarVenta>().FirstOrDefault();
            FrmRegistrarVenta frmRegistrarVenta = form ?? new FrmRegistrarVenta();
            AddFormInPanel(frmRegistrarVenta);
        }

        private void FrmVenta_Load_1(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmListaVenta>().FirstOrDefault();
            FrmListaVenta frmLista = form ?? new FrmListaVenta();
            AddFormInPanel(frmLista);
        }
    }


}
