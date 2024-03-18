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
using ProyectoListarTarea.Clases;

namespace ProyectoListarTarea
{
    public partial class FrmInterfaz : Form
    {
        public FrmInterfaz()
        {
            InitializeComponent();

        }

        public SqlConnection conexion = new SqlConnection("server = LAPTOP-7O066IED\\SQLEXPRESS; database = TareaLista; integrated security = true");




        private void FrmInterfaz_Load(object sender, EventArgs e)
        {
           

        }

      

       //pivturebox para cerrar el programa
        private void pbCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //pivturebox para maximizar el programa el programa
        private void pbMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            pbMaximizar.Visible = false;
            pbRestaurar.Visible = true;

        }
        //pivturebox para restaurar el programa
        private void pbRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            pbRestaurar.Visible = false;
            pbMaximizar.Visible = true;
        }
        //pivturebox para minimizar el programa
        private void pbMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }   

        //metodo para abrir las ventanas en el panelCenter
        public void AbrirFormHijo(object formhijo)
        {
            if (this.panelCenter.Controls.Count> 0) // verifica si panelCenter tiene subControladores o no

                this.panelCenter.Controls.RemoveAt(0); // borra el contenido

            Form formulario =  formhijo as Form;


            formulario.TopLevel = false; 
            formulario.Dock = DockStyle.Fill;
            this.panelCenter.Controls.Add(formulario);
            this.panelCenter.Tag = formulario;
            formulario.Show();

        }

        //boton para abrir el form AgregarTareas
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new AgregarTareas());
        }
        
        //panel Center
        private void panelCenter_Paint(object sender, PaintEventArgs e)
        {
            

        }
        //Boton modificar para abir el form Modificar
        private void btnModicar_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Modificar());
        }
        //Boton VerTabla para abir el form VerTareas

        private void btnVerTabla_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new VerTareas());

        }
        //Boton Tareas para abir el form Marcadas

        private void btnMarcadas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new Marcadas());
        }
    }


}