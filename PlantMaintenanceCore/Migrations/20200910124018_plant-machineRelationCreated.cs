using Microsoft.EntityFrameworkCore.Migrations;

namespace PlantMaintenanceCore.Migrations
{
    public partial class plantmachineRelationCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PlantId",
                table: "Machines",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Machines_PlantId",
                table: "Machines",
                column: "PlantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Machines_Plants_PlantId",
                table: "Machines",
                column: "PlantId",
                principalTable: "Plants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Machines_Plants_PlantId",
                table: "Machines");

            migrationBuilder.DropIndex(
                name: "IX_Machines_PlantId",
                table: "Machines");

            migrationBuilder.AlterColumn<int>(
                name: "PlantId",
                table: "Machines",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
