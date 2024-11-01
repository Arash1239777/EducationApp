using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EducationalApi.Infra.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDatabaseSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CollegianId",
                table: "Collegians");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "CollegianId",
                table: "Collegians",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
