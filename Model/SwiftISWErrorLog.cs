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
    
    public partial class SwiftISWErrorLog
    {
        public int LogID { get; set; }
        public Nullable<int> PaymentID { get; set; }
        public Nullable<int> ErrorCode { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> RequestDate { get; set; }
        public string PaymentType { get; set; }
        public Nullable<float> SuccessAmount { get; set; }
        public Nullable<float> SuccessDiscount { get; set; }
        public Nullable<int> CRMSuccess { get; set; }
        public string CRMErrorDesc { get; set; }
        public Nullable<System.DateTime> SwiftPaymentDate { get; set; }
    }
}
