using ClasesBase;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmMostrarCliente : Form
    {

        public FrmMostrarCliente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// MOdifica al cliente seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Elimina al cliente seleccionado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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


        /// <summary>
        /// Validaciones de campo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
