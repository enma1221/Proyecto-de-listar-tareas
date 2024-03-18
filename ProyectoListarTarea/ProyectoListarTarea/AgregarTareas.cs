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
    public partial class AgregarTareas : Form
    {
        public AgregarTareas()
        {
            InitializeComponent();
        }
        public SqlConnection conexion = new SqlConnection("server = LAPTOP-7O066IED\\SQLEXPRESS; database = TareaLista; integrated security = true");
        
        //metodo para limpiar los campos de texto
        private void LimpiarCuadrosDeTexto()
        {
            txtTitulo.Clear();
            txtDescripcion.Clear();
            txtMateria.Clear();

        }
        private void AgregarTareas_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //boton para agregar las tareas a la base de datos
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            conexion.Open();
            //declaramos las variables
            string titulo = txtTitulo.Text;
            string descripcion = txtDescripcion.Text;
            string materia = txtMateria.Text;
            var fecha = dtpFecha.Value.ToString("yyyy-MM-dd");

            //insertamos los valores a los campos asignados
            string insert = "insert into Tareas(Titulo, Descripcion, Materia, Fecha) values('"+titulo+"', '"+descripcion+"', '"+materia+"', '"+fecha+"')";

            //hacemos el insert
            SqlCommand cn = new SqlCommand(insert, conexion);
        
            //lo ejecutamos para que no devuelva nada
            cn.ExecuteNonQuery();

            //llamamos al metodo
            LimpiarCuadrosDeTexto();

            MessageBox.Show("Su tarea llamada "+titulo+" ha sido Agregada correctamente!!!");


            conexion.Close();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
