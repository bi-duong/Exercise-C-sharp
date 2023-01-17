using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3.Models
{
    public partial class MyStoreContext : DbContext
    {
        
        public MyStoreContext() { }
        public MyStoreContext(DbContextOptions<MyStoreContext> options) : base(options) { }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Product> Product { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=LAPTOP-NJE9TDC5;uid=sa;pwd=123123;Database=test2;TrustServerCertificate=true", options => options.EnableRetryOnFailure(maxRetryCount: 10,
                maxRetryDelay: TimeSpan.FromSeconds(10),
                errorNumbersToAdd: null));
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latinl_General CPI CI AS");
            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(15)
                    .UseCollation("Vietnamese_CI_AS");
            });
            modelBuilder.Entity<Product>(entity =>


            {

                entity.Property(e => e.ProductId).HasColumnName("ProductID");
                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");
                entity.Property(e => e.ProductName)
                 .IsRequired()
                 .HasMaxLength(40)
                 .UseCollation("Vietnamese_CI_AS");
                entity.Property(e => e.UnitPrice).HasColumnType("money");
                entity.HasOne(d => d.Category)
                     .WithMany(p => p.Products)
                     .HasForeignKey(d => d.CategoryId)
                     .OnDelete(DeleteBehavior.ClientSetNull)
                     .HasConstraintName("FK Products Categories");

            });

            OnModelCreatingPartial(modelBuilder);
        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
