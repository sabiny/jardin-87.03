using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text;

namespace Jardin_87P1
{
    public partial class frmDocente : System.Web.UI.Page

    {
        private Jardin87DataContext jardin = new Jardin87DataContext();
        

        protected void Page_Load(object sender, EventArgs e)
        {
            
            lblLogin.Text = HttpContext.Current.User.Identity.Name;
            var consulta = jardin.Estudiantes.Where(B => B.IdDocente == lblLogin.Text);
            GridView1.DataSource = consulta;
            GridView1.DataBind();
        }
        
        protected void Button1_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click2(object sender, EventArgs e)
        {
            using (Jardin87DataContext jardin = new Jardin87DataContext())


            {

                
            }
        }

        protected void Button1_Click3(object sender, EventArgs e)
        {
            

        }

        protected void txtdocente_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
             
        }
    }
}