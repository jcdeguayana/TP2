using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2
{
    public partial class Ejercicio2b : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            String Nombre;
            String Apellido;

            Nombre = ((TextBox)PreviousPage.FindControl("txtNombre")).Text;
            Apellido = ((TextBox)PreviousPage.FindControl("txtApellido")).Text;

            lblNombre.Text = Nombre;
            lblApellido.Text = Apellido;

            String Zona;
            Zona = Request["ddlCiudad"].ToString();
            

            if (Zona == "Gral. Pacheco")
            {
                lblZonas.Text = "Norte";
            }
            else if (Zona == "San Miguel")
            {
                lblZonas.Text = "Oeste";
            }
            else
            {
                lblZonas.Text = "Sur";
            }

            String temas = Context.Items["SelectedTemas"] as String;

            if (!String.IsNullOrEmpty(temas))
            {
                lblTemas.Text = temas;
            }
           else
            {
                lblTemas.Text = "No items selected.";
            }

        }
    }
}