﻿using ClasesBase;
using System;
using System.Data;
using System.Windows.Forms;

namespace Vistas
{

    public partial class FrmLogin : Form
    {
        FrmMain formMain = new FrmMain();
        private int intentos;
        public Usuario user = new Usuario();

        public FrmLogin()
        {
            InitializeComponent();
            intentos = 0;
            ocultarCapcha();
        }

        /// <summary>
        /// Muestra el capcha 
        /// </summary>
        private void mostrarCapcha()
        {
            imgCapcha.Visible = true;
            txtResultadoCapcha.Visible = true;
            lblCapcha.Visible = true;
            lblCapcha.Text = generarCapcha();
        }

        /// <summary>
        /// Oculta capcha
        /// </summary>
        private void ocultarCapcha()
        {
            imgCapcha.Visible = false;
            txtResultadoCapcha.Visible = false;
            lblCapcha.Visible = false;
        }

        /// <summary>
        /// Random de capcha
        /// </summary>
        /// <returns></returns>
        public String generarCapcha()
        {

            Random rdm = new Random();
            int opcion = rdm.Next(0, 5);
            String resultado = null;
            String[] capcha;
            capcha = new string[5];

            capcha[0] = "AuTmcK";
            capcha[1] = "bdpXAa";
            capcha[2] = "aniycp";
            capcha[3] = "MkpatW";
            capcha[4] = "ertyui";

            resultado = capcha[opcion];

            return resultado;
        }

        /// <summary>
        /// Login
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (intentos < 5)
            {
                ingresar();
            }
            else
            {
                if (lblCapcha.Text == txtResultadoCapcha.Text)
                {
                    ingresar();
                }
                else
                {
                    MessageBox.Show("Capcha incorrecto");
                    lblCapcha.Text = generarCapcha();
                }
            }
        }

        private void ingresar()
        {
            DataTable dataTable = new DataTable();
            dataTable = TrabajoUsuario.ingresar(txtUsuario.Text, txtContra.Text);
            if (dataTable.Rows.Count != 0)
            {
                guardarUser(dataTable);
                if ((user.Usu_NombreUsuario == txtUsuario.Text) && (user.Usu_Contraseña == txtContra.Text))
                {
                    this.Hide();
                    formMain.lblNom.Text = "BIENVENIDO: " + user.Usu_NombreUsuario;
                    formMain.Show();
                }

            }
            else
            {
                intentos++;
                intentosMaximos();
                MessageBox.Show("Datos incorrectos");
            }
        }

        /// <summary>
        /// Mostrara el capcha despues de 4 intentos fallidos
        /// </summary>
        private void intentosMaximos()
        {
            if (intentos > 4)
            {
                mostrarCapcha();
            }
        }

        /// <summary>
        /// Guarda usuario logueado
        /// </summary>
        /// <param name="dt"></param>
        private void guardarUser(DataTable dt)
        {
            user.Usu_NombreUsuario = dt.Rows[0]["Nombre de Usuario"].ToString();
            user.Usu_Contraseña = dt.Rows[0]["Contraseña"].ToString();
            user.Usu_ApellidoNombre = dt.Rows[0]["Apellido y Nombre"].ToString();
            user.Rol_Codigo = dt.Rows[0]["Rol"].ToString();
            user.Usu_ID = Convert.ToInt32(dt.Rows[0]["ID"].ToString());
        }

        /// <summary>
        /// MouseHover
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtUsuario_MouseHover(object sender, EventArgs e)
        {
            lblnfoUsu.Text = "Ingresar Usuario";
        }

        private void txtUsuario_MouseLeave(object sender, EventArgs e)
        {
            lblnfoUsu.Text = " ";
        }

        private void txtContra_MouseHover(object sender, EventArgs e)
        {
            lblInfoContra.Text = "Ingrese Contraseña";
        }

        private void txtContra_MouseLeave(object sender, EventArgs e)
        {
            lblInfoContra.Text = " ";
        }

    }
}
