using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2
{
    public partial class Ejercicio2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                ddlCiudad.Items.Add("Gral. Pacheco");
                ddlCiudad.Items.Add("San Miguel");
                ddlCiudad.Items.Add("Boedo");

                cblTemas.Items.Add("Ciencias");
                cblTemas.Items.Add("Literatura");
                cblTemas.Items.Add("Historia");
            }
        }

        protected void ddlCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void cblTemas_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        protected void btnResumen_Click(object sender, EventArgs e)
        {
            String selectedTemas = "";

           foreach (ListItem item in cblTemas.Items)
            {
                if (item.Selected)
                {
                    
                 //"<tr>" + selectedTemas += item.Text + "</tr>";
                    selectedTemas += item.Text;
                }
            }

            Context.Items["SelectedTemas"] = selectedTemas;

            Server.Transfer("Ejercicio2b.aspx");

        }
    }
}