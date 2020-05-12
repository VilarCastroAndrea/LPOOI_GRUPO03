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
    public partial class FrmListaVenta : Form
    {
        public FrmListaVenta()
        {
            InitializeComponent();
        }

        private void FrmListaVenta_Load(object sender, EventArgs e)
        {
           dataVentas.DataSource = TrabajarVentas.listaVentas();
        }

    }
}
