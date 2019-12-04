using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VoucherTemplates.Class;
using VoucherTemplates.Model;

namespace VoucherTemplates
{
    public partial class forgotpassword : System.Web.UI.Page
    {
        swift_utilityEntities ent = new swift_utilityEntities();
        ObjectParameter result = new ObjectParameter("returnVal", typeof(string));
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void ChangePswd_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txtUsename.Value;
                string pswd = txtPassword.Value;
                string password = CryptoClass.Encrypt(pswd, true);
                ent.ChangePassword(password, username, result);

                if (!string.IsNullOrEmpty(result.Value.ToString()))
                {
                    lblmsg.Text = "Password Not Changed!!! Please contact Administrator";
                }
                else 
                {
                    lblmsg.Text = "Password Changed Successfully!!!";
                }
            }
            catch (Exception ex)
            {

                ex.ToString();
            }
        }
    }
}