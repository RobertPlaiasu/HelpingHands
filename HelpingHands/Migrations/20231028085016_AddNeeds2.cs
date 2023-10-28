using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HelpingHands.Migrations
{
    /// <inheritdoc />
    public partial class AddNeeds2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Need_Posts_PostId",
                table: "Need");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Need",
                table: "Need");

            migrationBuilder.RenameTable(
                name: "Need",
                newName: "Needs");

            migrationBuilder.RenameIndex(
                name: "IX_Need_PostId",
                table: "Needs",
                newName: "IX_Needs_PostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Needs",
                table: "Needs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Needs_Posts_PostId",
                table: "Needs",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Needs_Posts_PostId",
                table: "Needs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Needs",
                table: "Needs");

            migrationBuilder.RenameTable(
                name: "Needs",
                newName: "Need");

            migrationBuilder.RenameIndex(
                name: "IX_Needs_PostId",
                table: "Need",
                newName: "IX_Need_PostId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Need",
                table: "Need",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Need_Posts_PostId",
                table: "Need",
                column: "PostId",
                principalTable: "Posts",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
