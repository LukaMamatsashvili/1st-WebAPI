using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API___დამოუკიდებლად.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PersonTbl",
                columns: table => new
                {
                    id = table.Column<Guid>(nullable: false),
                    Firstname = table.Column<string>(maxLength: 10, nullable: false),
                    Lastname = table.Column<string>(maxLength: 20, nullable: false),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonTbl", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonTbl");
        }
    }
}
