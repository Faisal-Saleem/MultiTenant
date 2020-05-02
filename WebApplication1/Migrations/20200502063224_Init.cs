using Microsoft.EntityFrameworkCore.Migrations;

namespace MultiTenant.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tenants",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Host = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConnectionString = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UniqueId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tenants", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tenants",
                columns: new[] { "Id", "ConnectionString", "Host", "Name", "UniqueId" },
                values: new object[] { 1, "server=(localdb)\\MSSQLLocalDB;database=test1;Trusted_Connection=true", "test1.com", "test1", "7e392db4-b34a-4a80-bfd9-ee3456a5dcec" });

            migrationBuilder.InsertData(
                table: "Tenants",
                columns: new[] { "Id", "ConnectionString", "Host", "Name", "UniqueId" },
                values: new object[] { 2, "server=(localdb)\\MSSQLLocalDB;database=test2;Trusted_Connection=true", "test2.com", "test2", "179ca59b-8955-48b7-8635-6d9b004616b4" });

            migrationBuilder.InsertData(
                table: "Tenants",
                columns: new[] { "Id", "ConnectionString", "Host", "Name", "UniqueId" },
                values: new object[] { 3, "server=(localdb)\\MSSQLLocalDB;database=localhost;Trusted_Connection=true", "localhost", "localhost", "e7b6942a-9810-4356-b829-b1af82d30d39" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tenants");
        }
    }
}
