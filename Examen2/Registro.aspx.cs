using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Examen2
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void benviar_Click(object sender, EventArgs e)
        {
            
            if (!Regex.IsMatch(nombre.Value, @"^[a-zA-Z\sáéíóúÁÉÍÓÚ]+$") || !Regex.IsMatch(apellidos.Value, @"^[a-zA-Z\sáéíóúÁÉÍÓÚ]+$"))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "alert('Por favor, ingresa únicamente letras en los campos de nombre y apellidos.');", true);
                return;
            }

            DateTime fechaNac;
            if (!DateTime.TryParse(fechaNacimiento.Value, out fechaNac))
            {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "alert('Por favor, ingresa una fecha de nacimiento válida.');", true);
                return;
            }

            int edad = DateTime.Now.Year - fechaNac.Year;
            if (edad < 18 || edad > 50)
            {
                
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "alert('La edad debe estar entre 18 y 50 años')", true);
                return;
            }

            
            string nombreEncuesta = Request.Form["nombre"].ToUpper();
            string apellidosEncuesta = Request.Form["apellidos"].ToUpper();
            DateTime fechaNacimientoEncuesta = fechaNac;
            string correoEncuesta = Request.Form["correo"];
            bool carroPropioEncuesta = Request.Form["carroPropio"] == "Si";

            string connectionString = "Data Source=KEVIN-DESKTOP\\SQLEXPRESS;Initial Catalog=BDencuestas;Integrated Security=True";

            string query = "INSERT INTO preguntas (Nombre, Apellido, fechanac, correo, carro) VALUES (@Nombre, @Apellidos, @FechaNacimiento, @Correo, @CarroPropio)";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Nombre", nombreEncuesta);
                    command.Parameters.AddWithValue("@Apellidos", apellidosEncuesta);
                    command.Parameters.AddWithValue("@FechaNacimiento", fechaNacimientoEncuesta);
                    command.Parameters.AddWithValue("@Correo", correoEncuesta);
                    command.Parameters.AddWithValue("@CarroPropio", carroPropioEncuesta);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }

            
            nombre.Value = "";
            apellidos.Value = "";
            fechaNacimiento.Value = "";
            correo.Value = "";
            carroPropio.SelectedIndex = 0;

            ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "alert('Encuesta enviada correctamente')", true);
        }


        protected void bborrar_Click(object sender, EventArgs e)
        {
            nombre.Value = "";
            apellidos.Value = "";
            fechaNacimiento.Value = "";
            correo.Value = "";
            carroPropio.SelectedIndex = 0;
        }
    }
}