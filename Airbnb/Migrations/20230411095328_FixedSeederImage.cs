using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Airbnb.Migrations
{
    /// <inheritdoc />
    public partial class FixedSeederImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 27,
                column: "URL",
                value: "https://static.wikia.nocookie.net/backrooms/images/5/59/Level_188_classic.jpg");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Image",
                keyColumn: "Id",
                keyValue: 27,
                column: "URL",
                value: "https://static.wikia.nocookie.net/backrooms/images/5/59/Level_188_classic.jpg/revision/latest?cb=20221009201412");
        }
    }
}
