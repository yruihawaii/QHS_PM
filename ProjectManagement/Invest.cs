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
    
    public partial class Invest
    {
        public Invest()
        {
            this.Projects = new HashSet<Project>();
            this.JabsomAffils = new HashSet<JabsomAffil>();
            this.GrantPIs = new HashSet<GrantPI>();
            this.Project2 = new HashSet<Project2>();
        }
    
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int InvestStatusId { get; set; }
        public bool IsApproved { get; set; }
        public string HashValue { get; set; }
        public string NonUHClient { get; set; }
        public string NonHawaiiClient { get; set; }
        public bool IsPilot { get; set; }
        public string OtherDegree { get; set; }
        public string OtherCommunityPartner { get; set; }
    
        public virtual InvestStatus InvestStatu { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
        public virtual ICollection<JabsomAffil> JabsomAffils { get; set; }
        public virtual ICollection<GrantPI> GrantPIs { get; set; }
        public virtual ICollection<Project2> Project2 { get; set; }
    }
}
