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
            var form = Application.OpenForms.OfType<FrmMostrarVenta>().FirstOrDefault();
            FrmMostrarVenta frmVenta = form ?? new FrmMostrarVenta();
            AddFormInPanel(frmVenta);
            cargarVentas();
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

      
    }


}
