using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Tenant
{
    public class TenantDbContext : DbContext
    {
        public DbSet<Tenant> Tenants { get; set; }
        public TenantDbContext(DbContextOptions<TenantDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Tenant>().HasData(
                new Tenant { Id = 1, Name = "test1", Host = "test1.com", ConnectionString = "server=(localdb)\\MSSQLLocalDB;database=test1;Trusted_Connection=true", UniqueId = Guid.NewGuid().ToString() },
                new Tenant { Id = 2, Name = "test2", Host = "test2.com", ConnectionString = "server=(localdb)\\MSSQLLocalDB;database=test2;Trusted_Connection=true", UniqueId = Guid.NewGuid().ToString() },
                new Tenant { Id =3, Name = "localhost", Host = "localhost", ConnectionString = "server=(localdb)\\MSSQLLocalDB;database=localhost;Trusted_Connection=true", UniqueId = Guid.NewGuid().ToString() }
            );
        }
    }
}
