using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace job_board.Migrations
{
    /// <inheritdoc />
    public partial class removeOnCascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Conocimie__IdAsp__60A75C0F",
                table: "Conocimientos");

            migrationBuilder.DropForeignKey(
                name: "FK__Conocimie__IdOfe__5FB337D6",
                table: "Conocimientos");

            migrationBuilder.DropForeignKey(
                name: "FK__Experienc__IdAsp__398D8EEE",
                table: "Experiencia");

            migrationBuilder.DropForeignKey(
                name: "FK__Habilidad__IdAsp__5CD6CB2B",
                table: "Habilidades");

            migrationBuilder.DropForeignKey(
                name: "FK__Habilidad__IdOfe__5BE2A6F2",
                table: "Habilidades");

            migrationBuilder.AddForeignKey(
                name: "FK__Conocimie__IdAsp__60A75C0F",
                table: "Conocimientos",
                column: "IdAspirante",
                principalTable: "Aspirante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__Conocimie__IdOfe__5FB337D6",
                table: "Conocimientos",
                column: "IdOferta",
                principalTable: "OfertaLaboral",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__Experienc__IdAsp__398D8EEE",
                table: "Experiencia",
                column: "IdAspirante",
                principalTable: "Aspirante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__Habilidad__IdAsp__5CD6CB2B",
                table: "Habilidades",
                column: "IdAspirante",
                principalTable: "Aspirante",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK__Habilidad__IdOfe__5BE2A6F2",
                table: "Habilidades",
                column: "IdOferta",
                principalTable: "OfertaLaboral",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Conocimie__IdAsp__60A75C0F",
                table: "Conocimientos");

            migrationBuilder.DropForeignKey(
                name: "FK__Conocimie__IdOfe__5FB337D6",
                table: "Conocimientos");

            migrationBuilder.DropForeignKey(
                name: "FK__Experienc__IdAsp__398D8EEE",
                table: "Experiencia");

            migrationBuilder.DropForeignKey(
                name: "FK__Habilidad__IdAsp__5CD6CB2B",
                table: "Habilidades");

            migrationBuilder.DropForeignKey(
                name: "FK__Habilidad__IdOfe__5BE2A6F2",
                table: "Habilidades");

            migrationBuilder.AddForeignKey(
                name: "FK__Conocimie__IdAsp__60A75C0F",
                table: "Conocimientos",
                column: "IdAspirante",
                principalTable: "Aspirante",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__Conocimie__IdOfe__5FB337D6",
                table: "Conocimientos",
                column: "IdOferta",
                principalTable: "OfertaLaboral",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__Experienc__IdAsp__398D8EEE",
                table: "Experiencia",
                column: "IdAspirante",
                principalTable: "Aspirante",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__Habilidad__IdAsp__5CD6CB2B",
                table: "Habilidades",
                column: "IdAspirante",
                principalTable: "Aspirante",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK__Habilidad__IdOfe__5BE2A6F2",
                table: "Habilidades",
                column: "IdOferta",
                principalTable: "OfertaLaboral",
                principalColumn: "Id");
        }
    }
}
