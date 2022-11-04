using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Modelo;
namespace Resto
{
    public partial class SiteMaster : MasterPage
    {
        public Modelo.Usuario usuario { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            this.usuario = new Modelo.Usuario();
            if (Session["usuario"]==null)
            {
                this.usuario.rol = 100;
                if (HttpContext.Current.Request.Url.AbsolutePath!="/iniciarSesion")
                {
                    Response.Redirect("./iniciarSesion");
                }
                
               
            }
            else
            {
               
                this.usuario = (Modelo.Usuario)Session["usuario"];

            }
        }

        protected void cerrarSesion_Click(object sender, EventArgs e)
        {
            Session.Remove("usuario");
            Response.Redirect("./iniciarSesion");
        }

    }
}