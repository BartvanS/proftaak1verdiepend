using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace LoginPageTest
{   
    public partial class Dashboard : System.Web.UI.Page
    {
        int Trickprice = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCredditError.Visible = false;
            lblUserName.Text = "Username : " + Session["username"];
            lblCredits.Text = "Credits: " + Session["credits"];
            if(Session["username"] == null)
            {
                Response.Redirect("LoginPage.aspx");
            }
        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            Session.Abandon();
            Response.Redirect("LoginPage.aspx");
        }


        protected void Truc_click(object sender, EventArgs e)
        {
            

            using(SqlConnection sqlCon = new SqlConnection(@"Data Source=joebase.database.windows.net;initial Catalog=JoeBotBase;Integrated Security=True;User ID=JoeAdmin;Password=JoePassword1;Trusted_Connection=False;Encrypt=True;"))
            {
                string Trick = (sender as Button).Text;
                if(Trick.Contains("A") == true)
                {
                    Trickprice = 10;
                }
                else if(Trick.Contains("B") == true)
                {
                    Trickprice = 15;
                }
                else if(Trick.Contains("C") == true)
                {
                    Trickprice = 20;
                }
                else if(Trick.Contains("D") == true)
                {
                    Trickprice = 25;
                }

                if(Trickprice > Convert.ToInt32(Session["credits"]))
                {
                    lblCredditError.Visible = true;
                    return;
                }

                sqlCon.Open();
                string query = "UPDATE Users SET Credits=@credits WHERE username=@username";
                SqlCommand sqlCommand = new SqlCommand(query, sqlCon);
                sqlCommand.Parameters.AddWithValue("@username", Session["username"]);
                sqlCommand.Parameters.AddWithValue("@credits", Convert.ToInt32(Session["credits"])-Trickprice);
                sqlCommand.ExecuteNonQuery();

                SqlCommand sqlCmd = new SqlCommand("BuyTrick", sqlCon);
                sqlCmd.CommandType = CommandType.StoredProcedure;
                sqlCmd.Parameters.AddWithValue("@username", Session["username"]);
                sqlCmd.Parameters.AddWithValue("@Trick", Trick);
                sqlCmd.Parameters.AddWithValue("@TrickDone", 0);
                sqlCmd.ExecuteNonQuery();

                Session["credits"] = Convert.ToInt32(Session["credits"]) - Trickprice;
                lblCredits.Text = "Credits: " + Session["credits"];
            }
        }
    }
}