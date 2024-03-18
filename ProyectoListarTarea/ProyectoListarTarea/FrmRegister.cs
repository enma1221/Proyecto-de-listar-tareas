using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoListarTarea
{
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();


        }

        // aqui instansiamos la conexion a la base de datos'
        SqlConnection conexion = new SqlConnection("server = LAPTOP-7O066IED\\SQLEXPRESS; database = TareaLista; integrated security = true");


        //boton parar registrarse en la base de datos
        private void btnRegistroNew_Click(object sender, EventArgs e)
        {
            //variables para el usuario

            String usuario = txtUserNew.Text;
            String contra = txtPassNew.Text;
            String contraConfirm = txtpassconfirm.Text;



            conexion.Open();


            if (contra == contraConfirm)
            {
            SqlCommand comando = new SqlCommand("insert into [dbo].[TablaDeUsuarios](usuario, contrasena) values('" + usuario + "', '"+ contra + "')", conexion);

            comando.ExecuteNonQuery();

            this.Hide();

            Login login = new Login();

            login.Show();
            }
            else
            {
                MessageBox.Show("Su contrasena no es la correcta");
            }

            conexion.Close();

        }

        private void FrmRegister_Load(object sender, EventArgs e)
        {

        }

        private void txtconfirm_TextChanged(object sender, EventArgs e)
        {

        }
        //pivturebox para cerrar el programa 

        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //pivturebox para maximizar el programa 

        private void pictureBoxMax_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBoxMax.Visible = false;
            pictureBoxRes.Visible = true;
        }
        //pivturebox para minimizar el programa 

        private void pictureBoxMin_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }
        //pivturebox para restaurar el programa 

        private void pictureBoxRes_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBoxRes.Visible = false;
            pictureBoxMax.Visible = true;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Login login = new Login();

            this.Hide();

            login.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
