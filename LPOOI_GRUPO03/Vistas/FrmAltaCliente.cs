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
    public partial class FrmAltaCliente : Form
    {

        public FrmAltaCliente()
        {
            InitializeComponent();
        }
        public List<Cliente> listaDeClientes = new List<Cliente>();

        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnACliente_Click(object sender, EventArgs e)
        {
            if (txtDni.Text.Length == 8)
            {
                Cliente aCliente = new Cliente();

                aCliente.Cli_DNI = txtDni.Text;
                aCliente.Cli_Nombre = txtNombre.Text;
                aCliente.Cli_Apellido = txtApellido.Text;
                aCliente.Cli_Direccion = txtDireccion.Text;
                aCliente.Cli_Telefono = txtTelefono.Text;

                if (validarCamposCliente(aCliente) == false)
                {
                    MessageBox.Show("Complete todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Question);
                }
                else
                {
                    DataTable dtCliente = new DataTable();
                    dtCliente = TrabajarCliente.buscarCliente(aCliente.Cli_DNI);
                    if (dtCliente.Rows.Count == 0)
                    {



                        DialogResult result = MessageBox.Show("Los Datos ingresados son correctos? " + "\n" +
                                                           "DNI: " + aCliente.Cli_DNI + "\n" +
                                                           "Nombre: " + aCliente.Cli_Nombre + "\n" +
                                                           "Apellido: " + aCliente.Cli_Apellido + "\n" +
                                                           "Direccion: " + aCliente.Cli_Direccion + "\n" +
                                                           "Telefono: " + aCliente.Cli_Telefono,
                                                          "Agregar Cliente", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            Form frmCliente = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmCliente);
                            if (frmCliente != null)
                            {
                                TrabajarCliente.InsertarCliente(aCliente);
                                limpiarCampos();
                                ((FrmCliente)frmCliente).cargarCliente();
                            }
                        }
                    
                    else
                    {
                        MessageBox.Show("Se cancelo el alta del cliente", "Cancelado");
                        result = new DialogResult();
                    }
                }else
                {
                    MessageBox.Show("El Cliente ya existe");
                }
                }
            }

            else
            {
                MessageBox.Show("Ingrese un DNI valido");
            }
        }

        public Boolean validarCamposCliente(Cliente xCliente)
        {
            bool respuesta = false;
            if (xCliente.Cli_DNI != "" && xCliente.Cli_Nombre != "" && xCliente.Cli_Apellido != "" && xCliente.Cli_Direccion != "" && xCliente.Cli_Telefono != "")
            {
                respuesta = true;
            }
            return respuesta;
        }

        private void limpiarCampos()
        {
            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }

        private void txtDni_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
            txtDni.MaxLength = 8;
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
