using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HelpingHands.Migrations
{
    /// <inheritdoc />
    public partial class AddAddress : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "numberNeed",
                table: "Posts");

            migrationBuilder.RenameColumn(
                name: "NameNeed",
                table: "Posts",
                newName: "Address");

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Id", "Address", "CategoryId", "Description", "Image", "OngId", "Title" },
                values: new object[] { 1, "Ste Drumul Sperantei nr 55", 1, "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Praesent condimentum lacinia convallis. Donec in tortor nec odio elementum aliquam facilisis a lorem. Aliquam placerat convallis orci, quis ullamcorper lorem consectetur et. Mauris in turpis et leo pretium tempor. Nullam vel posuere lacus. Aenean ut diam non ligula sagittis sagittis. Quisque ac dictum urna, non eleifend lectus.", "./default.png", 1, "Ajuta oamenii fara adapost" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "Address",
                table: "Posts",
                newName: "NameNeed");

            migrationBuilder.AddColumn<int>(
                name: "numberNeed",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
