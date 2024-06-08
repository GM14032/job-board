using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace job_board.Migrations
{
    /// <inheritdoc />
    public partial class AddUniqueIndexOnUsername : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Usuario_Username",
                table: "Usuario",
                column: "Username",
                unique: true,
                filter: "[Username] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Rol_Nombre",
                table: "Rol",
                column: "Nombre",
                unique: true,
                filter: "[Nombre] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Usuario_Username",
                table: "Usuario");

            migrationBuilder.DropIndex(
                name: "IX_Rol_Nombre",
                table: "Rol");
        }
    }
}
