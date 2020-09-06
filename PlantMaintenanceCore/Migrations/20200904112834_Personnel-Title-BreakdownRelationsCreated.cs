using Microsoft.EntityFrameworkCore.Migrations;

namespace PlantMaintenanceCore.Migrations
{
    public partial class PersonnelTitleBreakdownRelationsCreated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TitleId",
                table: "Personnels",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UrgencyId",
                table: "Breakdowns",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PlantId",
                table: "Breakdowns",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PersonnelRequestingId",
                table: "Breakdowns",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "PersonnelMaintenanceId",
                table: "Breakdowns",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "MachineId",
                table: "Breakdowns",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BreakdownTypeId",
                table: "Breakdowns",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Personnels_TitleId",
                table: "Personnels",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_Breakdowns_BreakdownTypeId",
                table: "Breakdowns",
                column: "BreakdownTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Breakdowns_MachineId",
                table: "Breakdowns",
                column: "MachineId");

            migrationBuilder.CreateIndex(
                name: "IX_Breakdowns_PersonnelMaintenanceId",
                table: "Breakdowns",
                column: "PersonnelMaintenanceId");

            migrationBuilder.CreateIndex(
                name: "IX_Breakdowns_PersonnelRequestingId",
                table: "Breakdowns",
                column: "PersonnelRequestingId");

            migrationBuilder.CreateIndex(
                name: "IX_Breakdowns_PlantId",
                table: "Breakdowns",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_Breakdowns_UrgencyId",
                table: "Breakdowns",
                column: "UrgencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_Breakdowns_BreakdownTypes_BreakdownTypeId",
                table: "Breakdowns",
                column: "BreakdownTypeId",
                principalTable: "BreakdownTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Breakdowns_Machines_MachineId",
                table: "Breakdowns",
                column: "MachineId",
                principalTable: "Machines",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Breakdowns_Personnels_PersonnelMaintenanceId",
                table: "Breakdowns",
                column: "PersonnelMaintenanceId",
                principalTable: "Personnels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Breakdowns_Personnels_PersonnelRequestingId",
                table: "Breakdowns",
                column: "PersonnelRequestingId",
                principalTable: "Personnels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Breakdowns_Plants_PlantId",
                table: "Breakdowns",
                column: "PlantId",
                principalTable: "Plants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Breakdowns_Urgencies_UrgencyId",
                table: "Breakdowns",
                column: "UrgencyId",
                principalTable: "Urgencies",
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Breakdowns_BreakdownTypes_BreakdownTypeId",
                table: "Breakdowns");

            migrationBuilder.DropForeignKey(
                name: "FK_Breakdowns_Machines_MachineId",
                table: "Breakdowns");

            migrationBuilder.DropForeignKey(
                name: "FK_Breakdowns_Personnels_PersonnelMaintenanceId",
                table: "Breakdowns");

            migrationBuilder.DropForeignKey(
                name: "FK_Breakdowns_Personnels_PersonnelRequestingId",
                table: "Breakdowns");

            migrationBuilder.DropForeignKey(
                name: "FK_Breakdowns_Plants_PlantId",
                table: "Breakdowns");

            migrationBuilder.DropForeignKey(
                name: "FK_Breakdowns_Urgencies_UrgencyId",
                table: "Breakdowns");

            migrationBuilder.DropForeignKey(
                name: "FK_Personnels_Titles_TitleId",
                table: "Personnels");

            migrationBuilder.DropIndex(
                name: "IX_Personnels_TitleId",
                table: "Personnels");

            migrationBuilder.DropIndex(
                name: "IX_Breakdowns_BreakdownTypeId",
                table: "Breakdowns");

            migrationBuilder.DropIndex(
                name: "IX_Breakdowns_MachineId",
                table: "Breakdowns");

            migrationBuilder.DropIndex(
                name: "IX_Breakdowns_PersonnelMaintenanceId",
                table: "Breakdowns");

            migrationBuilder.DropIndex(
                name: "IX_Breakdowns_PersonnelRequestingId",
                table: "Breakdowns");

            migrationBuilder.DropIndex(
                name: "IX_Breakdowns_PlantId",
                table: "Breakdowns");

            migrationBuilder.DropIndex(
                name: "IX_Breakdowns_UrgencyId",
                table: "Breakdowns");

            migrationBuilder.AlterColumn<string>(
                name: "TitleId",
                table: "Personnels",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UrgencyId",
                table: "Breakdowns",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PlantId",
                table: "Breakdowns",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonnelRequestingId",
                table: "Breakdowns",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "PersonnelMaintenanceId",
                table: "Breakdowns",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MachineId",
                table: "Breakdowns",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BreakdownTypeId",
                table: "Breakdowns",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
