using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen2
{
    public partial class Visualizacion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Todoslosdatos();
                Datoscarro();
                Datosincarro();
            }
        }
        private void Todoslosdatos()
        {
            string connectionString = "Data Source=KEVIN-DESKTOP\\SQLEXPRESS;Initial Catalog=BDencuestas;Integrated Security=True";
            string query = "SELECT * FROM preguntas";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                GridViewReporte.DataSource = reader;
                GridViewReporte.DataBind();
                GridViewReporte.HeaderRow.Cells[0].Text = " # de Encuesta ";
                GridViewReporte.HeaderRow.Cells[1].Text = "Nombre";
                GridViewReporte.HeaderRow.Cells[2].Text = "Apellido";
                GridViewReporte.HeaderRow.Cells[3].Text = " Fecha de Nacimiento ";
                GridViewReporte.HeaderRow.Cells[4].Text = "Correo";
                GridViewReporte.HeaderRow.Cells[5].Text = " Carro propio ";

            }
        }
        private void Datoscarro()
        {
            string connectionString = "Data Source=KEVIN-DESKTOP\\SQLEXPRESS;Initial Catalog=BDencuestas;Integrated Security=True";
            string query = "SELECT * FROM preguntas where carro =1";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                GridView1.DataSource = reader;
                GridView1.DataBind();
                GridView1.HeaderRow.Cells[0].Text = " # de Encuesta ";
                GridView1.HeaderRow.Cells[1].Text = "Nombre";
                GridView1.HeaderRow.Cells[2].Text = "Apellido";
                GridView1.HeaderRow.Cells[3].Text = " Fecha de Nacimiento ";
                GridView1.HeaderRow.Cells[4].Text = "Correo";
                GridView1.HeaderRow.Cells[5].Text = " Carro propio ";
            }
        }
        private void Datosincarro()
        {
            string connectionString = "Data Source=KEVIN-DESKTOP\\SQLEXPRESS;Initial Catalog=BDencuestas;Integrated Security=True";
            string query = "SELECT * FROM preguntas where carro =0";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                GridView2.DataSource = reader;
                GridView2.DataBind();
                GridView2.HeaderRow.Cells[0].Text = " # de Encuesta ";
                GridView2.HeaderRow.Cells[1].Text = "Nombre";
                GridView2.HeaderRow.Cells[2].Text = "Apellido";
                GridView2.HeaderRow.Cells[3].Text = " Fecha de Nacimiento ";
                GridView2.HeaderRow.Cells[4].Text = "Correo";
                GridView2.HeaderRow.Cells[5].Text = " Carro propio ";
            }
        }

        protected void GridViewReporte_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Bregresar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Reportes.aspx");
        }
    }
}