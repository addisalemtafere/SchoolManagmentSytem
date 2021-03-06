﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using StudentManagmentHighSchool.Models;

namespace StudentManagmentHighSchool.Context
{
    public class SchoolStudentContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Admission> Admissions { get; set; }
        public DbSet<MarkList> MarkLists { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure StudentId as PK for StudentAddress
            modelBuilder.Entity<Address>()
                .HasKey(e => e.AddressId);

            // Configure StudentId as FK for StudentAddress
            modelBuilder.Entity<Student>()
                .HasRequired(s => s.Address)
                .WithRequiredPrincipal(ad => ad.Student);

            modelBuilder.Entity<Address>()
                .HasKey(e => e.AddressId);

            // Configure StudentId as FK for StudentAddress
            modelBuilder.Entity<Staff>()
                .HasRequired(s => s.Address)
                .WithRequiredPrincipal(ad => ad.Staff);
        }

    }
}