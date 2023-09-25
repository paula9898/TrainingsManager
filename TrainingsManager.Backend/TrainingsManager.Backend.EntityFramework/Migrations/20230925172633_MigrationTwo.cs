using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TrainingsManager.Backend.EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class MigrationTwo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Squatting_Distance",
                table: "Activity");

            migrationBuilder.DropColumn(
                name: "Squatting_Pace",
                table: "Activity");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Squatting_Distance",
                table: "Activity",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "Squatting_Pace",
                table: "Activity",
                type: "time",
                nullable: true);
        }
    }
}
