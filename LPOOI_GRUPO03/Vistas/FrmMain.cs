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
using System.Data.SqlClient;

namespace Vistas
{
    public partial class FrmMain : Form
    {
           
      
          public FrmMain()
        {
            InitializeComponent();
        }



        private void FrmMain_Load(object sender, EventArgs e)
        {
            
            var form = Application.OpenForms.OfType<FrmSistema>().FirstOrDefault();
            FrmSistema frmSistema = form ?? new FrmSistema();
            AddFormInPanel(frmSistema);
            
            restringirAcceso();

        }
        public void restringirAcceso()
        {
            Form frmLogin = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FrmLogin);
            if (frmLogin != null)
            {
                if (((FrmLogin)frmLogin).user.Rol_Codigo == "Administrador")
                {
                    btnCliente.Visible = false;
                }
                else if (((FrmLogin)frmLogin).user.Rol_Codigo == "Vendedor")
                {
                    btnVehiculos.Visible = false;
                }
            }
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToLongTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

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
            var form = Application.OpenForms.OfType<FrmRegistrarVenta>().FirstOrDefault();
            FrmRegistrarVenta fventa = form ?? new FrmRegistrarVenta();
            AddFormInPanel(fventa);
        }

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
