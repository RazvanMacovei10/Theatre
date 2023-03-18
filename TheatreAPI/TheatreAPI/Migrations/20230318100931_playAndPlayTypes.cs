using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TheatreAPI.Migrations
{
    /// <inheritdoc />
    public partial class playAndPlayTypes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PlayId",
                table: "Actors",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateTable(
                name: "Plays",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypeId = table.Column<int>(type: "int", nullable: false),
                    Image = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Plays", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Plays_PlayTypes_TypeId",
                        column: x => x.TypeId,
                        principalTable: "PlayTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actors_PlayId",
                table: "Actors",
                column: "PlayId");

            migrationBuilder.CreateIndex(
                name: "IX_Plays_TypeId",
                table: "Plays",
                column: "TypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Plays_PlayId",
                table: "Actors",
                column: "PlayId",
                principalTable: "Plays",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Plays_PlayId",
                table: "Actors");

            migrationBuilder.DropTable(
                name: "Plays");

            migrationBuilder.DropTable(
                name: "PlayTypes");

            migrationBuilder.DropIndex(
                name: "IX_Actors_PlayId",
                table: "Actors");

            migrationBuilder.DropColumn(
                name: "PlayId",
                table: "Actors");
        }
    }
}
