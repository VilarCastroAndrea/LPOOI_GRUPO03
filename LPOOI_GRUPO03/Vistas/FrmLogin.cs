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
using System.Data.SqlClient;

namespace Vistas
{



    public partial class FrmLogin : Form
    {

        private String cargarCapcha;
        FrmMain formMain = new FrmMain();
        FrmSistema frmSistema = new FrmSistema();


        public FrmLogin()
        {
            InitializeComponent();

            cargarCapcha = generarCapcha();

            lblCapcha.Text = cargarCapcha;
        }
        SqlConnection cnn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename=C:\Users\RENE\source\repos\LPOOI_GRUPO03\AgenciaDB.mdf;Integrated Security = True");


        public void ingresar(string user, string password)
        {

            try
            {
                cnn.Open();
                SqlCommand cmd = new SqlCommand("SELECT USU_NombreUsuario, ROL_Codigo FROM Usuario WHERE USU_NombreUsuario= @usuario AND USU_Password=@pswd",cnn);
                cmd.Parameters.AddWithValue("usuario", user);
                cmd.Parameters.AddWithValue("pswd", password);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dataTable = new DataTable();
                sda.Fill(dataTable);

                if (dataTable.Rows.Count == 1)
                {
                    this.Hide();
                    if (dataTable.Rows[0][1].ToString() == "admin")
                    {
                        formMain.Show();
                        formMain.lblNom.Text = dataTable.Rows[0][0].ToString();
                    }
                    else if (dataTable.Rows[0][1].ToString() == "vendedor")
                    {
                        formMain.Show();
                        formMain.lblNom.Text =  dataTable.Rows[0][0].ToString();
                    }
                    else if (dataTable.Rows[0][1].ToString() == "auditor")
                    {
                        formMain.Show();
                        formMain.lblNom.Text =  dataTable.Rows[0][0].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Datos de acceso incorrectos");
                }


            } catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                cnn.Close();
            }
        }



       // */




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
           ingresar(this.txtUsuario.Text, this.txtContra.Text);



          /*  Boolean user = false;
            Usuario admin = new Usuario("admin", "admin", "admin", "Administrador");
            Usuario vendedor = new Usuario("vendedor", "vendedor", "vendedor", "Vendedor");
            Usuario auditor = new Usuario("audi", "audi","audi", "Auditor");
           
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

    
    */

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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lblCapcha_Click(object sender, EventArgs e)
        {

        }
    }
}
