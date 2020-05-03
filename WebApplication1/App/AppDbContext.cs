using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Tenant;

namespace WebApplication1.App
{
    public class AppDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }

        /*  
         *  To get ConnectionString from database for a specific Tenant. 
         *  Instead of returning connection string, tenantProvider return Tenant for future use
        */

        public ITenantProvider tenantProvider;

        public AppDbContext(DbContextOptions<AppDbContext> options, ITenantProvider tenantProvider): base(options)
        {
            this.tenantProvider = tenantProvider;
            this.Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (tenantProvider.GetTenant() != null)
            {
                optionsBuilder.UseSqlServer(tenantProvider.GetTenant().ConnectionString);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Employee>().HasData(
                new Employee { Id = 1, Name = "A", Email = "a@a.com" },
                new Employee { Id = 2, Name = "B", Email = "B@B.com" }
            );
        }
    }
}
