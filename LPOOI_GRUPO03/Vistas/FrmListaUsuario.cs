using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
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
            SqlConnection cn = new SqlConnection("Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\Luis\\source\\repos\\LPOOI_GRUPO03\\AgenciaDB.mdf; Integrated Security = True; Connect Timeout = 30");

            SqlDataAdapter da = new SqlDataAdapter();
            //crear el sqlCommand
            da.SelectCommand = new SqlCommand();
            //pasarle la conexion al Command del DataAdapter
            da.SelectCommand.Connection = cn;
            //indicar el nombre del stored procedure a llamar
            da.SelectCommand.CommandText = "ListarUsuarios";
            //Indicar de que tipo es el command
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            //correr el Stored procedure
            DataSet ds = new DataSet();
            da.Fill(ds, "Usuario");
            dgvListaUsuarios.DataSource = ds.Tables[0];
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



    }
}
