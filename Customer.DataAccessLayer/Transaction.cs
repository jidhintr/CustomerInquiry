//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Customer.DataAccessLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transaction
    {
        public int TransactionId { get; set; }
        public Nullable<System.DateTime> TransactionDate { get; set; }
        public decimal Amount { get; set; }
        public string Currency { get; set; }
        public string Status { get; set; }
        public long CustomerId { get; set; }
    
        public virtual Customer Customer { get; set; }
    }
}
