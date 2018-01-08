﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ProjectTrackerContainer : DbContext
    {
        public ProjectTrackerContainer()
            : base("name=ProjectTrackerContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Invest> Invests { get; set; }
        public virtual DbSet<InvestStatus> InvestStatus { get; set; }
        public virtual DbSet<ServiceType> ServiceTypes { get; set; }
        public virtual DbSet<BioStatGroup> BioStatGroups { get; set; }
        public virtual DbSet<BioStat> BioStats { get; set; }
        public virtual DbSet<GrantApp> GrantApps { get; set; }
        public virtual DbSet<GrantAffil> GrantAffils { get; set; }
        public virtual DbSet<Pilot> Pilots { get; set; }
        public virtual DbSet<HiProgram> HiPrograms { get; set; }
        public virtual DbSet<EthnicGroup> EthnicGroups { get; set; }
        public virtual DbSet<JabsomDept> JabsomDepts { get; set; }
        public virtual DbSet<JabsomOffice> JabsomOffices { get; set; }
        public virtual DbSet<JabsomAffil> JabsomAffils { get; set; }
        public virtual DbSet<Conference> Conferences { get; set; }
        public virtual DbSet<Jounral> Jounrals { get; set; }
        public virtual DbSet<Date> Dates { get; set; }
        public virtual DbSet<Publication> Publications { get; set; }
        public virtual DbSet<TimeEntry> TimeEntries { get; set; }
        public virtual DbSet<ProjectGrant> ProjectGrants { get; set; }
        public virtual DbSet<ProjectGrant1> ProjectGrant1 { get; set; }
    }
}