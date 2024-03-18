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
    public partial class Marcadas : Form
    {
        public Marcadas()
        {
            InitializeComponent();
        }


        


        //instanciamos la base de datos
        public SqlConnection conexion = new SqlConnection("server = LAPTOP-7O066IED\\SQLEXPRESS; database = TareaLista; integrated security = true");
        

        //metodo para llenar el checkedlsitbox para que se vean las tareas 
        public void LlenarCheckedListBox(SqlConnection connection, CheckedListBox checkedListBox)
        {
            string consulta = "SELECT * FROM Tareas";

            SqlDataAdapter adapter = new SqlDataAdapter(consulta, connection);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            checkedListBox.DataSource = dt;

            checkedListBox.DisplayMember = "Titulo";
            
        }


        //aqui abrimos la conexion, llamamos al metodo y cerramos la conexion
        private void Marcadas_Load(object sender, EventArgs e)
        {
            conexion.Open();

            LlenarCheckedListBox(conexion, checkedListBox1);

            conexion.Close();
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        //btn para marcarlas como hechas
        private void btnMarcar_Click(object sender, EventArgs e)
        {
            conexion.Open();

            string marcado = checkedListBox1.Text.ToString();
            string consulta = "delete from Tareas where Titulo = '"+ marcado + "'";

            SqlCommand sqlCommand = new SqlCommand(consulta, conexion);

            try
            {
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Haz hecho tu tarea!!!!");

            }
            catch (Exception)
            {

                MessageBox.Show("No Haz hecho tu tarea");
            }
        
            LlenarCheckedListBox(conexion, checkedListBox1);

            conexion.Close();
        }
    }
}
