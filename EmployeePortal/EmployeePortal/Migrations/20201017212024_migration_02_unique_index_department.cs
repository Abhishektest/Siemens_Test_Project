using System.Security.Cryptography.X509Certificates;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeePortal.Migrations
{
    public partial class migration_02_unique_index_department : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "Department_I_IX",
                table: "Departments",
                column: "Name",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
