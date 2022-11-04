using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Resto
{
    public partial class IniciarSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void IniciarSesion_Click(object sender, EventArgs e)
        {
            Modelo.Usuario user = new Modelo.Usuario();
            user.usuario = Usuario.Text;
            user.contra = Contra.Text;
            Controlador.UsuarioControlador uc = new Controlador.UsuarioControlador();
            if(uc.iniciarSesion(user)==true)
            {
                user = uc.obtenerUsuario(user);
                Session.Add("usuario", user);
                Response.Redirect("/");
            }
        }
    }
}