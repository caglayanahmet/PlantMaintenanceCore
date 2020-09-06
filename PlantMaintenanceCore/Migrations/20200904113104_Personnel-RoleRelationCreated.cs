using Microsoft.EntityFrameworkCore.Migrations;

namespace PlantMaintenanceCore.Migrations
{
    public partial class PersonnelRoleRelationCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RoleId1",
                table: "Personnels",
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Personnels_Roles_RoleId1",
                table: "Personnels");

            migrationBuilder.DropIndex(
                name: "IX_Personnels_RoleId1",
                table: "Personnels");

            migrationBuilder.DropColumn(
                name: "RoleId1",
                table: "Personnels");
        }
    }
}
