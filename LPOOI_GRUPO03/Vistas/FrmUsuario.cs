﻿using System;
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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Muestra los datos necesarios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarUsuario>().FirstOrDefault();
            FrmMostrarUsuario frmMostrarUsuario = form ?? new FrmMostrarUsuario();
            AddFormInPanel(frmMostrarUsuario);

            listarUsuario();//Llama al metodo listar usuario
        }

        /// <summary>
        /// Llama a sub formulario
        /// </summary>
        /// <param name="fh"></param>
        private void AddFormInPanel(Form fh)
        {
            if (this.panelUsuario.Controls.Count > 0)
                this.panelUsuario.Controls.RemoveAt(0);
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelUsuario.Controls.Add(fh);
            this.panelUsuario.Tag = fh;
            fh.Show();
        }       

        /// <summary>
        /// Lista los usuario
        /// </summary>
        public void listarUsuario()
        {
            dgvListaUsuarios.DataSource = TrabajoUsuario.listarUsuario();
            dgvListaUsuarios.Refresh();
        }

        /// <summary>
        /// Llama al formulario AltaUsuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmAltaUsuario>().FirstOrDefault();
            FrmAltaUsuario frmAltaUsuario = form ?? new FrmAltaUsuario();
            AddFormInPanel(frmAltaUsuario);
        }

        /// <summary>
        /// Llamada al formulario mostrarUsuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrarUsuario_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarUsuario>().FirstOrDefault();
            FrmMostrarUsuario frmMostrarUsuario = form ?? new FrmMostrarUsuario();
            AddFormInPanel(frmMostrarUsuario);
        }

        /// <summary>
        /// Envia datos del dgv al formulario mostrarUsuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvListaUsuarios_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvListaUsuarios.CurrentRow != null)
            {
                FrmMostrarUsuario mu = new FrmMostrarUsuario();
                Form frmMostrarUsuario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmMostrarUsuario);
                if (frmMostrarUsuario != null)
                {
                    ((FrmMostrarUsuario)frmMostrarUsuario).btnActualizarUsuario.Enabled = false;
                    ((FrmMostrarUsuario)frmMostrarUsuario).txtId.Text = dgvListaUsuarios.CurrentRow.Cells["ID"].Value.ToString();
                    ((FrmMostrarUsuario)frmMostrarUsuario).txtNombreUsuario.Text = dgvListaUsuarios.CurrentRow.Cells["Nombre de Usuario"].Value.ToString();
                    ((FrmMostrarUsuario)frmMostrarUsuario).txtPass.Text = dgvListaUsuarios.CurrentRow.Cells["Contraseña"].Value.ToString();
                    ((FrmMostrarUsuario)frmMostrarUsuario).txtNombreApellidoUsuario.Text = dgvListaUsuarios.CurrentRow.Cells["Apellido y Nombre"].Value.ToString();
                    ((FrmMostrarUsuario)frmMostrarUsuario).cmbRoles.Text = dgvListaUsuarios.CurrentRow.Cells["Rol"].Value.ToString();

                }
            }
        }

        /// <summary>
        /// Formatea la contraseña
        /// </summary>
        /// <param name="contraseña"></param>
        /// <returns></returns>
        private string reemplazoContraseña(string contraseña)
        {
            string devolucion="";
            foreach(char a in contraseña)
            {
                devolucion = devolucion + "*";
            }
            return devolucion;
        }

        /// <summary>
        /// Busca a un usuario por nombre de usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtBuscarUsuario.Text != "")
            {
                dgvListaUsuarios.DataSource = TrabajoUsuario.buscarUsuario(txtBuscarUsuario.Text);
            }
            else
            {
                listarUsuario();
            }
        }
    }
}
