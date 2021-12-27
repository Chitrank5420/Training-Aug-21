using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Models
{
    public class CompanyContext : DbContext
    {
        public CompanyContext()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=PC0456\MSSQL2017;Database=CompanyDb;Trusted_Connection=True");
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Plant> Plants { get; set; }
        public DbSet<Toy> Toys { get; set; }
        public DbSet<Schemes> Schemes { get; set; }
    }
}
