using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace L2Lab.Migrations
{
    public partial class AddL2LabMessages : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CreationTime",
                table: "L2LabMessages",
                newName: "MsgCreationTime");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MsgCreationTime",
                table: "L2LabMessages",
                newName: "CreationTime");
        }
    }
}
