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



    public partial class FrmLogin : Form
    {

        private String cargarCapcha;

        

        public FrmLogin()
        {
            InitializeComponent();

            cargarCapcha = generarCapcha();

            lblCapcha.Text = cargarCapcha;
        }

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


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Boolean user = false;
            Usuario admin = new Usuario("admin", "admin", "admin", "Administrador");
            Usuario vendedor = new Usuario("vendedor", "vendedor", "vendedor", "Vendedor");
            Usuario auditor = new Usuario("audi", "audi","audi", "Auditor");
            FrmMain formMain = new FrmMain();
            FrmSistema frmSistema = new FrmSistema();
            formMain.lblNom.Text = txtUsuario.Text;




            if(txtUsuario.Text == admin.Usu_NombreUsuario && txtContra.Text == admin.Usu_Contraseña)
            {
                user = true;
            }
            else
            {
                if(txtUsuario.Text == vendedor.Usu_NombreUsuario && txtContra.Text == vendedor.Usu_Contraseña)
                {
                    user = true;
                }
                else
                {
                    if(txtUsuario.Text == auditor.Usu_NombreUsuario && txtContra.Text == auditor.Usu_Contraseña)
                    {
                        user = true;
                    }
                }
            }

            if (lblCapcha.Text == txtResultadoCapcha.Text)
            {

                if (user)
                {

                    this.Hide();
                    formMain.Show();
                }
                else
                {
                    MessageBox.Show("Datos de acceso incorrectos");
                }
            }
            else
            {
                MessageBox.Show("Capcha incorrecto");
            }




        }

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
