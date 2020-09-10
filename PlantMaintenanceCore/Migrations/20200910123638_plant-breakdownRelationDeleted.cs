using Microsoft.EntityFrameworkCore.Migrations;

namespace PlantMaintenanceCore.Migrations
{
    public partial class plantbreakdownRelationDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Breakdowns_Plants_PlantId",
                table: "Breakdowns");

            migrationBuilder.DropIndex(
                name: "IX_Breakdowns_PlantId",
                table: "Breakdowns");

            migrationBuilder.DropColumn(
                name: "PlantId",
                table: "Breakdowns");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlantId",
                table: "Breakdowns",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Breakdowns_PlantId",
                table: "Breakdowns",
                column: "PlantId");

            migrationBuilder.AddForeignKey(
                name: "FK_Breakdowns_Plants_PlantId",
                table: "Breakdowns",
                column: "PlantId",
                principalTable: "Plants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
