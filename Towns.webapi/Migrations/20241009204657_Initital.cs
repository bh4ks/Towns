using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Towns.webapi.Migrations
{
    /// <inheritdoc />
    public partial class Initital : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Towns",
                columns: table => new
                {
                    TownID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TownName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Towns", x => x.TownID);
                });

            migrationBuilder.InsertData(
                table: "Towns",
                columns: new[] { "TownID", "TownName" },
                values: new object[,]
                {
                    { new Guid("0d071e81-29ff-4c8c-999d-fddcc1423bc3"), "Plumtree" },
                    { new Guid("4d99a283-6e7f-4fcc-a548-c9f521f4dfb0"), "Bulawayo" },
                    { new Guid("61766988-2121-440b-ac8a-bd0d37d13c7c"), "Mochudi" },
                    { new Guid("7b1442fd-356f-4871-8c88-bcce0b8e5410"), "Gaborone" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Towns");
        }
    }
}
