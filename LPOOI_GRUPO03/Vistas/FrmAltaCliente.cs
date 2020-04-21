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
    public partial class FrmAltaCliente : Form
    {
        
        public FrmAltaCliente()
        {
            InitializeComponent();
        }

        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (txtADNI.Text.Length == 8)
            {


                Cliente cliente = new Cliente(txtADNI.Text, txtANombre.Text, txtAApellido.Text, txtADireccion.Text, txtATelefono.Text);
                DialogResult result = MessageBox.Show("Los Datos ingresados son correctos? " + "\n" +
                                                       "DNI: " + cliente.Cli_DNI + "\n" +
                                                       "Nombre: " + cliente.Cli_Nombre + "\n" +
                                                       "Apellido: " + cliente.Cli_Apellido + "\n" +
                                                       "Direccion: " + cliente.Cli_Direccion + "\n" +
                                                       "Telefono: " + cliente.Cli_Telefono,
                                                      "Agregar Cliente", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    cliente = new Cliente();
                }

                else
                {
                    MessageBox.Show("Se cancelo el alta del cliente", "Cancelado");
                    result = new DialogResult();
                }
            }
            else
            {
                MessageBox.Show("DNI solo permite 8 digitos");
            }
            
        }

        private void txtADNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }

        private void txtANombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
        }

        private void txtAApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloLetra(e);
        }

        private void txtATelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.soloNumeros(e);
        }
    }
}
