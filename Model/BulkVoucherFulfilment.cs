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
    
    public partial class BulkVoucherFulfilment
    {
        public int BulkVoucherID { get; set; }
        public Nullable<int> i_customer { get; set; }
        public Nullable<double> Value { get; set; }
        public Nullable<int> MinimumCount { get; set; }
        public Nullable<int> Count { get; set; }
        public Nullable<double> Percentage { get; set; }
        public Nullable<double> Discount { get; set; }
        public Nullable<double> Payable { get; set; }
        public Nullable<System.DateTime> DateCreated { get; set; }
        public Nullable<int> Generated { get; set; }
        public Nullable<int> BatchID { get; set; }
        public string GenerationFlag { get; set; }
        public Nullable<System.DateTime> DateGenerated { get; set; }
        public Nullable<int> Sent { get; set; }
        public Nullable<System.DateTime> DateSent { get; set; }
        public string PurchaseOnlineID { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
    }
}
