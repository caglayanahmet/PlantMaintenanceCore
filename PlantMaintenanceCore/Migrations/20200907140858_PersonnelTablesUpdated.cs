using Microsoft.EntityFrameworkCore.Migrations;

namespace PlantMaintenanceCore.Migrations
{
    public partial class PersonnelTablesUpdated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personnels_Roles_RoleId1",
                table: "Personnels");

            migrationBuilder.DropForeignKey(
                name: "FK_Personnels_Titles_TitleId",
                table: "Personnels");

            migrationBuilder.DropIndex(
                name: "IX_Personnels_RoleId1",
                table: "Personnels");

            migrationBuilder.DropColumn(
                name: "RoleId1",
                table: "Personnels");

            migrationBuilder.AlterColumn<string>(
                name: "TitleName",
                table: "Titles",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "TitleId",
                table: "Personnels",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "RoleId",
                table: "Personnels",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_RoleId",
                table: "Personnels",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Personnels_Roles_RoleId",
                table: "Personnels",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Personnels_Titles_TitleId",
                table: "Personnels",
                column: "TitleId",
                principalTable: "Titles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personnels_Roles_RoleId",
                table: "Personnels");

            migrationBuilder.DropForeignKey(
                name: "FK_Personnels_Titles_TitleId",
                table: "Personnels");

            migrationBuilder.DropIndex(
                name: "IX_Personnels_RoleId",
                table: "Personnels");

            migrationBuilder.AlterColumn<string>(
                name: "TitleName",
                table: "Titles",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string));

            migrationBuilder.AlterColumn<int>(
                name: "TitleId",
                table: "Personnels",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<string>(
                name: "RoleId",
                table: "Personnels",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "RoleId1",
                table: "Personnels",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_RoleId1",
                table: "Personnels",
                column: "RoleId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Personnels_Roles_RoleId1",
                table: "Personnels",
                column: "RoleId1",
                principalTable: "Roles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Personnels_Titles_TitleId",
                table: "Personnels",
                column: "TitleId",
                principalTable: "Titles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
