using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPageTest
{
    public partial class Dashboard : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUserName.Text = "Username : " + Session["username"];
            lblCredits.Text = "Credits: " + Session["credits"];
            if(Session["username"] == null)
            {
                Response.Redirect("LoginPageDesign.aspx");
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("LoginPageDesign.aspx");
        }
    }
}