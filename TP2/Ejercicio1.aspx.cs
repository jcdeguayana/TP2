using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2
{
    public partial class Ejercicio1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string Producto1 = txtProducto1.Text;
            string Producto2 = txtProducto2.Text;

            int Cantidad1 = int.Parse(txtCantidad1.Text);
            int Cantidad2 = int.Parse(txtCantidad2.Text);
            int Total = Cantidad1 + Cantidad2;
            

            string tabla = "<table border = '1'>";
            tabla += "<tr> <td>Producto</td> <td>Cantidad</td> </tr>";

                tabla += "<tr>";
                tabla += "<td>" + Producto1 + "</td>";
                tabla += "<td>" + Cantidad1 + "</td>";
                tabla += "</tr>";
                tabla += "<tr>";
                tabla += "<td>" + Producto2 + "</td>";
                tabla += "<td>" + Cantidad2 + "</td>";
                tabla += "</tr>";
                tabla += "<tr>";
                tabla += "<td>" + "TOTAL" + "</td>";
                tabla += "<td>" + Total + "</td>";
                tabla += "</tr>";


            tabla += "</table>";
            lblTabla.Text = tabla;
        }
    }
}