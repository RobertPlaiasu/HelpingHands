using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HelpingHands.Migrations
{
    /// <inheritdoc />
    public partial class AddTitle4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Ongs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Ongs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Ongs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Email", "Image", "Name", "ONGDescription" },
                values: new object[] { "Str. Dimitrie Cantemir nr. 3", "hello@asociatiaaluziva.ro", " ../../assets/aluziva.png", "Asociatia Aluziva", "Suntem toți aici să învățăm și împreună să facem o schimbare. Susținem comunitățile defavorizate, în mod special mamele și copiii din medii vulnerabile, educația în mediul rural și orice alte cauze care nu pot schimba lumea, dar pot schimba lumea cuiva. Picătură cu picătură se face un ocean. #picaturacupicaturasefaceunocean" });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Address",
                value: "Str. Dimitrie Cantemir nr. 3");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Ongs");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Ongs");

            migrationBuilder.UpdateData(
                table: "Ongs",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Address", "Image", "ONGDescription" },
                values: new object[] { "Str Maresal Dumtrescu nr. 555", "./default.png", "Descrierea unui ONG ce se ocupa cu ajutarea oameniilor nevoiasi." });

            migrationBuilder.UpdateData(
                table: "Posts",
                keyColumn: "Id",
                keyValue: 1,
                column: "Address",
                value: "Ste Drumul Sperantei nr 55");
        }
    }
}
