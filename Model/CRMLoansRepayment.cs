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
    
    public partial class CRMLoansRepayment
    {
        public int LoanRepaymentID { get; set; }
        public int i_Loan { get; set; }
        public string PaymentSource { get; set; }
        public string PaymentRef { get; set; }
        public double AmountPaid { get; set; }
        public System.DateTime DatePaid { get; set; }
    }
}
