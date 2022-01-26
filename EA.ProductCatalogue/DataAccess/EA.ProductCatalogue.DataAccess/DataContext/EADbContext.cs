using EA.ProductCatalogue.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.ProductCatalogue.DataAccess.DataContext
{
    public class EADbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public EADbContext(DbContextOptions<EADbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().Property(p => p.Name).IsRequired()
                                                                .HasMaxLength(100);

            modelBuilder.Entity<Category>().HasMany(x => x.Products)
                                           .WithOne(p => p.Category)
                                           .HasForeignKey(p => p.CategoryId)
                                           .OnDelete(DeleteBehavior.SetNull);
           

            //modelBuilder.Entity<Product>().HasOne(x=>x.Category)
            //                              .WithMany(c=>c.Products)
                                          
        }
    }
}
