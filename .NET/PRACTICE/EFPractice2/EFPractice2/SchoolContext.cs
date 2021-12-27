﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFPractice2
{
    public class SchoolContext : DbContext
    {
        public SchoolContext()
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=PC0456\MSSQL2017;Database=SchoolDB;Trusted_Connection=True;");
        }

    }
}
