using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace job_board.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Aspirante",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Apellido = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    FechaNacimiento = table.Column<DateTime>(type: "date", nullable: true),
                    Genero = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    NIT = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    NUP = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Documento = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Telefono = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Direccion = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Correo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    RedesSociales = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Aspirant__3214EC074A72A72A", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Empresa",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Descripcion = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Ubicacion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Telefono = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Email = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Empresa__3214EC07EE14BEFE", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModoTrabajo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Descripcion = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__ModoTrab__3214EC0741122761", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Rol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Descripcion = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Rol__3214EC071CAD7A92", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Certificacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAspirante = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    TipoCertificacion = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    CodigoCertificacion = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Periodo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Institucion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Certific__3214EC07371B3EBA", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Certifica__IdAsp__4222D4EF",
                        column: x => x.IdAspirante,
                        principalTable: "Aspirante",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Educacion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAspirante = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Periodo = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Institucion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Educacio__3214EC071BA1ED92", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Educacion__IdAsp__5070F446",
                        column: x => x.IdAspirante,
                        principalTable: "Aspirante",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Evento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAspirante = table.Column<int>(type: "int", nullable: true),
                    TipoEvento = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Pais = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Fecha = table.Column<DateTime>(type: "date", nullable: true),
                    Lugar = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Anfitrion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Evento__3214EC07EB781DF8", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Evento__IdAspira__59063A47",
                        column: x => x.IdAspirante,
                        principalTable: "Aspirante",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Experiencia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAspirante = table.Column<int>(type: "int", nullable: true),
                    Puesto = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    NombreOrganizacion = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Funciones = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Telefono = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Periodo = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Experien__3214EC079A40C1ED", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Experienc__IdAsp__398D8EEE",
                        column: x => x.IdAspirante,
                        principalTable: "Aspirante",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Idioma",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAspirante = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    NivelLectura = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    NivelHabla = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    NivelEscritura = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    NivelEscucha = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Idioma__3214EC07DF43DB87", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Idioma__IdAspira__534D60F1",
                        column: x => x.IdAspirante,
                        principalTable: "Aspirante",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Logros",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAspirante = table.Column<int>(type: "int", nullable: true),
                    Fecha = table.Column<DateTime>(type: "date", nullable: true),
                    Descripcion = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Logros__3214EC0767B2F2B6", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Logros__IdAspira__3C69FB99",
                        column: x => x.IdAspirante,
                        principalTable: "Aspirante",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Publicaciones",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAspirante = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    TipoPublicacion = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true),
                    Fecha = table.Column<DateTime>(type: "date", nullable: true),
                    Lugar = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    ISBN = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Publicac__3214EC075F4582C9", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Publicaci__IdAsp__3F466844",
                        column: x => x.IdAspirante,
                        principalTable: "Aspirante",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Resultados",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdAspirante = table.Column<int>(type: "int", nullable: true),
                    TipoExamen = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Resultado = table.Column<string>(type: "varchar(25)", unicode: false, maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Resultad__3214EC077F4176E9", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Resultado__IdAsp__5629CD9C",
                        column: x => x.IdAspirante,
                        principalTable: "Aspirante",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "OfertaLaboral",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdModoTrabajo = table.Column<int>(type: "int", nullable: true),
                    IdEmpresa = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Descripcion = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    SalarioMin = table.Column<double>(type: "float", nullable: true),
                    SalarioMax = table.Column<double>(type: "float", nullable: true),
                    PerfilAcademico = table.Column<string>(type: "varchar(250)", unicode: false, maxLength: 250, nullable: true),
                    Experiencia = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__OfertaLa__3214EC070657F216", x => x.Id);
                    table.ForeignKey(
                        name: "FK__OfertaLab__IdEmp__49C3F6B7",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__OfertaLab__IdMod__48CFD27E",
                        column: x => x.IdModoTrabajo,
                        principalTable: "ModoTrabajo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdEmpresa = table.Column<int>(type: "int", nullable: true),
                    IdAspirante = table.Column<int>(type: "int", nullable: true),
                    IdRol = table.Column<int>(type: "int", nullable: true),
                    Username = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Password = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Estado = table.Column<string>(type: "varchar(2)", unicode: false, maxLength: 2, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Usuario__3214EC079B16E5D1", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Usuario__IdAspir__66603565",
                        column: x => x.IdAspirante,
                        principalTable: "Aspirante",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Usuario__IdEmpre__656C112C",
                        column: x => x.IdEmpresa,
                        principalTable: "Empresa",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Usuario__IdRol__6754599E",
                        column: x => x.IdRol,
                        principalTable: "Rol",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "AplicacionTrabajo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOferta = table.Column<int>(type: "int", nullable: true),
                    IdAspirante = table.Column<int>(type: "int", nullable: true),
                    Fecha = table.Column<DateTime>(type: "date", nullable: true),
                    Estado = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Comentario = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Aplicaci__3214EC0700CDCDE1", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Aplicacio__IdAsp__4D94879B",
                        column: x => x.IdAspirante,
                        principalTable: "Aspirante",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Aplicacio__IdOfe__4CA06362",
                        column: x => x.IdOferta,
                        principalTable: "OfertaLaboral",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Conocimientos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOferta = table.Column<int>(type: "int", nullable: true),
                    IdAspirante = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Descripcion = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    Nivel = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Conocimi__3214EC0793BAE874", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Conocimie__IdAsp__60A75C0F",
                        column: x => x.IdAspirante,
                        principalTable: "Aspirante",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Conocimie__IdOfe__5FB337D6",
                        column: x => x.IdOferta,
                        principalTable: "OfertaLaboral",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Habilidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdOferta = table.Column<int>(type: "int", nullable: true),
                    IdAspirante = table.Column<int>(type: "int", nullable: true),
                    Nombre = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    Descripcion = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK__Habilida__3214EC071740BCC0", x => x.Id);
                    table.ForeignKey(
                        name: "FK__Habilidad__IdAsp__5CD6CB2B",
                        column: x => x.IdAspirante,
                        principalTable: "Aspirante",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK__Habilidad__IdOfe__5BE2A6F2",
                        column: x => x.IdOferta,
                        principalTable: "OfertaLaboral",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_AplicacionTrabajo_IdAspirante",
                table: "AplicacionTrabajo",
                column: "IdAspirante");

            migrationBuilder.CreateIndex(
                name: "IX_AplicacionTrabajo_IdOferta",
                table: "AplicacionTrabajo",
                column: "IdOferta");

            migrationBuilder.CreateIndex(
                name: "IX_Certificacion_IdAspirante",
                table: "Certificacion",
                column: "IdAspirante");

            migrationBuilder.CreateIndex(
                name: "IX_Conocimientos_IdAspirante",
                table: "Conocimientos",
                column: "IdAspirante");

            migrationBuilder.CreateIndex(
                name: "IX_Conocimientos_IdOferta",
                table: "Conocimientos",
                column: "IdOferta");

            migrationBuilder.CreateIndex(
                name: "IX_Educacion_IdAspirante",
                table: "Educacion",
                column: "IdAspirante");

            migrationBuilder.CreateIndex(
                name: "IX_Evento_IdAspirante",
                table: "Evento",
                column: "IdAspirante");

            migrationBuilder.CreateIndex(
                name: "IX_Experiencia_IdAspirante",
                table: "Experiencia",
                column: "IdAspirante");

            migrationBuilder.CreateIndex(
                name: "IX_Habilidades_IdAspirante",
                table: "Habilidades",
                column: "IdAspirante");

            migrationBuilder.CreateIndex(
                name: "IX_Habilidades_IdOferta",
                table: "Habilidades",
                column: "IdOferta");

            migrationBuilder.CreateIndex(
                name: "IX_Idioma_IdAspirante",
                table: "Idioma",
                column: "IdAspirante");

            migrationBuilder.CreateIndex(
                name: "IX_Logros_IdAspirante",
                table: "Logros",
                column: "IdAspirante");

            migrationBuilder.CreateIndex(
                name: "IX_OfertaLaboral_IdEmpresa",
                table: "OfertaLaboral",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_OfertaLaboral_IdModoTrabajo",
                table: "OfertaLaboral",
                column: "IdModoTrabajo");

            migrationBuilder.CreateIndex(
                name: "IX_Publicaciones_IdAspirante",
                table: "Publicaciones",
                column: "IdAspirante");

            migrationBuilder.CreateIndex(
                name: "IX_Resultados_IdAspirante",
                table: "Resultados",
                column: "IdAspirante");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdAspirante",
                table: "Usuario",
                column: "IdAspirante");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdEmpresa",
                table: "Usuario",
                column: "IdEmpresa");

            migrationBuilder.CreateIndex(
                name: "IX_Usuario_IdRol",
                table: "Usuario",
                column: "IdRol");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AplicacionTrabajo");

            migrationBuilder.DropTable(
                name: "Certificacion");

            migrationBuilder.DropTable(
                name: "Conocimientos");

            migrationBuilder.DropTable(
                name: "Educacion");

            migrationBuilder.DropTable(
                name: "Evento");

            migrationBuilder.DropTable(
                name: "Experiencia");

            migrationBuilder.DropTable(
                name: "Habilidades");

            migrationBuilder.DropTable(
                name: "Idioma");

            migrationBuilder.DropTable(
                name: "Logros");

            migrationBuilder.DropTable(
                name: "Publicaciones");

            migrationBuilder.DropTable(
                name: "Resultados");

            migrationBuilder.DropTable(
                name: "Usuario");

            migrationBuilder.DropTable(
                name: "OfertaLaboral");

            migrationBuilder.DropTable(
                name: "Aspirante");

            migrationBuilder.DropTable(
                name: "Rol");

            migrationBuilder.DropTable(
                name: "Empresa");

            migrationBuilder.DropTable(
                name: "ModoTrabajo");
        }
    }
}
