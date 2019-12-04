using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Objects;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using VoucherTemplates.Class;
using VoucherTemplates.Model;

namespace VoucherTemplates
{
    public partial class ActivateVoucher : System.Web.UI.Page
    {
        UtilityClass util = new UtilityClass();
        DataTable batch = new DataTable();
        swift_utilityEntities ent = new swift_utilityEntities();
        ObjectParameter result = new ObjectParameter("returnVal", typeof(string));
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dtBatch = new DataTable();

            dtBatch = util.loadVoucherBatch();
            if (!IsPostBack)
            {

                if (dtBatch.Rows.Count > 0)
                {

                    foreach (DataRow row in dtBatch.Rows)
                    {
                        ddlBatches.DataTextField = "BatchName";
                        ddlBatches.DataValueField = "BatchName";
                        ddlBatches.DataSource = dtBatch;
                        ddlBatches.DataBind();
                    }
                    var batchDetails = util.loadBatchDetails(ddlBatches.SelectedItem.ToString());
                   

                    //load the datagrid
                    var loadGrid = util.populateGrid(ddlBatches.SelectedItem.ToString());
                    GridView.DataSource = loadGrid;
                    GridView.DataBind();
                    //clear dropdownlist before loading it
                   // ddlSerial.Items.Clear();
                 /////   //bind serial numbers to drop down
                    //for (int i = 0; i < GridView.Rows.Count; i++)
                    //{

                    //    Label lblname = (Label)GridView.Rows[i].Cells[7].FindControl("lblSerial");
                    //    string no = lblname.Text;
                    //    ddlSerial.Items.Add(no);

                    //}
                  
                }
            }
        }

        protected void btnActivate_Click(object sender, EventArgs e)
        {
            string voucher = null; int serial = 0;
            try
            {
                int voucherIDFrom = int.Parse(txtFrom.Value);
                int voucherIDTo = int.Parse(txtTo.Value);
              //  int stop = Convert.ToInt32(ddlSerial.SelectedValue);
                //foreach (GridViewRow row in GridView.Rows)
                //{
                  

                //    Label lblname = (Label)row.Cells[7].FindControl("lblSerial");
                //    serial = Convert.ToInt32(lblname.Text);  
                   
                //    if (serial <= stop)

                //        voucher = row.Cells[4].Text;
                //        int voucherid = Convert.ToInt32(row.Cells[3].Text);
                      int voucherStatus = 1;
                        string activator = Session["User_Name"].ToString();
                //        ent.ActivateVoucher(voucherid,voucherStatus,activator,voucher,result);
                //}
                ent.ActivateVoucher(voucherIDFrom, voucherStatus, activator, voucherIDTo, result);

                if (!string.IsNullOrEmpty(result.Value.ToString()))
                {
                    lblInfo.Text = "Vouchers Not Activated !!!";
                }
                else 
                {
                    lblInfo.Text = "Vouchers Activated Successfully!!!";
                    UpdateGrid();
                   
                }
            }
            catch (Exception ex)
            {

                ex.ToString();
            }
        }

        protected void ddlBatches_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable batch = new DataTable();


            reset();
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
            //clear dropdownlist before loading it
          //  ddlSerial.Items.Clear();
            //bind serial numbers to drop down
            for (int i = 0; i < GridView.Rows.Count; i++)
            {
              
                Label lblname = (Label)GridView.Rows[i].Cells[7].FindControl("lblSerial");
                string no = lblname.Text;
               // ddlSerial.Items.Add(no);
               
            }
           
        }

        protected void btnDeactivate_Click(object sender, EventArgs e)
        {
            string voucher = null; int serial = 0;
            try
            {
                int voucherIDFrom = int.Parse(txtFrom.Value);
                int voucherIDTo = int.Parse(txtTo.Value);
               //// int stop = Convert.ToInt32(ddlSerial.SelectedValue);
               // foreach (GridViewRow row in GridView.Rows)
               // {
               //     Label lblname = (Label)row.Cells[7].FindControl("lblSerial");
               //     serial = Convert.ToInt32(lblname.Text);

               //    // if (serial <= stop)


               //     voucher = row.Cells[4].Text;
                //    int voucherid = Convert.ToInt32(row.Cells[3].Text);
                    string activator = Session["User_Name"].ToString();

                    ent.DeActivateVoucher(voucherIDFrom, activator, voucherIDTo, result);
               // }

                if (!string.IsNullOrEmpty(result.Value.ToString()))
                {
                    lblInfo.Text = "Vouchers Not DeActivated Successfully!!!";
                }
                else
                {
                    lblInfo.Text = "Vouchers  DeActivated Successfully!!!";
                    UpdateGrid();
                }
            }
            catch (Exception ex)
            {

                ex.ToString();
            }
        }
        private void reset()
        {
            try
            {
               
                GridView.DataSource = null;
                lblInfo.Text = "";
                lblCountNo.Text = "";
                lblGneratorName.Text = "";
                lblDateGnerarted.Text = "";
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

        protected void GridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                Label lblSerial = (Label)e.Row.FindControl("lblSerial");
                lblSerial.Text = ((GridView.PageIndex * GridView.PageSize) + e.Row.RowIndex + 1).ToString();
            }
        }

        private void UpdateGrid() 
        {
            try
            {
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
            catch (Exception)
            {
                
                throw;
            }
        
        }
     
       
    }
}