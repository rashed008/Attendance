﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace attendance.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class attendanceEntities4 : DbContext
    {
        public attendanceEntities4()
            : base("name=attendanceEntities4")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<emp> emps { get; set; }
        public virtual DbSet<personal_schedule> personal_schedule { get; set; }
        public virtual DbSet<schedule_info> schedule_info { get; set; }
        public virtual DbSet<signature> signatures { get; set; }
    }
}
