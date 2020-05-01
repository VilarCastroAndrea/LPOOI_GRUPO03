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
    public partial class FrmSistema : Form
    {
        public FrmSistema()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmListaUsuario listaUsuario = new FrmListaUsuario();
            listaUsuario.Visible = true;
            
        }
    }
}
