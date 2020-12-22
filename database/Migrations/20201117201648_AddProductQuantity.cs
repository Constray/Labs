using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.EFCore.Migrations
{
    public partial class DateToTimestamp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            Console.WriteLine("Start Product Quantity Update");
            migrationBuilder.UpdateData(
                "Product",
                "Id",
                1,
                "Quantity",
                42
            );
            
            migrationBuilder.UpdateData(
                "Product",
                "Id",
                2,
                "Quantity",
                413
            );
            
            migrationBuilder.UpdateData(
                "Product",
                "Id",
                3,
                "Quantity",
                92
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                "Product",
                "Id",
                1,
                "Quantity",
                0
            );
            
            migrationBuilder.UpdateData(
                "Product",
                "Id",
                2,
                "Quantity",
                0
            );
            
            migrationBuilder.UpdateData(
                "Product",
                "Id",
                3,
                "Quantity",
                0
            );
            Console.WriteLine("End Product Quantity Update");
        }
    }
}
