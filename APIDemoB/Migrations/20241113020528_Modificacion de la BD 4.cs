using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIDemoB.Migrations
{
    /// <inheritdoc />
    public partial class ModificaciondelaBD4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Activo",
                table: "Student",
                newName: "Active");

            migrationBuilder.AddColumn<bool>(
                name: "Active",
                table: "Grades",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Active",
                table: "Grades");

            migrationBuilder.RenameColumn(
                name: "Active",
                table: "Student",
                newName: "Activo");
        }
    }
}
