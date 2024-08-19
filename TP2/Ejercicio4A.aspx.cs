using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2
{
    public partial class Ejercicio4A : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnValidar_Click(object sender, EventArgs e)
        {
            if(txtUsuario.Text == "claudio" && txtClave.Text == "casas")
            {
                Response.Redirect("Ejercicio4B.aspx");
            }
            else
            {
                Response.Redirect("Ejercicio4C.aspx");
            }
        }
    }
}