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
    
    public partial class FailedPortaOneTransactionNote
    {
        public int FailedID { get; set; }
        public Nullable<int> DescriptionLogID { get; set; }
        public Nullable<int> i_customer { get; set; }
        public Nullable<int> i_account { get; set; }
        public Nullable<double> balance { get; set; }
        public string source { get; set; }
        public string transid { get; set; }
        public string action { get; set; }
        public Nullable<int> credit { get; set; }
        public Nullable<int> extension { get; set; }
        public Nullable<int> usebalance { get; set; }
        public Nullable<int> charge { get; set; }
        public Nullable<int> billingcycle { get; set; }
        public Nullable<int> blockacct { get; set; }
    }
}