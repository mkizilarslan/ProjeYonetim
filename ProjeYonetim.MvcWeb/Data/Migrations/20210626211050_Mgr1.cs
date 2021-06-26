using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjeYonetim.MvcWeb.Data.Migrations
{
    public partial class Mgr1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5c151f75-4003-4a3c-b9e2-601824921b4f", "3173a326-8d23-4a58-bbe8-cb9c88c461c1", "Admin", "ADMIN" },
                    { "60555580-6e0e-4c92-80b1-4c5782b4afd8", "324cf30d-5643-4d2d-a07d-cbe906387af3", "Sales", "SALES" },
                    { "8c6f88b0-8f71-47e0-9cf6-818dbed23b66", "38583b17-fc1a-4500-a6aa-1a3a5ed973b8", "Accounting", "ACCOUNTING" },
                    { "59952865-2e9b-4906-aa6d-683c4964d4b2", "e61f5ea3-1561-406a-afe9-9426914c7391", "SoftwareTeamLeader", "SOFTWARETEAMLEADER" },
                    { "72632f06-0f68-49e4-9645-31ff2acb58dd", "ab7ef182-7574-4966-9da4-daba7890a91f", "Software", "SOFTWARE" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "59952865-2e9b-4906-aa6d-683c4964d4b2");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "5c151f75-4003-4a3c-b9e2-601824921b4f");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "60555580-6e0e-4c92-80b1-4c5782b4afd8");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "72632f06-0f68-49e4-9645-31ff2acb58dd");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "8c6f88b0-8f71-47e0-9cf6-818dbed23b66");
        }
    }
}
