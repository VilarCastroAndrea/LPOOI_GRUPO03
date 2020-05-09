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

      

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.txtId.Text);
            Form frmUsuario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmUsuario);
            TrabajoUsuario.eliminarUsuario(id);
           
            ((FrmUsuario)frmUsuario).cargarListaUsuario();
            MessageBox.Show("Usuario Eliminado");
           
        }

        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            Form frmUsuario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmUsuario);

            Usuario usuario = new Usuario();
               
                usuario.Usu_ID = Convert.ToInt32(this.txtId.Text);
                usuario.Usu_NombreUsuario = txtNombreUsuario.Text;
                usuario.Usu_Contraseña = txtPass.Text;
                usuario.Usu_ApellidoNombre = txtNombreApellidoUsuario.Text;
                usuario.Rol_Codigo = cmbRoles.Text;
                TrabajoUsuario.modificarUsuario(usuario);
            ((FrmUsuario)frmUsuario).cargarListaUsuario();
            MessageBox.Show("Usuario Modificado");
                

            
        }

        private void FrmMostrarUsuario_Load(object sender, EventArgs e)
        {
            Form frmUsuario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmUsuario);
        }
    }
}
