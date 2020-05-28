using ClasesBase;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmAltaUsuario : Form
    {
        public FrmAltaUsuario()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Muestra los datos necesarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmAltaUsuario_Load(object sender, EventArgs e)
        {
            cargarRol();
        }

        /// <summary>
        /// Agrega y valida a un nuevo usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            Form frmUsuario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmUsuario);
            DataTable userX = new DataTable();
            userX = TrabajoUsuario.buscarUsuario(txtNombreUsuario.Text);
            if (userX.Rows.Count == 0)
            {
                if (mensaje(cargarDatos()) == DialogResult.OK)
                {
                    TrabajoUsuario.AgregarUsuario(cargarDatos());
                    ((FrmUsuario)frmUsuario).listarUsuario();
                    limpiarCampos();
                }
                else
                {
                    MessageBox.Show("Se cancelo el alta del usuario", "Cancelado");
                }
            }
            else
            {
                MessageBox.Show("Usuario ya existente, ingrese otro nombre de usuario");
            }
        }

        /// <summary>
        /// Carga los datos de los box a un objeto
        /// </summary>
        public Usuario cargarDatos()
        {
            Usuario nuevoUsu = new Usuario();
            if (validarCampos() != false)
            {
                nuevoUsu.Usu_NombreUsuario = txtNombreUsuario.Text;
                nuevoUsu.Usu_Contraseña = txtPass.Text;
                nuevoUsu.Usu_ApellidoNombre = txtNombreApellidoUsuario.Text;
                nuevoUsu.Rol_Codigo = valorRol();
            }
            else
            {
                MessageBox.Show("Complete todos los campos", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
            return nuevoUsu;
        }

        /// <summary>
        /// Muestra los datos cargados en un mensaje para confirmar
        /// </summary>
        /// <param name="nuevoUsu"></param>
        /// <returns></returns>
        public DialogResult mensaje(Usuario nuevoUsu)
        {
            DialogResult result = MessageBox.Show("Los Datos ingresados son correctos? " + "\n" +
                                                         "Nombre de Usuario: " + nuevoUsu.Usu_NombreUsuario + "\n" +
                                                         "Contraseña: " + nuevoUsu.Usu_Contraseña + "\n" +
                                                         "Nombre y Apellido: " + nuevoUsu.Usu_ApellidoNombre + "\n" +
                                                         "Rol: " + nuevoUsu.Rol_Codigo,
                                                         "Agregar Cliente", MessageBoxButtons.OKCancel);
            return result;
        }

        /// <summary>
        /// Devuelve una lista de roles
        /// </summary>
        public void cargarRol()
        {
            cmbRoles.DisplayMember = "";
            cmbRoles.ValueMember = "rol_Descripcion";
            cmbRoles.DataSource = TrabajoUsuario.listaRoles();
        }

        private string valorRol()
        {
            string idRol;
            if (cmbRoles.Text.Equals("Auditor"))
            {
                idRol = "3";
            }
            else
            {
                if (cmbRoles.Text.Equals("Vendedor"))
                {
                    idRol = "2";
                }
                else
                {
                    idRol = "1";
                }
            }
            return idRol;
        }

        /// <summary>
        /// Valida los campos
        /// </summary>
        public bool validarCampos()
        {
            Boolean resultado = false;
            if (txtNombreUsuario.Text != "" && txtPass.Text != "" && txtNombreApellidoUsuario.Text != "" && cmbRoles.Text != "")
            {
                resultado = true;
            }
            return resultado;
        }

        /// <summary>
        /// Limpia los campos
        /// </summary>
        public void limpiarCampos()
        {
            txtNombreUsuario.Text = "";
            txtPass.Text = "";
            txtNombreApellidoUsuario.Text = "";
            cmbRoles.Text = "";
        }
    }
}
