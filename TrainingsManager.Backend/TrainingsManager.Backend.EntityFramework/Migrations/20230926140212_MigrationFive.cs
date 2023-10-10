using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingsManager.Backend.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class MigrationFive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropIndex(
                name: "IX_Activities_ActivityId",
                table: "Activities");

            migrationBuilder.DropIndex(
                name: "IX_Activities_Running_ActivityId",
                table: "Activities");

            migrationBuilder.DropIndex(
                name: "IX_Activities_Squatting_ActivityId",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "ActivityId",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "Distance",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "Pace",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "Running_ActivityId",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "Running_Distance",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "Running_Pace",
                table: "Activities");

            migrationBuilder.DropColumn(
                name: "Squatting_ActivityId",
                table: "Activities");

            migrationBuilder.CreateTable(
                name: "Cyclings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Pace = table.Column<TimeSpan>(type: "time", nullable: false),
                    Distance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cyclings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cyclings_Activities_Id",
                        column: x => x.Id,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Runnings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Pace = table.Column<TimeSpan>(type: "time", nullable: false),
                    Distance = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Runnings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Runnings_Activities_Id",
                        column: x => x.Id,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Squattings",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Squattings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Squattings_Activities_Id",
                        column: x => x.Id,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cyclings");

            migrationBuilder.DropTable(
                name: "Runnings");

            migrationBuilder.DropTable(
                name: "Squattings");

            migrationBuilder.AddColumn<Guid>(
                name: "ActivityId",
                table: "Activities",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Activities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Distance",
                table: "Activities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Pace",
                table: "Activities",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Running_ActivityId",
                table: "Activities",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Running_Distance",
                table: "Activities",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Running_Pace",
                table: "Activities",
                type: "time",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Squatting_ActivityId",
                table: "Activities",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Activities_ActivityId",
                table: "Activities",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_Running_ActivityId",
                table: "Activities",
                column: "Running_ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_Activities_Squatting_ActivityId",
                table: "Activities",
                column: "Squatting_ActivityId");

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
        }
    }
}
