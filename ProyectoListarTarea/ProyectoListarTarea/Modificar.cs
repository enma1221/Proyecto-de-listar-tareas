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
    public partial class Modificar : Form
    {
        public Modificar()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

        }

        //instanciamos la base de datos
        public SqlConnection conexion = new SqlConnection("server = LAPTOP-7O066IED\\SQLEXPRESS; database = TareaLista; integrated security = true");

        //metodo para llenar la tabla dgvTabla(tambien sirve para actualizarla)
        public void llenar_Tablas()
        {

            string consultar = "select * from [dbo].[Tareas]";

            SqlDataAdapter adapter = new SqlDataAdapter(consultar, conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgvTabla.DataSource = dt; 

                }
        //metodo para bprrar los text box
        public void borrar_texbox()
        {
            txtTitulo.Clear();
            txtDescripcion.Clear();
            txtMateria.Clear();
            txtID.Clear();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //boton para modificar los campos de mis tareas en la base de datos
        private void btnModificar_Click(object sender, EventArgs e)
        {
            //abrimos la conexion
            conexion.Open();
            //declaramos variables
            string buscarID = txtID.Text;
            string titulo = txtTitulo.Text;
            string descripcion = txtDescripcion.Text;
            string materia = txtMateria.Text;
            var fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

            //hacemos un update
            string cadena = "UPDATE Tareas SET Titulo = '" + titulo + "', Descripcion = '" + descripcion + "', Materia =  '"+materia+"', Fecha = '"+fecha+"' where ID = '" + buscarID + "'";
            

            SqlCommand cmd = new SqlCommand(cadena, conexion);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Tu Tarea se a modificado correctamente!!!!!");

            llenar_Tablas();
            conexion.Close();
        }

        private void dgvTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {   txtID.Text = dgvTabla.SelectedCells[0].Value.ToString();
            txtTitulo.Text = dgvTabla.SelectedCells[1].Value.ToString();
            txtDescripcion.Text = dgvTabla.SelectedCells[2].Value.ToString();
            txtMateria.Text = dgvTabla.SelectedCells[3].Value.ToString();
        }
        //boton de actualizar o ver la tabla
        private void btnVer_Click(object sender, EventArgs e)
        {
            llenar_Tablas();

        }
        //boton de borrar los campos del texbox

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            borrar_texbox();
        }
        //boton de eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            string buscarID = txtID.Text;
            string titulo = txtTitulo.Text;
            string descripcion = txtDescripcion.Text;
            string materia = txtMateria.Text;
            var fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

            string cadena = "delete from Tareas where ID = '"+buscarID+"'";

            SqlCommand cmd = new SqlCommand(cadena, conexion);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Tu Tarea se ha borrado correctamente!!!!!");

            borrar_texbox();
            llenar_Tablas();
            conexion.Close();
        }

        private void Modificar_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
