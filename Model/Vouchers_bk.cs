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
    
    public partial class Vouchers_bk
    {
        public int VoucherID { get; set; }
        public string Voucher { get; set; }
        public float Value { get; set; }
        public int Batch_ID { get; set; }
        public System.DateTime EntryDate { get; set; }
        public Nullable<int> Purchased { get; set; }
        public string PurchasedBy { get; set; }
        public string PurchaseOnlineID { get; set; }
        public Nullable<System.DateTime> PurchasedDate { get; set; }
        public string VoucherStatus { get; set; }
    }
}
