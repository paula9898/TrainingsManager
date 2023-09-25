using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingsManager.Backend.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class MigrationThree : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Activity_ActivityId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Activity_Running_ActivityId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Activity_Squatting_ActivityId",
                table: "Activity");

            migrationBuilder.DropForeignKey(
                name: "FK_Activity_Users_UserId",
                table: "Activity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Activity",
                table: "Activity");

            migrationBuilder.RenameTable(
                name: "Activity",
                newName: "Activities");

            migrationBuilder.RenameIndex(
                name: "IX_Activity_UserId",
                table: "Activities",
                newName: "IX_Activities_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Activity_Squatting_ActivityId",
                table: "Activities",
                newName: "IX_Activities_Squatting_ActivityId");

            migrationBuilder.RenameIndex(
                name: "IX_Activity_Running_ActivityId",
                table: "Activities",
                newName: "IX_Activities_Running_ActivityId");

            migrationBuilder.RenameIndex(
                name: "IX_Activity_ActivityId",
                table: "Activities",
                newName: "IX_Activities_ActivityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Activities",
                table: "Activities",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Activities_ActivityId",
                table: "Activities",
                column: "ActivityId",
                principalTable: "Activities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Activities_Running_ActivityId",
                table: "Activities",
                column: "Running_ActivityId",
                principalTable: "Activities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Activities_Squatting_ActivityId",
                table: "Activities",
                column: "Squatting_ActivityId",
                principalTable: "Activities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Activities_Users_UserId",
                table: "Activities",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Activities_ActivityId",
                table: "Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Activities_Running_ActivityId",
                table: "Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Activities_Squatting_ActivityId",
                table: "Activities");

            migrationBuilder.DropForeignKey(
                name: "FK_Activities_Users_UserId",
                table: "Activities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Activities",
                table: "Activities");

            migrationBuilder.RenameTable(
                name: "Activities",
                newName: "Activity");

            migrationBuilder.RenameIndex(
                name: "IX_Activities_UserId",
                table: "Activity",
                newName: "IX_Activity_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Activities_Squatting_ActivityId",
                table: "Activity",
                newName: "IX_Activity_Squatting_ActivityId");

            migrationBuilder.RenameIndex(
                name: "IX_Activities_Running_ActivityId",
                table: "Activity",
                newName: "IX_Activity_Running_ActivityId");

            migrationBuilder.RenameIndex(
                name: "IX_Activities_ActivityId",
                table: "Activity",
                newName: "IX_Activity_ActivityId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Activity",
                table: "Activity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Activity_ActivityId",
                table: "Activity",
                column: "ActivityId",
                principalTable: "Activity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Activity_Running_ActivityId",
                table: "Activity",
                column: "Running_ActivityId",
                principalTable: "Activity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Activity_Squatting_ActivityId",
                table: "Activity",
                column: "Squatting_ActivityId",
                principalTable: "Activity",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Activity_Users_UserId",
                table: "Activity",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
