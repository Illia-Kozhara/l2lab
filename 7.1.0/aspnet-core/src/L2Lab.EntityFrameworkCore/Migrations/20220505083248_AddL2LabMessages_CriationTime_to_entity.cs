using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L2Lab.Migrations
{
    public partial class AddL2LabMessages_CriationTime_to_entity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreationTime",
                table: "L2LabMessages",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreationTime",
                table: "L2LabMessages");
        }
    }
}
