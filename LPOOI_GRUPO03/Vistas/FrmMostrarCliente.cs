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
    public partial class FrmMostrarCliente : Form
    {
       
        public FrmMostrarCliente()
        {
            InitializeComponent();
        }

        private void btnMCliente_Click(object sender, EventArgs e)
        {
            Cliente c = new Cliente();

            Form frmCliente = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmCliente);
            if (frmCliente != null)
            {
                c.Cli_DNI = txtDni.Text;
                c.Cli_Nombre = txtNombre.Text;
                c.Cli_Apellido = txtApellido.Text;
                c.Cli_Direccion = txtDireccion.Text;
                c.Cli_Telefono = txtTelefono.Text;
                TrabajarCliente.modificarCliente(c);
                MessageBox.Show("Cliente Modificado");
                ((FrmCliente)frmCliente).cargarCliente();
            }

        }

        private void btnECliente_Click(object sender, EventArgs e)
        {
            Form frmCliente = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmCliente);
            if (frmCliente != null)
            {
                TrabajarCliente.eliminarCliente(txtDni.Text);
                MessageBox.Show("Cliente Eliminado");
                ((FrmCliente)frmCliente).cargarCliente();
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }
    }
}
