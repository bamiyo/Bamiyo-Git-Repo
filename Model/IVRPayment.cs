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
    
    public partial class IVRPayment
    {
        public int PaymentID { get; set; }
        public Nullable<int> i_customer { get; set; }
        public Nullable<int> i_account { get; set; }
        public Nullable<double> amount { get; set; }
        public Nullable<System.DateTime> PaymentDate { get; set; }
        public Nullable<int> i_product { get; set; }
        public string macAddress { get; set; }
        public string ProductName { get; set; }
        public Nullable<int> Status { get; set; }
        public string aXDR { get; set; }
        public string cXDR { get; set; }
        public string aPaymentUID { get; set; }
        public string cPaymentUID { get; set; }
        public string R_apaymentUID { get; set; }
        public string R_cpaymentUID { get; set; }
        public Nullable<double> R_Amount { get; set; }
        public Nullable<int> R_Status { get; set; }
        public Nullable<System.DateTime> R_Date { get; set; }
        public Nullable<System.DateTime> AllocationEffectiveDate { get; set; }
        public Nullable<System.DateTime> AllocationExpirationDate { get; set; }
        public Nullable<int> Months { get; set; }
    }
}