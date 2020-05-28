using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Vistas
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Llamada a sub formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmUsuario>().FirstOrDefault();
            FrmUsuario frmUsuario = form ?? new FrmUsuario();
            AddFormInPanel(frmUsuario);

            restringirAcceso();
        }

        /// <summary>
        /// Validacion de usuario
        /// </summary>
        public void restringirAcceso()
        {
            Form frmLogin = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmLogin);
            if (frmLogin != null)
            {
                if (((FrmLogin)frmLogin).user.Rol_Codigo == "1")
                {
                    btnCliente.Visible = false;
                }
                else if (((FrmLogin)frmLogin).user.Rol_Codigo == "2")
                {
                    btnVehiculos.Visible = false;
                }
            }

        }

        /// <summary>
        /// Muestra fecha y hora
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        /// <summary>
        /// Llamadas a formularios
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSistema_Click_1(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmUsuario>().FirstOrDefault();
            FrmUsuario frmUsuario = form ?? new FrmUsuario();
            AddFormInPanel(frmUsuario);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmCliente>().FirstOrDefault();
            FrmCliente fcliente = form ?? new FrmCliente();
            AddFormInPanel(fcliente);
        }

        private void btnVehiculos_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmVehiculo>().FirstOrDefault();
            FrmVehiculo fvehiculo = form ?? new FrmVehiculo();
            AddFormInPanel(fvehiculo);
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmVenta>().FirstOrDefault();
            FrmVenta fventa = form ?? new FrmVenta();
            AddFormInPanel(fventa);
        }

        /// <summary>
        /// Llamada a formulario
        /// </summary>
        /// <param name="fh"></param>
        private void AddFormInPanel(Form fh)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }

        /// <summary>
        /// Boton para deloguearse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta;
            respuesta = MessageBox.Show("Desea salir?", "Atención", MessageBoxButtons.YesNo);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

    }
}
