using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjeYonetim.Data.Migrations
{
    public partial class Mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Sales_Projects_ProjectId",
                table: "Sales");

            migrationBuilder.DropIndex(
                name: "IX_Sales_ProjectId",
                table: "Sales");

            migrationBuilder.DropColumn(
                name: "ProjectId",
                table: "Sales");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ProjectId",
                table: "Sales",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Sales_ProjectId",
                table: "Sales",
                column: "ProjectId");

            migrationBuilder.AddForeignKey(
                name: "FK_Sales_Projects_ProjectId",
                table: "Sales",
                column: "ProjectId",
                principalTable: "Projects",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
