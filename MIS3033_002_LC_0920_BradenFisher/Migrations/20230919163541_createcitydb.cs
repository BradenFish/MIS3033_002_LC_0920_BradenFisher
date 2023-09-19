using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MIS3033_002_LC_0920_BradenFisher.Migrations
{
    /// <inheritdoc />
    public partial class createcitydb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "cityTbl",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    State = table.Column<string>(type: "TEXT", nullable: false),
                    Population = table.Column<int>(type: "INTEGER", nullable: false),
                    Lon = table.Column<double>(type: "REAL", nullable: false),
                    Lat = table.Column<double>(type: "REAL", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_cityTbl", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "cityTbl");
        }
    }
}
