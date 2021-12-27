using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ForeignKeyPractice
{
    public class StudentContext : DbContext
    {
        public StudentContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=PC0456\MSSQL2017;Database=InfoDB;Trusted_Connection=True;");
        }

        public DbSet<Course> Courses { get; set; }
        public DbSet<student> Students { get; set; }
    }
}
