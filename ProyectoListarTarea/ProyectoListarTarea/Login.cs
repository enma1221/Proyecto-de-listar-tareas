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

namespace ProyectoListarTarea
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        

        private void Login_Load(object sender, EventArgs e)
        {

        }
            //Boton para iniciar ssesion
        private void btnLogin_Click(object sender, EventArgs e)
        {
            
            SqlConnection conexion = new SqlConnection("server = LAPTOP-7O066IED\\SQLEXPRESS; database = TareaLista; integrated security = true");
            conexion.Open();


            string usuario = txtuser.Text;
            string contra = txtcontra.Text;

            string consulta = "select usuario, contrasena from [dbo].[TablaDeUsuarios] where usuario = '"+usuario+"' and contrasena = '" + contra + "'";

            SqlCommand comando = new SqlCommand(consulta, conexion);

                SqlDataReader leer = comando.ExecuteReader();

            if (leer.Read())
            {

                FrmInterfaz frmInterfaz = new FrmInterfaz();

                this.Hide();
                frmInterfaz.Show();


            }
            else
            {
                MessageBox.Show("Contrasena Incorrecta");
                
            }
                conexion.Close();
        }
        //boton para llevarlo a la ventana de registrarse
        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister frmRegister = new FrmRegister();

            this.Hide();
            frmRegister.Show();



        }

        private void boxremember_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtcontra_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtuser_TextChanged(object sender, EventArgs e)
        {

        }

        private void color_Click(object sender, EventArgs e)
        {

        }
        //pivturebox para cerrar el programa 

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        //pivturebox para maximizar el programa 
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pictureBox3.Visible = false;
            pictureBox5.Visible = true;
        }
        //pivturebox para restaurar el programa 

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pictureBox5.Visible = false;
            pictureBox3.Visible = true;
        }
        //pivturebox para minimizar el programa 

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
