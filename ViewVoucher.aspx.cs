using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VoucherTemplates.Class;

namespace VoucherTemplates
{
    public partial class ViewVoucher : System.Web.UI.Page
    {
        UtilityClass util = new UtilityClass();
        DataTable batch = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dtBatch = new DataTable();
           
            dtBatch = util.loadVoucherBatch();
         if (!IsPostBack)
            {
              
            if(dtBatch.Rows.Count > 0)
         {
                
             foreach(DataRow row in dtBatch.Rows)
             {
                 ddlBatches.DataTextField = "BatchName";
                 ddlBatches.DataValueField = "BatchName";
                 ddlBatches.DataSource = dtBatch;
                 ddlBatches.DataBind();
             }
             var batchDetails = util.loadBatchDetails(ddlBatches.SelectedItem.ToString());
             lblCountNo.Text = batchDetails.Rows[0][0].ToString();
             lblGneratorName.Text= batchDetails.Rows[0][2].ToString();
             DateTime date = Convert.ToDateTime(batchDetails.Rows[0][1]);
             lblDateGnerarted.Text = date.ToString("MMMM dd, yyyy");

             //load the datagrid
             var loadGrid = util.populateGrid(ddlBatches.SelectedItem.ToString());
             GridView.DataSource = loadGrid;
             GridView.DataBind();
         }
        }

        }

        //protected void btnRefresh_Click(object sender, EventArgs e)
        //{

        //}

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
            string pin = ""; int serial=0;
            reset();
           //select search parameter by chosing a radio button
            if (RBSearchVoucher.SelectedIndex == 0) 
            { 
                pin = txtVoucher.Value;
                
            }
            else if (RBSearchVoucher.SelectedIndex == 1)
            {
                serial = Convert.ToInt32(txtVoucher.Value);
            }
            var searchVoucher = util.searchVoucher(pin, serial);

