using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheatreAPI.Migrations
{
    /// <inheritdoc />
    public partial class removedPlayType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plays_PlayTypes_PlayTypeId",
                table: "Plays");

            migrationBuilder.DropTable(
                name: "PlayTypes");

            migrationBuilder.DropIndex(
                name: "IX_Plays_PlayTypeId",
                table: "Plays");

            migrationBuilder.DropColumn(
                name: "PlayTypeId",
                table: "Plays");

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Plays",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Type",
                table: "Plays");

            migrationBuilder.AddColumn<int>(
                name: "PlayTypeId",
                table: "Plays",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PlayTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayTypes", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Plays_PlayTypeId",
                table: "Plays",
                column: "PlayTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Plays_PlayTypes_PlayTypeId",
                table: "Plays",
                column: "PlayTypeId",
                principalTable: "PlayTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
