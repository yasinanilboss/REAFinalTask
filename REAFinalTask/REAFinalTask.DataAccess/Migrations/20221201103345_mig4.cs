using Microsoft.EntityFrameworkCore.Migrations;

namespace REAFinalTask.DataAccess.Migrations
{
    public partial class mig4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ToDoStatusEnum",
                table: "ToDos",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ToDoStatusEnum",
                table: "ToDos");
        }
    }
}
