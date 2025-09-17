using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AspCoreCrudProject.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblEmployees",
                columns: table => new
                {
                    Emp_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Emp_Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Age = table.Column<int>(type: "int", nullable: false),
                    Emp_Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_JoiningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Designation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Emp_Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblEmployees", x => x.Emp_Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblEmployees");
        }
    }
}
