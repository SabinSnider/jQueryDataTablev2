﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace jQueryDataTablev2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DatabaseDataTableEntities2 : DbContext
    {
        public DatabaseDataTableEntities2()
            : base("name=DatabaseDataTableEntities2")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customers1> Customers1 { get; set; }
    }
}
