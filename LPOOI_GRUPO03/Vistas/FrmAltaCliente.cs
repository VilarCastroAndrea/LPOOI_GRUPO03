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

        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(txtADNI.Text, txtANombre.Text, txtAApellido.Text, txtADireccion.Text,txtATelefono.Text);
            DialogResult result = MessageBox.Show("Los Datos ingresados son correctos? " + "\n" + 
                                                   "DNI: " + cliente.Cli_DNI + "\n"+ 
                                                   "Nombre: " + cliente.Cli_Nombre +"\n" + 
                                                   "Apellido: " + cliente.Cli_Apellido + "\n" + 
                                                   "Direccion: " + cliente.Cli_Direccion + "\n" + 
                                                   "Telefono: " + cliente.Cli_Telefono, 
                                                   "Agregar Cliente", MessageBoxButtons.OKCancel);
            if (result == DialogResult.OK)
            {
                cliente = new Cliente();
            }
            else
            {
                MessageBox.Show("Se cancelo el alta del cliente", "Cancelado");
                result = new DialogResult();
            }
        }
        
    }
}
