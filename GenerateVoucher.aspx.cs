using System;
using System.Collections.Generic;
using System.Data.Objects;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VoucherTemplates.Class;
using VoucherTemplates.Model;

namespace VoucherTemplates
{
    public partial class GenerateVoucher : System.Web.UI.Page
    {  
        UtilityClass util = new UtilityClass();
        swift_utilityEntities ent = new swift_utilityEntities();
        ObjectParameter result = new ObjectParameter("returnVal", typeof(string));
        int maxSize = 8; int maxCount; string username; int eVoucher; string comment;
        double value; string batchName; string VoucherType; int VoucherNo; int counter=0;
        
        protected void Page_Load(object sender, EventArgs e)
        {
            int i = util.getVoucherCount();
            string cnt = Convert.ToString(i + 1);
            lblBatchNo.Text = "SNV000" + cnt;
            if (!IsPostBack)
            {
               
            }
        }

        protected void btnGenerate_Click(object sender, EventArgs e)
        {
            batchName = lblBatchNo.Text;
            VoucherType = ddlVoucherType.SelectedValue;
            VoucherNo = Convert.ToInt32(txtVoucherNo.Value);
            value = Convert.ToDouble(ddlVoucherValue.SelectedValue);
            Convert.ToInt32(VoucherNo);
            comment = txtComment.Text;
            username = Session["User_Name"].ToString();
            maxCount = Convert.ToInt32(txtVoucherNo.Value);
            if (ddlVoucherType.SelectedValue == "e-Voucher")
            {
                eVoucher = 1;
            }
            else { eVoucher = 0; }
        try
       {
                //insert voucher batch inside the db
            ent.InsertBatch(batchName, VoucherNo, username, comment, eVoucher, result);
           if (result.Value.ToString() != null)
           {
               int batchID = Convert.ToInt32(result.Value.ToString());
               for (counter = 0; counter < maxCount; counter++)
               {
                   string Pin = CryptoClass.GetUniqueKey(maxSize); //Randomly generate alphanumeric pins
                   string hashedResult = CryptoClass.Encrypt(Pin, true);//Encrypt the generated voucher pin
                   ent.GenerateVoucherPIN(hashedResult, (float)value, batchID, result);
                   //check if voucher pin is duplicated in the db. if yes append value and insert into db

               replay:; 
                   
                   if (!string.IsNullOrEmpty(result.Value.ToString()))
                   {
                       if (batchID.ToString().Length > 3) 
                       {
                           batchID.ToString().Remove(0, 1);//handles batchID greater than 3 figures
                       }
                       string returnedPin = Pin.ToString().Remove(3, 5);//remove five figures from the pin starting from the 3rd index
                       string randomNumbers = CryptoClass.GetRandomNumbers(2);//generates 2 random alphanumeric figures
                       string mergedPin=returnedPin + batchID; //combines the new number with the batchID
                       returnedPin = mergedPin.Insert(6, randomNumbers); //Insert the random number into the new pin
                       string returnVal = returnedPin; // the newly created pin
                       hashedResult = CryptoClass.Encrypt(returnVal, true);//Encrypt the generated voucher pin
                       ent.GenerateVoucherPIN(hashedResult, (float)value, batchID, result);
                       if (!string.IsNullOrEmpty(result.Value.ToString()))
                       {
                           goto replay;
                       }


                   }
               }
           }

           else 
           {
               string display = "Voucher Generated Successfully!!!";
               ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);
           
           }
            }
            catch (Exception ex)
            {

                ex.ToString();
            }
        }
    }
}