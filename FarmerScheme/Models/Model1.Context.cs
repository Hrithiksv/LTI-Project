﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FarmerScheme.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class FarmerSchemeEntities : DbContext
    {
        public FarmerSchemeEntities()
            : base("name=FarmerSchemeEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Farmer> Farmers { get; set; }
        public virtual DbSet<Crop> Crops { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
