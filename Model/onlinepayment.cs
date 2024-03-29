//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace VoucherTemplates.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class onlinepayment
    {
        public string ID { get; set; }
        public string Gateway { get; set; }
        public int CustomerID { get; set; }
        public float Amount { get; set; }
        public string Product { get; set; }
        public Nullable<int> Account { get; set; }
        public Nullable<int> ProductID { get; set; }
        public string ResponseCode { get; set; }
        public string ResponseDesc { get; set; }
        public System.DateTime EntryDate { get; set; }
        public string New_Online_User { get; set; }
        public string Card_Number { get; set; }
        public string Returned_Reference { get; set; }
        public string IPAddress { get; set; }
        public Nullable<int> BillingUpdated { get; set; }
        public string BillingTransID { get; set; }
        public string Charge_TransID { get; set; }
        public string Allocation_TransID { get; set; }
        public string Step_Status { get; set; }
        public Nullable<int> ConfirmCalled { get; set; }
        public Nullable<int> RequeryCount { get; set; }
        public string RequerySource { get; set; }
        public string OrderID { get; set; }
        public string SessionID { get; set; }
        public string PayURL { get; set; }
        public string PromoCode { get; set; }
        public Nullable<float> PromoPercent { get; set; }
        public string ModemType { get; set; }
        public string Reg_Encoded_Password { get; set; }
        public Nullable<double> Gateway_Returned_Amount { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public Nullable<int> TradeIn { get; set; }
        public string ProductName { get; set; }
        public string aPaymentUID { get; set; }
        public string cPaymentUID { get; set; }
        public string R_apaymentUID { get; set; }
        public string R_cpaymentUID { get; set; }
        public Nullable<double> R_Amount { get; set; }
        public Nullable<int> R_Status { get; set; }
        public Nullable<System.DateTime> R_Date { get; set; }
        public Nullable<double> DiscountAmount { get; set; }
        public Nullable<System.DateTime> AllocationEffectiveDate { get; set; }
        public Nullable<System.DateTime> AllocationExpirationDate { get; set; }
        public Nullable<int> Months { get; set; }
        public Nullable<double> IncentiveAmount { get; set; }
    }
}
