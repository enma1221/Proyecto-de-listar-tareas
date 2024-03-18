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
    public partial class VerTareas : Form
    {
        public VerTareas()
        {
            InitializeComponent();
        }
        //instanciamos la base de datos
        public SqlConnection conexion = new SqlConnection("server = LAPTOP-7O066IED\\SQLEXPRESS; database = TareaLista; integrated security = true");

        //metodo paras llenar las tablas
        public void llenar_Tablas()
        {

            string consultar = "select * from [dbo].[Tareas]";

            SqlDataAdapter adapter = new SqlDataAdapter(consultar, conexion);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            dgTabla.DataSource = dt; ;
        }

                //aqui se muestra la tabla en el datagiew
            private void dgTabla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            llenar_Tablas();
        }

        private void VerTareas_Load(object sender, EventArgs e)
        {
            llenar_Tablas();
        }
    }
}
