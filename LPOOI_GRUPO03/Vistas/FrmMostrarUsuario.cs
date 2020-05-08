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
    public partial class FrmMostrarUsuario : Form
    {
        public FrmMostrarUsuario()
        {
            InitializeComponent();
            cargar();
        }
        public  void cargar()
        {
            cmbRoles.DisplayMember = "";
            cmbRoles.ValueMember = "rol_Codigo";
            cmbRoles.DataSource = TrabajoUsuario.listaRoles();
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.txtId.Text);
            FrmUsuario frmUsuario = new FrmUsuario();
            TrabajoUsuario.eliminarUsuario(id);
            MessageBox.Show("Usuario Eliminado");
        }
    }
}
