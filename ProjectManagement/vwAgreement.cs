//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjectManagement
{
    using System;
    using System.Collections.Generic;
    
    public partial class vwAgreement
    {
        public int Id { get; set; }
        public string AgmtId { get; set; }
        public int ProjectId { get; set; }
        public string ProjectPhase { get; set; }
        public string Title { get; set; }
        public Nullable<decimal> ApprovedPhdHr { get; set; }
        public Nullable<decimal> ApprovedMsHr { get; set; }
        public decimal PhdInvoiceHr { get; set; }
        public decimal MsInvoiceHr { get; set; }
        public string AgmtStatus { get; set; }
        public int CollabCtrId { get; set; }
        public string PIName { get; set; }
        public string ClientRefNum { get; set; }
        public string RequestDate { get; set; }
        public Nullable<decimal> ApprovedPhdRate { get; set; }
        public Nullable<decimal> PhdRemaining { get; set; }
        public Nullable<decimal> ApprovedMsRate { get; set; }
        public Nullable<decimal> MsRemaining { get; set; }
        public string ApprovalDate { get; set; }
        public string ClientApprovalDate { get; set; }
        public string CompletionDate { get; set; }
    }
}
