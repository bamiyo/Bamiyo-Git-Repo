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
    
    public partial class CreditLimitNotification
    {
        public int NotificationID { get; set; }
        public int i_customer { get; set; }
        public int Type { get; set; }
        public System.DateTime NotificationDate { get; set; }
        public Nullable<double> Balance { get; set; }
        public Nullable<double> CreditLimit { get; set; }
        public string EmailMessage { get; set; }
        public string SMSMessage { get; set; }
        public string EmailAddress { get; set; }
        public string Phone { get; set; }
    }
}