﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Student1.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class StudentEntities : DbContext
    {
        public StudentEntities()
            : base("name=StudentEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Agunan> Agunans { get; set; }
        public virtual DbSet<Funding> Fundings { get; set; }
        public virtual DbSet<Lending> Lendings { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public IEnumerable<object> Users { get; internal set; }

        internal bool Verifying(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}