using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ContactManager.Migrations
{
    public partial class teste2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Contacts",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Naaaaaaaaaaaaame",
                table: "Contacts",
                newName: "Name");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Contacts",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Contacts",
                newName: "Naaaaaaaaaaaaame");
        }
    }
}
