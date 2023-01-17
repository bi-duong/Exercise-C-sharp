using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;

namespace WinFormsApp1
{
    public class Category
    {
        public Category() { }
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
    public class MyStock : DbContext
    {
        public MyStock() { }
        public DbSet<Category> Categories { get; set; }
        public const string ConnectStrring = "Server=LAPTOP-NJE9TDC5;uid=sa;pwd=123123;Database=test2,Trusted_Connection=SSPI;TrustServerCertificate=true";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
          
        
            optionsBuilder.UseSqlServer(ConnectStrring);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>()
              .Property(category => category.CategoryName)
              .IsRequired() 
              .HasMaxLength(40);
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = 4, CategoryName = "Beverages" },
                new Category { CategoryID = 2, CategoryName = "Condiments" },
                new Category { CategoryID = 3, CategoryName = "Confections" }
             );
        }
    }
}
