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
    
    public partial class SIMSUpload
    {
        public string ICCID { get; set; }
        public string IMSI { get; set; }
        public string MSISDN { get; set; }
        public string ADM { get; set; }
        public string PIN1 { get; set; }
        public string PIN2 { get; set; }
        public string PUK1 { get; set; }
        public string PUK2 { get; set; }
        public string EKI { get; set; }
        public string EOPC { get; set; }
        public Nullable<int> i_customer { get; set; }
        public Nullable<System.DateTime> DateAssigned { get; set; }
        public string Source { get; set; }
        public string SourceID { get; set; }
        public string ModemMac { get; set; }
        public string rMSISDN { get; set; }
        public string Username { get; set; }
        public long SIMInventoryID { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
    }
}
