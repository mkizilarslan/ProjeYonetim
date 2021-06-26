using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjeYonetim.Data.Migrations
{
    public partial class InitMgr4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Employees",
                type: "date",
                nullable: false,
                defaultValueSql: "getdate()",
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValueSql: "CURRENT_TIMESTAMP");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Employees",
                type: "date",
                nullable: false,
                defaultValueSql: "CURRENT_TIMESTAMP",
                oldClrType: typeof(DateTime),
                oldType: "date",
                oldDefaultValueSql: "getdate()");
        }
    }
}
