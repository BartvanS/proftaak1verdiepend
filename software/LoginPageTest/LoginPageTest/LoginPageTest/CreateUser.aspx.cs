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
    public partial class CreateUser : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;
            lblPasswordError.Visible = false;
            lblUsernameTaken.Visible = false;
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            lblErrorMessage.Visible = false;
            lblPasswordError.Visible = false;
            lblUsernameTaken.Visible = false;

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=joebase.database.windows.net;initial Catalog=JoeBotBase;Integrated Security=True;User ID=JoeAdmin;Password=JoePassword1;Trusted_Connection=False;Encrypt=True;"))
            {
                sqlCon.Open();
                string query = "SELECT COUNT(*) FROM Users WHERE username=@username";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());


                if (txtPassword.Text == "" || txtUsername.Text == "")
                {
                    lblErrorMessage.Visible = true;
                }
                if (txtPassword.Text.Contains(" "))
                {
                    lblPasswordError.Text = "Password cannot contain any spaces";
                    lblPasswordError.Visible = true;
                    return;
                }               
                if (txtPassword.Text.Length < 4)
                {
                    lblPasswordError.Text = "Het wachtwoord moet minimaal 4 characters hebben";
                    lblPasswordError.Visible = true;
                    return;
                }
                if(count > 0)
                {
                    lblUsernameTaken.Visible = true;
                    return;
                }
               
                
                SqlCommand sqlCmdCreate = new SqlCommand("CreateAccount", sqlCon);
                sqlCmdCreate.CommandType = CommandType.StoredProcedure;
                sqlCmdCreate.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                sqlCmdCreate.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                sqlCmdCreate.Parameters.AddWithValue("@credits", 50);
                sqlCmdCreate.ExecuteNonQuery();

                Response.Redirect("LoginPage.aspx");
            }         
        }

        protected void btnLoginPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPage.aspx");
        }
    }
}