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
    public partial class ManageUsers : System.Web.UI.Page
    {
        swift_utilityEntities ent = new swift_utilityEntities();
        ObjectParameter result = new ObjectParameter("returnVal", typeof(string));
        
        string username; string password; string role; string status; string partner; string encrypassword;
        protected void Page_Load(object sender, EventArgs e)
        {
            lblmsg.Text = "";
        }

        protected void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                username = txtUsername.Value;
                encrypassword = txtPassword.Value;
                password = CryptoClass.Encrypt(encrypassword, true);
                role = ddlRole.SelectedValue;
                status="A"; partner="Swift Voucher Generator";

                if (username != null && password != null)
                {
                    ent.createUser(partner, username, password, role, status, result);
                    if (!string.IsNullOrEmpty(result.Value.ToString()))
                    {
                        lblmsg.Text = "User Not Created!!! Please contact Administrator";
                    }
                    else { lblmsg.Text = "User Created Successfully"; }
                }
                
            }
            catch (Exception ex)
            {

                ex.ToString();
            }
        }

        protected void btnDisable_Click(object sender, EventArgs e)
        {
            try
            {
                username = txtUsername.Value;
                status = "D";
                ent.DisableUser(username, status, result);
                if (!string.IsNullOrEmpty(result.Value.ToString()))
                {
                    lblmsg.Text = "User Not Disabled. Please Contact Administrator!!!";
                }
                else 
                {
                    lblmsg.Text = "User Disabled Successfully";
                }
            }
            catch (Exception ex)
            {

                ex.ToString();
            }
        }

        protected void btnChange_Click(object sender, EventArgs e)
        {
            try
            {
                username = txtUsername.Value;
                role = ddlRole.SelectedValue;
                ent.ChangeUserRole(username, role, result);
                if (!string.IsNullOrEmpty(result.Value.ToString()))
                {
                    lblmsg.Text = "User Role not Changed. Please Contact Administrator!!!";
                }
                else
                {
                    lblmsg.Text = "User Role Changed Successfully";
                }
            }
            catch (Exception ex)
            {

                ex.ToString();
            }
        }
    }
}