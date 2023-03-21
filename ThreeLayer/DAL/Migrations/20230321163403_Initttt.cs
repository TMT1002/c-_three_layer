using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    /// <inheritdoc />
    public partial class Initttt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Accounts_AccountID",
                table: "Devices");

            migrationBuilder.RenameColumn(
                name: "AccountID",
                table: "Devices",
                newName: "AccountId");

            migrationBuilder.RenameIndex(
                name: "IX_Devices_AccountID",
                table: "Devices",
                newName: "IX_Devices_AccountId");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Accounts_AccountId",
                table: "Devices",
                column: "AccountId",
                principalTable: "Accounts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Accounts_AccountId",
                table: "Devices");

            migrationBuilder.RenameColumn(
                name: "AccountId",
                table: "Devices",
                newName: "AccountID");

            migrationBuilder.RenameIndex(
                name: "IX_Devices_AccountId",
                table: "Devices",
                newName: "IX_Devices_AccountID");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Accounts_AccountID",
                table: "Devices",
                column: "AccountID",
                principalTable: "Accounts",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
