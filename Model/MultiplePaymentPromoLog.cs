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
    
    public partial class MultiplePaymentPromoLog
    {
        public int ID { get; set; }
        public int i_customer { get; set; }
        public Nullable<int> i_account { get; set; }
        public string macAddress { get; set; }
        public Nullable<int> i_product { get; set; }
        public System.DateTime dateCreated { get; set; }
        public double totalAmountPaid { get; set; }
        public string paymentRef { get; set; }
        public Nullable<System.DateTime> paymentDate { get; set; }
        public Nullable<double> promoAmount { get; set; }
        public Nullable<int> promoDays { get; set; }
        public int credited { get; set; }
        public Nullable<System.DateTime> dateCredited { get; set; }
        public string bonusRef { get; set; }
    }
}
