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
    
    public partial class Batch
    {
        public int Batch_ID { get; set; }
        public string BatchName { get; set; }
        public int NoOfVouchers { get; set; }
        public System.DateTime EntryDate { get; set; }
        public string UserName { get; set; }
        public string Comments { get; set; }
        public Nullable<int> eVoucher { get; set; }
        public Nullable<int> Status { get; set; }
    }
}
