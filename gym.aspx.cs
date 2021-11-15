using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CEntidad;
using System.Data;
using CNegocio;

namespace ProyectoPersonal
{
    public partial class gym : System.Web.UI.Page
    {
        CNgym ONgym = new CNgym();
        CEgym OEgym = new CEgym();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            OEgym.Id1 = Convert.ToInt32(TxtId.Text);

            ds = ONgym.ConsultarRutina(OEgym);
            if (ds.Tables[0].Rows.Count == 0)
            {
                lblRespuesta.Text = "Rutina NO encontrada";
                Response.Redirect("gym.aspx");
            }
            else
            {
                //lblRespuesta.Text = ds.Tables[0].Rows[0]["id "].ToString();
                TxtMT.Text = ds.Tables[0].Rows[0]["Musculos"].ToString();
                TxtR.Text = ds.Tables[0].Rows[0]["EjerciciosR"].ToString();
                TxtRR.Text = ds.Tables[0].Rows[0]["Repeticiones"].ToString();
                TxtSeries.Text = ds.Tables[0].Rows[0]["Series"].ToString();

            }
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            OEgym.Id1 = Convert.ToInt32(TxtId.Text);
            if (ONgym.EliminarRutina(OEgym))
            {
                lblRespuesta.Text = "RUTINA ELIMINADA CON EXITO";
                Response.Redirect("gym.aspx");
            }
            else
            {
                lblRespuesta.Text = "ERROR AL ELIMINAR LA RUTINA";
            }

        }

        protected void BtnGuardar_Click(object sender, EventArgs e)
        {
            //OEgym.Id1 = Convert.ToInt32(TxtId.Text);
            OEgym.Musculos1 = Convert.ToString(TxtMT.Text);
            OEgym.EjercR1 = Convert.ToString(TxtR.Text);
            OEgym.Reps1 = Convert.ToInt32(TxtRR.Text);
            OEgym.Series1 = Convert.ToInt32(TxtSeries.Text);

            if (ONgym.GuardarRutina(OEgym))
            {
                lblRespuesta.Text = "RUTINA GUARDADA";
                Response.Redirect("gym.aspx");
            }
            else
            {
                lblRespuesta.Text = "ERROR AL GUARDAR LA RUTINA";
            }

        }
    }
}