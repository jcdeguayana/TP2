using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace TP2
{
    public partial class Ejercicio5 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlMemorias.Items.Add("2GB");
                ddlMemorias.Items.Add("4GB");
                ddlMemorias.Items.Add("6GB");

                cblAccesorios.Items.Add("Monitor LCD");
                cblAccesorios.Items.Add("HD 500GB");
                cblAccesorios.Items.Add("Grabador DVD");
            }
        }

        protected void btnPrecio_Click(object sender, EventArgs e)
        {

            decimal PrecioMemoria = 0;

            // Obtener el elemento seleccionado en el DropDownList
            string memoriaSeleccionada = ddlMemorias.SelectedValue;

            if (memoriaSeleccionada == "2GB")
            {
                PrecioMemoria = 200;
            }
            else if (memoriaSeleccionada == "4GB")
            {
                PrecioMemoria = 375;
            }
            else
            {
                PrecioMemoria = 500;
            }

            // Inicializar el precio de los accesorios
            decimal PrecioAccesorios = 0;

            // Iterar sobre los elementos seleccionados en el CheckBoxList
            foreach (ListItem item in cblAccesorios.Items)
            {
                if (item.Selected)
                {
                    if (item.Text == "Monitor LCD")
                    {
                        PrecioAccesorios += 2000.50m;
                    }
                    else if (item.Text == "HD 500GB")
                    {
                        PrecioAccesorios += 550.50m;
                    }
                    else
                    {
                        PrecioAccesorios += 1200;
                    }
                }
            }

            // Calcular el precio total
            decimal PrecioTotal = PrecioMemoria + PrecioAccesorios;

            // Mostrar el precio total en el Label
            lblPrecio.Text = "El precio final es de " + PrecioTotal.ToString("N2") + "$";
        }
    }
}