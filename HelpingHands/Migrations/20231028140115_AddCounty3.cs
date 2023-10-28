using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HelpingHands.Migrations
{
    /// <inheritdoc />
    public partial class AddCounty3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Needs",
                columns: new[] { "Id", "Name", "PostId", "Quantity" },
                values: new object[,]
                {
                    { 1, "lemn", 1, 50 },
                    { 2, "bax caramida", 1, 500 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Needs",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Needs",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
