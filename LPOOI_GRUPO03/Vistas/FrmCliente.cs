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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarCliente>().FirstOrDefault();
            FrmMostrarCliente frmMostrarCliente = form ?? new FrmMostrarCliente();
            AddFormInPanel(frmMostrarCliente);

            cargarCliente();
        }

        private void btnACliente_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmAltaCliente>().FirstOrDefault();
            FrmAltaCliente frmAltaCliente = form ?? new FrmAltaCliente();
            AddFormInPanel(frmAltaCliente);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            var form = Application.OpenForms.OfType<FrmMostrarCliente>().FirstOrDefault();
            FrmMostrarCliente frmMostrarCliente = form ?? new FrmMostrarCliente();
            AddFormInPanel(frmMostrarCliente);
        }

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

        public void cargarCliente()
        {
            dataCliente.DataSource = TrabajarCliente.ListaCliente();
        }

        private void btnBusacar_Click(object sender, EventArgs e)
        {
            if(txtBuscarC.Text != "")
            {
                dataCliente.DataSource = TrabajarCliente.buscarCliente(txtBuscarC.Text);
            }
            else
            {
                cargarCliente();
            }
        }

        private void dataCliente_CurrentCellChanged(object sender, EventArgs e)
        {
            if( dataCliente.CurrentRow != null)
            {
                FrmMostrarCliente mc = new FrmMostrarCliente();

                //mc.txtDni.SelectedValue = dataCliente.CurrentRow.Cells["CLI_DNI"].Value.ToString();
                //mc.txtNombre.Text = dataCliente.CurrentRow.Cells["Nombre"].Value.ToString();
                //mc.txtApellido.Text = dataCliente.CurrentRow.Cells["Apellido"].Value.ToString();
            }
        }
    }
}
