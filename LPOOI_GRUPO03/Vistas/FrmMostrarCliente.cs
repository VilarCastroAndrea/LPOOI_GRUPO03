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

        public void mostrarCliente(Cliente c)
        {
            txtDni.Text = c.Cli_DNI;
            txtNombre.Text = c.Cli_Nombre;
            txtApellido.Text = c.Cli_Apellido;
            txtDireccion.Text = c.Cli_Direccion;
            txtTelefono.Text = c.Cli_Telefono;
        }
    }
}
