﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication1.Tenant;

namespace MultiTenant.Migrations
{
    [DbContext(typeof(TenantDbContext))]
    partial class TenantDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0-preview.3.20181.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication1.Tenant.Tenant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConnectionString")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Host")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UniqueId")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Tenants");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConnectionString = "server=(localdb)\\MSSQLLocalDB;database=test1;Trusted_Connection=true",
                            Host = "test1.com",
                            Name = "test1",
                            UniqueId = "7e392db4-b34a-4a80-bfd9-ee3456a5dcec"
                        },
                        new
                        {
                            Id = 2,
                            ConnectionString = "server=(localdb)\\MSSQLLocalDB;database=test2;Trusted_Connection=true",
                            Host = "test2.com",
                            Name = "test2",
                            UniqueId = "179ca59b-8955-48b7-8635-6d9b004616b4"
                        },
                        new
                        {
                            Id = 3,
                            ConnectionString = "server=(localdb)\\MSSQLLocalDB;database=localhost;Trusted_Connection=true",
                            Host = "localhost",
                            Name = "localhost",
                            UniqueId = "e7b6942a-9810-4356-b829-b1af82d30d39"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}