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
    
    public partial class Grant
    {
        public Grant()
        {
            this.GrantBiostats = new HashSet<GrantBiostat>();
            this.GrantPIs = new HashSet<GrantPI>();
        }
    
        public int Id { get; set; }
        public string Collab { get; set; }
        public string HealthInit { get; set; }
        public bool NativeHawaiian { get; set; }
        public string GrantTitle { get; set; }
        public string GrantCategory { get; set; }
        public string GrantType { get; set; }
        public string PgmAnn { get; set; }
        public string FundAgcy { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public Nullable<int> FirstYrAmt { get; set; }
        public Nullable<int> TotalAmt { get; set; }
        public Nullable<int> MyGrantNum { get; set; }
        public Nullable<System.DateTime> SubDeadline { get; set; }
        public string GrantStatus { get; set; }
        public Nullable<System.DateTime> SubDate { get; set; }
        public string FundStatus { get; set; }
        public Nullable<System.DateTime> FundDate { get; set; }
        public string Fundnum { get; set; }
        public Nullable<int> TotalCost { get; set; }
        public string Followup { get; set; }
        public Nullable<System.DateTime> InitDate { get; set; }
        public int ProjectId { get; set; }
        public bool IsInternal { get; set; }
        public string Comment { get; set; }
    
        public virtual ICollection<GrantBiostat> GrantBiostats { get; set; }
        public virtual ICollection<GrantPI> GrantPIs { get; set; }
        public virtual Project2 Project2 { get; set; }
    }
}