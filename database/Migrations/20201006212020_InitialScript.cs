using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Database.EFCore.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            Console.WriteLine("Start Product Initialization");
            migrationBuilder.CreateTable(
                "Product",
                table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy",
                            NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Code = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table => { table.PrimaryKey("PK_Product", x => x.Id); }
            );

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] {"Id", "Code", "Name", "CreationDate", "Quantity"},
                values: new object[,]
                {
                    {1, "0001", "Cool Product", new DateTime(2020, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 0},
                    {2, "0002", "Not So Cool Product",new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0},
                    {3, "0033", "Very Cool Product", new DateTime(2020, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 0}
                });
            
            Console.WriteLine("End Product Initialization");
            
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");
        }
    }
}