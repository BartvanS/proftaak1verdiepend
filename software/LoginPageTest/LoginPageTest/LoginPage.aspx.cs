using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

namespace LoginPageTest
{
    public partial class LoginPageDesign : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;
        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            using(SqlConnection sqlCon = new SqlConnection(@"Data Source=joebase.database.windows.net;initial Catalog=JoeBotBase;Integrated Security=True;User ID=JoeAdmin;Password=JoePassword1;Trusted_Connection=False;Encrypt=True;"))
            {
                sqlCon.Open();
                string query = "SELECT COUNT(1) FROM Users WHERE username=@username AND password=@password";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                if(count == 1)
                {
                    Session["username"] = txtUsername.Text.Trim();
                    sqlCmd.CommandText = "SELECT Credits FROM Users WHERE username=@username";
                    Session["credits"] = sqlCmd.ExecuteScalar();
                    Response.Redirect("Dashboard.aspx");
                }
                else { lblErrorMessage.Visible = true; }
            }
        }

        protected void btnCreateNew_Click(object sender, EventArgs e)
        {
            Response.Redirect("CreateUser.aspx");
        }
    }
}