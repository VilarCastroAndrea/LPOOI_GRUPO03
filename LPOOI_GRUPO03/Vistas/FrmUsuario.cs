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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
        }

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

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarUsuario>().FirstOrDefault();
            FrmMostrarUsuario frmMostrarUsuario = form ?? new FrmMostrarUsuario();
            AddFormInPanel(frmMostrarUsuario);

           cargarListaUsuario();
        }

        public void cargarListaUsuario()
        {

            dgvListaUsuarios.DataSource = TrabajoUsuario.cargarUsuario();
            dgvListaUsuarios.Refresh();
        }

        private void btnBusacarUsuario_Click(object sender, EventArgs e)
        {
            string buscarUsuario = txtBuscarUsuario.Text ;


            if (txtBuscarUsuario.Text != "")
            {
                dgvListaUsuarios.DataSource = TrabajoUsuario.buscarUsuario(txtBuscarUsuario.Text);
            }
            else
            {
                cargarListaUsuario();
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmAltaUsuario>().FirstOrDefault();
            FrmAltaUsuario frmAltaUsuario = form ?? new FrmAltaUsuario();
            AddFormInPanel(frmAltaUsuario);
        }

        private void btnMostrarUsuario_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarUsuario>().FirstOrDefault();
            FrmMostrarUsuario frmMostrarUsuario = form ?? new FrmMostrarUsuario();
            AddFormInPanel(frmMostrarUsuario);
        }

        private void dgvListaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvListaUsuarios_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dgvListaUsuarios.CurrentRow != null)
            {
               
                FrmMostrarUsuario mu = new FrmMostrarUsuario();
                Form frmMostrarUsuario = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmMostrarUsuario);
                if (frmMostrarUsuario != null)
                {
                    ((FrmMostrarUsuario)frmMostrarUsuario).txtId.Text = dgvListaUsuarios.CurrentRow.Cells[0].Value.ToString();
                    ((FrmMostrarUsuario)frmMostrarUsuario).txtNombreUsuario.Text = dgvListaUsuarios.CurrentRow.Cells[1].Value.ToString();
                    ((FrmMostrarUsuario)frmMostrarUsuario).txtPass.Text = dgvListaUsuarios.CurrentRow.Cells[2].Value.ToString();
                    ((FrmMostrarUsuario)frmMostrarUsuario).txtNombreApellidoUsuario.Text = dgvListaUsuarios.CurrentRow.Cells[3].Value.ToString();
                    ((FrmMostrarUsuario)frmMostrarUsuario).cmbRoles.Text = dgvListaUsuarios.CurrentRow.Cells[4].Value.ToString();
                }
            }
        }
    }
}
