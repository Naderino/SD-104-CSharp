﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EricsTestMVC.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RPGGameEricEntities : DbContext
    {
        public RPGGameEricEntities()
            : base("name=RPGGameEricEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Hero> Heroes { get; set; }
        public virtual DbSet<Weapon> Weapons { get; set; }
        public virtual DbSet<Monster> Monsters { get; set; }
    }
}
