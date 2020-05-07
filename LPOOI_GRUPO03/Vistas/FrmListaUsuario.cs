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
    public partial class FrmListaUsuario : Form
    {
        public FrmListaUsuario()
        {
            InitializeComponent();
            cargarListaUsuario();
           
        }
    

    public void cargarListaUsuario()
    {

            dgvListaUsuarios.DataSource = TrabajarUsuario.ListaCliente();
            dgvListaUsuarios.Refresh();
    }





        private void dgvListaUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int IdBuscar = 0;


            SqlConnection cn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Luis\\source\\repos\\LPOOI_GRUPO03\\AgenciaDB.mdf; Integrated Security = True; Connect Timeout = 30");

            //Crear el comando
            SqlCommand cmd = new SqlCommand("SELECT * FROM rol", cn);

            //Crear el DataReader
            SqlDataReader dr;

            //Abrir la Conexión
            cn.Open();

            //Cargar el DataReader con el resultado de la Consulta
            dr = cmd.ExecuteReader();

            //Cargar el control (comboBox) con el contenido del DataReader
            while (dr.Read())
            {
                if(cmbRol.SelectedIndex == -1)
                {
                    cmbRol.Items.Add(dr["ROL_Codigo"]);
                }
               
            }
            //Cerrar el DataReader
            dr.Close();

            //Cerrar la Conexión a la DB
            cn.Close();


            cmbRol.Refresh();

            txtId.Text= dgvListaUsuarios.CurrentRow.Cells[0].Value.ToString();
            IdBuscar = Convert.ToInt32(txtId.Text);
            txtNombreUsuario.Text = dgvListaUsuarios.CurrentRow.Cells[1].Value.ToString();
            txtPass.Text= dgvListaUsuarios.CurrentRow.Cells[2].Value.ToString();
            txtNombreApellidoUsuario.Text= dgvListaUsuarios.CurrentRow.Cells[3].Value.ToString();
            cmbRol.SelectedItem= dgvListaUsuarios.CurrentRow.Cells[4].Value.ToString();
            
            


        }

        private void txtId_TextChanged(object sender, EventArgs e)
        {

            
        }

        private void txtNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            
                if (txtNombreUsuario.Text != dgvListaUsuarios.CurrentRow.Cells[1].Value.ToString())
            {
                btnActualizarUsuario.Enabled = true;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text != dgvListaUsuarios.CurrentRow.Cells[2].Value.ToString())
            {
                btnActualizarUsuario.Enabled = true;
            }
        }

        private void txtNombreApellidoUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreApellidoUsuario.Text != dgvListaUsuarios.CurrentRow.Cells[3].Value.ToString())
            {
                btnActualizarUsuario.Enabled = true;
            }
        }

        private void cmbRol_TextChanged(object sender, EventArgs e)
        {
            String auxiliar = cmbRol.SelectedText;
            if (auxiliar!= dgvListaUsuarios.CurrentRow.Cells[4].Value.ToString())
            {


                btnActualizarUsuario.Enabled = true;
            }
        }

        private void cmbRol_Click(object sender, EventArgs e)
        {
            String auxiliar = cmbRol.SelectedText;
            if (auxiliar != dgvListaUsuarios.CurrentRow.Cells[4].Value.ToString())
            {


                cmbRol_TextChanged(sender, e);
        
                  
            }
        }
    }
}
