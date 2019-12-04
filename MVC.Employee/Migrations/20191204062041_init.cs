using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MVC.Employee.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Family = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    AccountNumber = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AccountNumber", "Age", "Family", "Name" },
                values: new object[] { new Guid("a8868477-e816-4377-976e-9371df821701"), "123-4754-4145", 36, "poori", "Rebwar" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "AccountNumber", "Age", "Family", "Name" },
                values: new object[] { new Guid("a437bd3a-f9c5-47fc-80e0-cac391786834"), "123-4554-5323", 35, "Alizade", "Ali" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
