using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace job_board.Migrations
{
    /// <inheritdoc />
    public partial class AddRelationWithCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdEmpresa",
                table: "ModoTrabajo",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ModoTrabajo_IdEmpresa",
                table: "ModoTrabajo",
                column: "IdEmpresa");

            migrationBuilder.AddForeignKey(
                name: "FK__Modo_trabajo__IdEmp__49C3F6B7",
                table: "ModoTrabajo",
                column: "IdEmpresa",
                principalTable: "Empresa",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK__Modo_trabajo__IdEmp__49C3F6B7",
                table: "ModoTrabajo");

            migrationBuilder.DropIndex(
                name: "IX_ModoTrabajo_IdEmpresa",
                table: "ModoTrabajo");

            migrationBuilder.DropColumn(
                name: "IdEmpresa",
                table: "ModoTrabajo");
        }
    }
}
