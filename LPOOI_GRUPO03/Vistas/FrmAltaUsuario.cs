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
    public partial class FrmAltaUsuario : Form
    {
        public FrmAltaUsuario()
        {
            InitializeComponent();
         
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            Usuario nuevoUsu = new Usuario();
            Form frmUsuario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmUsuario);
            nuevoUsu.Usu_NombreUsuario = txtNombreUsuario.Text;
            nuevoUsu.Usu_Contraseña = txtPass.Text;
            nuevoUsu.Usu_ApellidoNombre = txtNombreApellidoUsuario.Text;
            nuevoUsu.Rol_Codigo = cmbRoles.Text;

            if (validarCampos() == false)
            {
                MessageBox.Show("Complete todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }

            else
            {
                DialogResult result = MessageBox.Show("Los Datos ingresados son correctos? " + "\n" +
                                                   "Nombre de Usuario: " + nuevoUsu.Usu_NombreUsuario + "\n" +
                                                   "Contraseña: " + nuevoUsu.Usu_Contraseña + "\n" +
                                                   "Nombre y Apellido: " + nuevoUsu.Usu_ApellidoNombre + "\n" +
                                                   "Rol: " + nuevoUsu.Rol_Codigo,
                                                  "Agregar Cliente", MessageBoxButtons.OKCancel);

                if (result == DialogResult.OK)
                {
                    TrabajoUsuario.AgregarUsuario(nuevoUsu);
                    ((FrmUsuario)frmUsuario).cargarListaUsuario();
                    limpiarCampos();
                    
                   
                }
                else
                {
                    MessageBox.Show("Se cancelo el alta del usuario", "Cancelado");
                    result = new DialogResult();
                }
            }











            
        }
        public void cargarRol()
        {

            cmbRoles.DisplayMember = "";
            cmbRoles.ValueMember = "rol_codigo";
            cmbRoles.DataSource = TrabajoUsuario.listaRoles();
        }

        private void FrmAltaUsuario_Load(object sender, EventArgs e)
        {
            cargarRol();
        }
        public bool validarCampos()
        {
            Boolean resultado = false;
            if(txtNombreUsuario.Text != "" && txtPass.Text != "" && txtNombreApellidoUsuario.Text != "" && cmbRoles.Text != "")
            {
                resultado = true;
            }
            return resultado;
        }


        public void limpiarCampos()
        {
            txtNombreUsuario.Text = "";
            txtPass.Text = "";
            txtNombreApellidoUsuario.Text = "";
            cmbRoles.Text="";
        }
    }
}
