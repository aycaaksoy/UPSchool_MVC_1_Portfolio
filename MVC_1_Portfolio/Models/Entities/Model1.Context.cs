﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC_1_Portfolio.Models.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class UpSchoolPortfolioEntities1 : DbContext
    {
        public UpSchoolPortfolioEntities1()
            : base("name=UpSchoolPortfolioEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<About> Abouts { get; set; }
        public virtual DbSet<Admin> Admins { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<ServicesFeature> ServicesFeatures { get; set; }
        public virtual DbSet<Testimonial> Testimonials { get; set; }
    }
}
