using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace LoanAPI.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "LoandId", "InterestRate", "LoanType" },
                values: new object[] { new Guid("96a7ebc6-65b2-4c7a-96bc-4daac6a5b237"), 3.5, "Housing loan" });

            migrationBuilder.InsertData(
                table: "Loans",
                columns: new[] { "LoandId", "InterestRate", "LoanType" },
                values: new object[] { new Guid("b6014483-03ac-4829-8b0b-ad2627542df4"), 5.2999999999999998, "Car loan" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoandId",
                keyValue: new Guid("96a7ebc6-65b2-4c7a-96bc-4daac6a5b237"));

            migrationBuilder.DeleteData(
                table: "Loans",
                keyColumn: "LoandId",
                keyValue: new Guid("b6014483-03ac-4829-8b0b-ad2627542df4"));
        }
    }
}
