using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace Jardin_87P1
{
    public partial class frmIniciarSesion : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Context.User.Identity.IsAuthenticated)
                {
                    Response.Redirect("frmIniciarSesion.aspx");
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            using (Jardin87DataContext jardin = new Jardin87DataContext())
            {
                int rol = DropDownList1.SelectedIndex;
                var usuario = txtUsuario.Text;
                var contrasenia = txtcontraseña.Text.Trim();


                if (rol == 0)
                {
                    LB.CssClass = "alert alert-info";
                    LB.Text = "SELECCIONA UN TIPO DE USUARIO Y ESCRIBE TU USUARIO Y CONTRASEÑA";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                }

                else if (rol == 1)
                {
                    var consultas = jardin.Docente.Where(u => u.Usuario == usuario).FirstOrDefault();
                    if (consultas != null)
                    {
                        if (consultas.Usuario == usuario && consultas.Contrasenia == contrasenia)
                        {
                            string nombre = consultas.IdDocente;
                            FormsAuthentication.RedirectFromLoginPage(nombre, true);
                            Response.Redirect("frmDocente.aspx");

                        }
                        else
                        {
                            LB.CssClass = "alert alert-info";
                            LB.Text = "Usuario o contraseña incorrecta";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                        }
                    }
                    else
                    {
                        LB.CssClass = "alert alert-info";
                        LB.Text = "Usuario o contraseña incorrecta";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                    }


                }
                else if (rol == 2)
                {
                    var consultas = jardin.Administracion.Where(u => u.Usuario == usuario).FirstOrDefault();
                    if (consultas != null)
                    {
                        if (consultas.Usuario == usuario && consultas.Contrasenia == contrasenia)
                        {
                            string nombre = consultas.Usuario;
                            FormsAuthentication.RedirectFromLoginPage(nombre, true);
                            Response.Redirect("frmAdministrador.aspx");

                        }
                        else
                        {
                            LB.CssClass = "alert alert-info";
                            LB.Text = "Usuario o contraseña incorrecta";
                            ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                        }
                    }
                    else
                    {
                        LB.CssClass = "alert alert-info";
                        LB.Text = "Usuario o contraseña incorrecta";
                        ScriptManager.RegisterStartupScript(this, this.GetType(), "Pop", "openModal();", true);
                    }

                }




            }
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}