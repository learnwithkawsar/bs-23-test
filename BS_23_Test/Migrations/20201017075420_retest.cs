using Microsoft.EntityFrameworkCore.Migrations;

namespace BS_23_Test.Migrations
{
    public partial class retest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PostId",
                table: "Post");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PostId",
                table: "Post",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
