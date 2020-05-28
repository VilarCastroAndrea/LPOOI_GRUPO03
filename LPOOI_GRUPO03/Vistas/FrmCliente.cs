using ClasesBase;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Llamadas a carga de datos y sub formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCliente_Load(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarCliente>().FirstOrDefault();
            FrmMostrarCliente frmMostrarCliente = form ?? new FrmMostrarCliente();
            AddFormInPanel(frmMostrarCliente);

            cargarCliente();
        }

        /// <summary>
        /// Llama a formulario alta Cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnACliente_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmAltaCliente>().FirstOrDefault();
            FrmAltaCliente frmAltaCliente = form ?? new FrmAltaCliente();
            AddFormInPanel(frmAltaCliente);
        }

        /// <summary>
        /// Llama a formulario mostrar cliente
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnMostrar_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarCliente>().FirstOrDefault();
            FrmMostrarCliente frmMostrarCliente = form ?? new FrmMostrarCliente();
            AddFormInPanel(frmMostrarCliente);
        }

        /// <summary>
        /// Llamada a sub frmulario
        /// </summary>
        /// <param name="fh"></param>
        private void AddFormInPanel(Form fh)
        {
            if (this.panelCliente.Controls.Count > 0)
                this.panelCliente.Controls.RemoveAt(0);
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelCliente.Controls.Add(fh);
            this.panelCliente.Tag = fh;
            fh.Show();
        }

        /// <summary>
        /// Carga de clietes
        /// </summary>
        public void cargarCliente()
        {
            dataCliente.DataSource = TrabajarCliente.ListaCliente();
        }

        /// <summary>
        /// Carga el dgv
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataCliente_CurrentCellChanged(object sender, EventArgs e)
        {
            if (dataCliente.CurrentRow != null)
            {
                FrmMostrarCliente mc = new FrmMostrarCliente();
                Form frmMostrarCliente = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmMostrarCliente);
                if (frmMostrarCliente != null)
                {
                    ((FrmMostrarCliente)frmMostrarCliente).txtDni.Text = dataCliente.CurrentRow.Cells["Dni"].Value.ToString();
                    ((FrmMostrarCliente)frmMostrarCliente).txtNombre.Text = dataCliente.CurrentRow.Cells["Nombre"].Value.ToString();
                    ((FrmMostrarCliente)frmMostrarCliente).txtApellido.Text = dataCliente.CurrentRow.Cells["Apellido"].Value.ToString();
                    ((FrmMostrarCliente)frmMostrarCliente).txtDireccion.Text = dataCliente.CurrentRow.Cells["Direccion"].Value.ToString();
                    ((FrmMostrarCliente)frmMostrarCliente).txtTelefono.Text = dataCliente.CurrentRow.Cells["Telefono"].Value.ToString();
                }
            }
        }

        /// <summary>
        /// Acomoda la lista cliente por apellido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOrdenApellido_Click(object sender, EventArgs e)
        {
            dataCliente.DataSource = TrabajarCliente.ListaClientesPorApellido();
            dataCliente.Refresh();
        }

        /// <summary>
        /// Boton buscar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (txtBuscarC.Text != "")
            {
                dataCliente.DataSource = TrabajarCliente.buscarCliente(txtBuscarC.Text);
            }
            else
            {
                cargarCliente();
            }
        }
    }
}
