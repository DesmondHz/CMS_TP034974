﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMS_TP034974.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CMSDatabaseEntities1 : DbContext
    {
        public CMSDatabaseEntities1()
            : base("name=CMSDatabaseEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Cargo> Cargoes { get; set; }
        public virtual DbSet<CargoBooking> CargoBookings { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Shiptransaction> Shiptransactions { get; set; }
        public virtual DbSet<Warehouse> Warehouses { get; set; }
    }
}
