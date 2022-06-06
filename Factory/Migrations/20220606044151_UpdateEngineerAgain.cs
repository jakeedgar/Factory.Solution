using Microsoft.EntityFrameworkCore.Migrations;

namespace Factory.Migrations
{
    public partial class UpdateEngineerAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MachineId",
                table: "Engineers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MachineId",
                table: "Engineers");
        }
    }
}