            if (searchVoucher.Rows.Count > 0)
            {
                lblCountNo.Text = searchVoucher.Rows[0][1].ToString();
                lblGneratorName.Text = searchVoucher.Rows[0][0].ToString();
                DateTime date = Convert.ToDateTime(searchVoucher.Rows[0][2]);
                lblDateGnerarted.Text = date.ToString("MMMM dd, yyyy");
            }
            foreach (DataRow rows in searchVoucher.Rows)
            {
                if (rows.IsNull("CustomerID"))
                {

                    rows[3] = "Available";
                }
                else
                {
                    rows[3] = "Used";
                }
                if (rows[5].Equals("1"))
                {

                    rows[5] = "Activated";
                }
                else
                {
                    rows[5] = "Not Activated";
                }
            }
            //}
            GridView.DataSource = searchVoucher;
            GridView.DataBind();
            }
            catch (Exception ex)
            {

                ex.ToString();
            }
            

          
        }

        protected void ddlBatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable batch = new DataTable();
           
           
                VoucherDetails();
                //load the datagrid
                var loadGrid = util.populateGrid(ddlBatches.SelectedItem.ToString());
                foreach (DataRow rows in loadGrid.Rows)
                {
                    if (rows.IsNull("CustomerID"))
                    {
                      
                        rows[3] = "Available";
                    }
                    else 
                    {
                        rows[3] = "Used";
                    }
                    if (rows[5].Equals("1"))
                    {
                       
                        rows[5] = "Activated";
                    }
                    else
                    {
                        rows[5] = "Not Activated";
                    }
                }
                
                GridView.DataSource = loadGrid;
                GridView.DataBind();
          
        }

        private void reset() 
        {
            try
            {
                lblCountNo.Text = "";
                lblGneratorName.Text = "";
                lblDateGnerarted.Text = "";
                GridView.DataSource = null;
                lblInfo.Text = "";
            }
            catch (Exception)
            {
                
                throw;
            }
        
        }

        private void VoucherDetails() 
        {
            batch = util.loadBatchDetails(ddlBatches.SelectedItem.ToString());
            if (batch.Rows.Count > 0)
            {
                lblCountNo.Text = batch.Rows[0][0].ToString();
                lblGneratorName.Text = batch.Rows[0][2].ToString();
                DateTime date = Convert.ToDateTime(batch.Rows[0][1]);
                lblDateGnerarted.Text = date.ToString("MMMM dd, yyyy");
            }
        }

        protected void BtnPrinter_Click(object sender, EventArgs e)
        {
           
           
                ExportVoucher();
                  // onaphtali2003@yahoo.co.uk   onaphtali2003@yahoo.co.uk
              string batch = ddlBatches.SelectedValue.ToString();

              using (MailMessage mm = new MailMessage(
              new MailAddress("info@swiftng.com", "SWIFT NETWORKS LTD."),
              //new MailAddress("onaphtali2003@gmail.com", "Printer")))
               new MailAddress("bamiyo.ogbeide@gmail.com", "Printer")))
                {

                    try
                    {
                        mm.Subject = "SWIFT VOUCHER BATCH " + batch + "";
                       // mm.CC.Add("bogbeide@swiftng.net");
                       // mm.CC.Add("bamiyurrrr@gmail.com");
                      //  mm.CC.Add("wadeyemi@swiftng.net");
                      //  mm.CC.Add("onaphtali2003@yahoo.co.uk");
                      //  mm.Bcc.Add("bogbeide@swiftng.net");
                        mm.Body = "Dear Printer, Please find attached SWIFT Recharge Voucher(s) to be printed";
                        mm.Attachments.Add(new Attachment(@"C:/File/SWIFTvoucher.txt"));
                        mm.IsBodyHtml = true;
                        SmtpClient smtp = new SmtpClient();
                       // smtp.Host = "sendmail.swiftng.com";
                        smtp.Host = "41.221.164.52";
                        NetworkCredential credential = new NetworkCredential();
                       // credential.UserName = "SwiftPromo@swiftng.com";
                        credential.Password = "";
                        smtp.UseDefaultCredentials = true;
                        smtp.Credentials = credential;
                        //smtp.Port = 26;
                        if (mm.Attachments != null)
                        {
                            smtp.Send(mm);
                            lblInfo.Text = "Voucher batch " + batch + " Successfully Sent to Printer";
                            mm.Attachments.Dispose();
                            if (File.Exists(@"C:/File/SWIFTvoucher.txt"))
                            {
                                File.Delete(@"C:/File/SWIFTvoucher.txt");
                            }

                        }
                        else 
                        {
                            lblInfo.Text = "Voucher Not Sent to Printer";
                            mm.Attachments.Dispose();
                            if (File.Exists(@"C:/File/SWIFTvoucher.txt"))
                            {
                                File.Delete(@"C:/File/SWIFTvoucher.txt");
                            }
                        }
                           
                        
                    }
                    catch (Exception ex)
                    {
                        
                      string display = "Email not sent.Please Contact Administrator!!!";
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);
                    }
                      
                           
                    }
            
            
        }

        private void ExportVoucher()
        {
            try
            {
                if (GridView.Rows.Count > 0)
               {

                string Destinationpath = @"C:/File/SWIFTvoucher.txt";

                if (File.Exists("SWIFTvoucher.txt"))

                { 
                    File.Delete("SWIFTvoucher.txt"); }
                else
                {
                    TextWriter sw = new StreamWriter(Destinationpath);

                    for (int x = 3; x < GridView.Columns.Count; x++)
                    {


                        sw.Write(GridView.Columns[x].HeaderText);
                        if (x != GridView.Columns.Count - 1)
                        {
                            sw.Write("      ,");

                        }
                    }
                    sw.WriteLine();

                    int rowcount = GridView.Rows.Count;
                    for (int i = 0; i < rowcount - 0; i++)
                    {
                        //for (int z = 1; z < rowcount - 0; z++) 

                        string encryptedVoucher = GridView.Rows[i].Cells[4].Text;

                        string Voucher = CryptoClass.Decrypt(encryptedVoucher, true);

                        sw.WriteLine(GridView.Rows[i].Cells[3].Text + ",        " + Voucher.ToString() + ",   " + GridView.Rows[i].Cells[5].Text + ",  " + GridView.Rows[i].Cells[6].Text);

                    }
                    sw.Close();     //Don't Forget Close the TextWriter Object(sw)

                }
            }
            else
            {
                 string display = "Email not sent.Please Contact Administrator!!!";
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);
            }
            }
            catch (Exception ex)
            {
                
               string display = "Email not sent.Please Contact Administrator!!!";
                        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('" + display + "');", true);
            }
        }

    
      

    }
}