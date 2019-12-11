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

            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=.\MY_TEST_INSTANCE;initial Catalog=JoeWebTest;Integrated Security=True;"))
            {
                sqlCon.Open();
                string query = "SELECT COUNT(*) FROM tblUsers WHERE username=@username";
                SqlCommand sqlCmd = new SqlCommand(query, sqlCon);
                sqlCmd.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                sqlCmd.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                int count = Convert.ToInt32(sqlCmd.ExecuteScalar());

                string query2 = "SELECT COUNT(1) FROM tblUsers WHERE password=@password";
                SqlCommand sqlCmd2 = new SqlCommand(query2, sqlCon);
                sqlCmd2.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                sqlCmd2.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                int count2 = Convert.ToInt32(sqlCmd2.ExecuteScalar());

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
                if(count2 == 1)
                {
                    sqlCmd2.CommandText = "SELECT UserName FROM tblUsers WHERE password=@password";
                    lblPasswordError.Text = "Dat wachtwoord is al in gebruik door " + Convert.ToString(sqlCmd2.ExecuteScalar());
                    lblPasswordError.Visible = true;
                    return;
                }

                sqlCmd.CommandText = "SELECT COUNT(*) FROM tblUsers";
                count = Convert.ToInt32(sqlCmd.ExecuteScalar());
                count++;
                
                SqlCommand sqlCmdCreate = new SqlCommand("CreateAccount", sqlCon);
                sqlCmdCreate.CommandType = CommandType.StoredProcedure;
                sqlCmdCreate.Parameters.AddWithValue("@username", txtUsername.Text.Trim());
                sqlCmdCreate.Parameters.AddWithValue("@password", txtPassword.Text.Trim());
                sqlCmdCreate.Parameters.AddWithValue("@UserID", count);
                sqlCmdCreate.Parameters.AddWithValue("@credits", 50);
                sqlCmdCreate.ExecuteNonQuery();

                Response.Redirect("LoginPageDesign.aspx");
            }         
        }

        protected void btnLoginPage_Click(object sender, EventArgs e)
        {
            Response.Redirect("LoginPageDesign.aspx");
        }
    }
}