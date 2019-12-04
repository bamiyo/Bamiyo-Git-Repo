using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace VoucherTemplates.Class
{
    public class UtilityClass
    {
        public DataTable getUserDetails(string username)
        {
            DataTable dt = new DataTable();
            string ConString = ConfigurationManager.ConnectionStrings["SwiftUtility"].ConnectionString;
            SqlConnection con = new SqlConnection(ConString);
            try
            {

                SqlCommand command;

                con.Open();
                string query = @"Select User_Name, password, Role,Status from partnerlogins where User_Name='" + username + "'";
                command = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                adapter.Fill(dt);




            }
            catch (Exception e)
            {

                string display = e.ToString();

            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public int getVoucherCount()
        {
            int VoucherCount = 0;
            string ConString = ConfigurationManager.ConnectionStrings["SwiftUtility"].ConnectionString;
            SqlConnection con = new SqlConnection(ConString);
            try
            {

                SqlCommand command;

                con.Open();
                string query = @"Select max(batch_id) as batchid from Batch ";
                command = new SqlCommand(query, con);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    VoucherCount = Convert.ToInt32(reader["batchid"]);
                }
                int i = VoucherCount;
                string cnt = Convert.ToString(i + 1);




            }
            catch (Exception e)
            {

                string display = e.ToString();

            }
            finally
            {
                con.Close();
            }
            return VoucherCount;
        }

        public DataTable loadVoucherBatch()
        {
            DataTable dt = new DataTable();
            string ConString = ConfigurationManager.ConnectionStrings["SwiftUtility"].ConnectionString;
            SqlConnection con = new SqlConnection(ConString);
            try
            {

                SqlCommand command;

                con.Open();
                string query = @"Select BatchName from Batch order by batch_id asc";
                command = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                adapter.Fill(dt);




            }
            catch (Exception e)
            {

                string display = e.ToString();

            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public DataTable loadBatchDetails(string batchName)
        {
            DataTable dt = new DataTable();
            string ConString = ConfigurationManager.ConnectionStrings["SwiftUtility"].ConnectionString;
            SqlConnection con = new SqlConnection(ConString);
            try
            {

                SqlCommand command;

                con.Open();
                string query = @"Select NoOfVouchers, EntryDate,Username from Batch where BatchName='" + batchName + "'";
                command = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                adapter.Fill(dt);




            }
            catch (Exception e)
            {

                string display = e.ToString();

            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public DataTable populateGrid(string batchName)
        {
            DataTable dt = new DataTable();
            string ConString = ConfigurationManager.ConnectionStrings["SwiftUtility"].ConnectionString;
            SqlConnection con = new SqlConnection(ConString);
            try
            {

                SqlCommand command;

                con.Open();
                string query = @"Select b.username, b.NoOfVouchers,b.EntryDate,t.onlineID as status,t.CustomerID, v.voucherstatus ,b.BatchName,v.Voucherid SerialNo,v.voucher ,v.value from Batch b left outer join Vouchers v
                                on b.Batch_ID=v.Batch_ID left outer join TransactionHistory t on v.VoucherID=t.VoucherID where b.BatchName='" + batchName + "' order by v.Voucherid asc";
                command = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                adapter.Fill(dt);




            }
            catch (Exception e)
            {

                string display = e.ToString();

            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        public DataTable searchVoucher(string pin, int serial)
        {
            DataTable dt = new DataTable();
            string ConString = ConfigurationManager.ConnectionStrings["SwiftUtility"].ConnectionString;
            SqlConnection con = new SqlConnection(ConString);
            try
            {

                SqlCommand command;

                con.Open();
                string query = @"Select b.username, b.NoOfVouchers,b.EntryDate,t.onlineID as status,t.CustomerID, v.voucherstatus ,b.BatchName,v.Voucherid SerialNo,v.voucher ,v.value from Batch b left outer join Vouchers v
                                on b.Batch_ID=v.Batch_ID left outer join TransactionHistory t on v.VoucherID=t.VoucherID where v.Voucherid='" + serial + "' or v.voucher='" + pin + "' ";
                command = new SqlCommand(query, con);
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);

                adapter.Fill(dt);




            }
            catch (Exception e)
            {

                string display = e.ToString();

            }
            finally
            {
                con.Close();
            }
            return dt;
        }

        //public bool generateVoucher()
        //{
        //    bool flag = false;

        //    try
        //    {
        //        using (SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["SwiftUtility"].ConnectionString))
        //        {
        //            conn.Open();
        //            using (SqlCommand cmd = new SqlCommand("INSERT INTO socialmediapotential (fullname,address,email,phone,promocode,ref_code,date_created) " +
        //                " values ( @fullname,@address,@email,@phone, @promocode,@ref_code, @date_created)", conn))
        //            {

        //                cmd.Parameters.AddWithValue("@fullname", fullname);
        //                cmd.Parameters.AddWithValue("@address", address);
        //                cmd.Parameters.AddWithValue("@email", email);
        //                cmd.Parameters.AddWithValue("@phone", phone);
        //                cmd.Parameters.AddWithValue("@promocode", promocode);
        //                cmd.Parameters.AddWithValue("@ref_code", ref_code);
        //                cmd.Parameters.AddWithValue("@date_created", DateTime.Now.ToString());
        //                if (cmd.ExecuteNonQuery() > 0)
        //                {
        //                    flag = true;
        //                }
        //                else
        //                {
        //                    flag = false;
        //                }
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {

        //        ex.ToString();
        //    }

        //    return flag;

        //}

       
    }
}