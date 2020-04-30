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


        public Boolean validarCamposCliente(Cliente xCliente)
        {
            bool respuesta = false;

            if (xCliente.Cli_DNI != "" && xCliente.Cli_Nombre != "" && xCliente.Cli_Apellido != "" && xCliente.Cli_Direccion != "" && xCliente.Cli_Telefono != "")
            {
                respuesta = true;
            }
     
            return respuesta;

        }


        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (txtADNI.Text.Length == 8 )
            {

                
                Cliente cliente = new Cliente(txtADNI.Text, txtANombre.Text, txtAApellido.Text, txtADireccion.Text, txtATelefono.Text);


                if (validarCamposCliente(cliente) == false)
                {
                    MessageBox.Show("Complete todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Question);




                }

                else
                {

               
                DialogResult result = MessageBox.Show("Los Datos ingresados son correctos? " + "\n" +
                                                       "DNI: " + cliente.Cli_DNI + "\n" +
                                                       "Nombre: " + cliente.Cli_Nombre + "\n" +
                                                       "Apellido: " + cliente.Cli_Apellido + "\n" +
                                                       "Direccion: " + cliente.Cli_Direccion + "\n" +
                                                       "Telefono: " + cliente.Cli_Telefono,
                                                      "Agregar Cliente", MessageBoxButtons.OKCancel);


                if (result == DialogResult.OK)
                {
                    listaDeClientes.Add(cliente);

                    txtADNI.Text = "";
                    txtANombre.Text = "";
                    txtAApellido.Text = "";
                    txtADireccion.Text = "";
                    txtATelefono.Text = "";

                    Form frmListaCliente = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmListaCliente);
                    if (frmListaCliente != null)
                    {
                        ((FrmListaCliente)frmListaCliente).dataCliente.DataSource = null;
                        ((FrmListaCliente)frmListaCliente).dataCliente.DataSource = listaDeClientes;
                    }

                }

                else
                {
                    MessageBox.Show("Se cancelo el alta del cliente", "Cancelado" );
                    result = new DialogResult();
                }
            }
            }
            else
            {
                MessageBox.Show("Ingrese un DNI valido");
            }

        }


    private void txtADNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
            txtADNI.MaxLength = 8;
        }

        private void txtANombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
        }

        private void txtAApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
        }

        private void txtATelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }
    }
}
