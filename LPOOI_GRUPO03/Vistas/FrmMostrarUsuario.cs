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
       public String rol = "";
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

            String result;
            String msj = "Esta seguro que quiere elimnar el Usuario " + this.txtNombreUsuario.Text;


            int id = Convert.ToInt32(this.txtId.Text);

            DialogResult dialogResult = MessageBox.Show(msj , "Some Title", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

            


            Form frmUsuario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmUsuario);
            TrabajoUsuario.eliminarUsuario(id);
           
            ((FrmUsuario)frmUsuario).cargarListaUsuario();
            MessageBox.Show("Usuario Eliminado");
            }

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

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            btnActualizarUsuario.Enabled = true;
        }

        private void txtNombreApellidoUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            btnActualizarUsuario.Enabled = true;
        }

        private void cmbRoles_MouseCaptureChanged(object sender, EventArgs e)
        {
           
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rol != cmbRoles.Text)
            {
                btnActualizarUsuario.Enabled = true;
            }
           
        }
    }
}
