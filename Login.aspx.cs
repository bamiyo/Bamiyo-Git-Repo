using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VoucherTemplates.Class;

namespace VoucherTemplates
{
    public partial class Login : System.Web.UI.Page
    {
        CryptoClass crypto = new CryptoClass();
        UtilityClass util = new UtilityClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string uname = txtUsename.Value;
            string pswd = txtPassword.Value;
            string password = string.Empty;
            string user = string.Empty;
            string role = string.Empty; string status = string.Empty;
            string date = DateTime.Now.ToString("dddd, MMMM dd, yyyy");
            try
            {
                var userdetails = util.getUserDetails(uname);


                foreach (DataRow row in userdetails.Rows)
                {
                    password = row["Password"].ToString();
                    user = row["User_Name"].ToString();
                    role = row["Role"].ToString();
                    status = row["status"].ToString();
                }
                string decryptedPwd = CryptoClass.Decrypt(password, true);
               
                Session["User_Name"] = uname;
                Session["Date"] = date;

                if (pswd == decryptedPwd && uname == user && status=="A")
                {
                   
                    if (role == "Admin")
                    {
                        Session["Role"] = role;
                        Response.Redirect("dashboard.aspx", false);
                    }
                    else if (role == "Activator")
                    {
                        Session["Role"] = role;
                        Response.Redirect("dashboard.aspx", false);
                    }
                    else 
                    {
                        Session["Role"] = role;
                        Response.Redirect("dashboard.aspx", false);
                    }

                }
               
                else
                {
                    string display = "Invalid Login Credentials!!!";
                    ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);
                }

            }
            catch (Exception ix)
            {

                ix.ToString();
            }
        }
    }
}