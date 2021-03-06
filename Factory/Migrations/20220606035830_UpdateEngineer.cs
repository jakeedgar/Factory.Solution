using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class UpdateEngineer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Focus",
                table: "Engineers");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Focus",
                table: "Engineers",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
