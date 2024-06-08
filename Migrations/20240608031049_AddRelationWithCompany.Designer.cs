﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using job_board.Models;

#nullable disable

namespace job_board.Migrations
{
    [DbContext(typeof(SupertexDbContext))]
    [Migration("20240608031049_AddRelationWithCompany")]
    partial class AddRelationWithCompany
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("job_board.Models.AplicacionTrabajo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Comentario")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Estado")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("date");

                    b.Property<int?>("IdAspirante")
                        .HasColumnType("int");

                    b.Property<int?>("IdOferta")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__Aplicaci__3214EC0700CDCDE1");

                    b.HasIndex("IdAspirante");

                    b.HasIndex("IdOferta");

                    b.ToTable("AplicacionTrabajo", (string)null);
                });

            modelBuilder.Entity("job_board.Models.Aspirante", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellido")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Correo")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Direccion")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Documento")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("date");

                    b.Property<string>("Genero")
                        .HasMaxLength(10)
                        .IsUnicode(false)
                        .HasColumnType("varchar(10)");

                    b.Property<string>("Nit")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("NIT");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nup")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("NUP");

                    b.Property<string>("RedesSociales")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Telefono")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.HasKey("Id")
                        .HasName("PK__Aspirant__3214EC074A72A72A");

                    b.ToTable("Aspirante", (string)null);
                });

            modelBuilder.Entity("job_board.Models.Certificacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("CodigoCertificacion")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.Property<int?>("IdAspirante")
                        .HasColumnType("int");

                    b.Property<string>("Institucion")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nombre")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<string>("Periodo")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TipoCertificacion")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.HasKey("Id")
                        .HasName("PK__Certific__3214EC07371B3EBA");

                    b.HasIndex("IdAspirante");

                    b.ToTable("Certificacion", (string)null);
                });

            modelBuilder.Entity("job_board.Models.Conocimiento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("IdAspirante")
                        .HasColumnType("int");

                    b.Property<int?>("IdOferta")
                        .HasColumnType("int");

                    b.Property<string>("Nivel")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id")
                        .HasName("PK__Conocimi__3214EC0793BAE874");

                    b.HasIndex("IdAspirante");

                    b.HasIndex("IdOferta");

                    b.ToTable("Conocimientos");
                });

            modelBuilder.Entity("job_board.Models.Educacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("IdAspirante")
                        .HasColumnType("int");

                    b.Property<string>("Institucion")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Periodo")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id")
                        .HasName("PK__Educacio__3214EC071BA1ED92");

                    b.HasIndex("IdAspirante");

                    b.ToTable("Educacion", (string)null);
                });

            modelBuilder.Entity("job_board.Models.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Email")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefono")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Ubicacion")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id")
                        .HasName("PK__Empresa__3214EC07EE14BEFE");

                    b.ToTable("Empresa", (string)null);
                });

            modelBuilder.Entity("job_board.Models.Evento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Anfitrion")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("date");

                    b.Property<int?>("IdAspirante")
                        .HasColumnType("int");

                    b.Property<string>("Lugar")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Pais")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TipoEvento")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id")
                        .HasName("PK__Evento__3214EC07EB781DF8");

                    b.HasIndex("IdAspirante");

                    b.ToTable("Evento", (string)null);
                });

            modelBuilder.Entity("job_board.Models.Experiencium", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Funciones")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("IdAspirante")
                        .HasColumnType("int");

                    b.Property<string>("NombreOrganizacion")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Periodo")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Puesto")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefono")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.HasKey("Id")
                        .HasName("PK__Experien__3214EC079A40C1ED");

                    b.HasIndex("IdAspirante");

                    b.ToTable("Experiencia");
                });

            modelBuilder.Entity("job_board.Models.Habilidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<int?>("IdAspirante")
                        .HasColumnType("int");

                    b.Property<int?>("IdOferta")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id")
                        .HasName("PK__Habilida__3214EC071740BCC0");

                    b.HasIndex("IdAspirante");

                    b.HasIndex("IdOferta");

                    b.ToTable("Habilidades");
                });

            modelBuilder.Entity("job_board.Models.Idioma", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("IdAspirante")
                        .HasColumnType("int");

                    b.Property<string>("NivelEscritura")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("NivelEscucha")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("NivelHabla")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("NivelLectura")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id")
                        .HasName("PK__Idioma__3214EC07DF43DB87");

                    b.HasIndex("IdAspirante");

                    b.ToTable("Idioma", (string)null);
                });

            modelBuilder.Entity("job_board.Models.Logro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("date");

                    b.Property<int?>("IdAspirante")
                        .HasColumnType("int");

                    b.HasKey("Id")
                        .HasName("PK__Logros__3214EC0767B2F2B6");

                    b.HasIndex("IdAspirante");

                    b.ToTable("Logros");
                });

            modelBuilder.Entity("job_board.Models.ModoTrabajo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<int>("IdEmpresa")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id")
                        .HasName("PK__ModoTrab__3214EC0741122761");

                    b.HasIndex("IdEmpresa");

                    b.ToTable("ModoTrabajo", (string)null);
                });

            modelBuilder.Entity("job_board.Models.OfertaLaboral", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Experiencia")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<int?>("IdEmpresa")
                        .HasColumnType("int");

                    b.Property<int?>("IdModoTrabajo")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PerfilAcademico")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.Property<double?>("SalarioMax")
                        .HasColumnType("float");

                    b.Property<double?>("SalarioMin")
                        .HasColumnType("float");

                    b.HasKey("Id")
                        .HasName("PK__OfertaLa__3214EC070657F216");

                    b.HasIndex("IdEmpresa");

                    b.HasIndex("IdModoTrabajo");

                    b.ToTable("OfertaLaboral", (string)null);
                });

            modelBuilder.Entity("job_board.Models.Publicacione", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("Fecha")
                        .HasColumnType("date");

                    b.Property<int?>("IdAspirante")
                        .HasColumnType("int");

                    b.Property<string>("Isbn")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("ISBN");

                    b.Property<string>("Lugar")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("TipoPublicacion")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)");

                    b.HasKey("Id")
                        .HasName("PK__Publicac__3214EC075F4582C9");

                    b.HasIndex("IdAspirante");

                    b.ToTable("Publicaciones");
                });

            modelBuilder.Entity("job_board.Models.Resultado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("IdAspirante")
                        .HasColumnType("int");

                    b.Property<string>("Resultado1")
                        .HasMaxLength(25)
                        .IsUnicode(false)
                        .HasColumnType("varchar(25)")
                        .HasColumnName("Resultado");

                    b.Property<string>("TipoExamen")
                        .HasMaxLength(250)
                        .IsUnicode(false)
                        .HasColumnType("varchar(250)");

                    b.HasKey("Id")
                        .HasName("PK__Resultad__3214EC077F4176E9");

                    b.HasIndex("IdAspirante");

                    b.ToTable("Resultados");
                });

            modelBuilder.Entity("job_board.Models.Rol", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripcion")
                        .HasMaxLength(255)
                        .IsUnicode(false)
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Nombre")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id")
                        .HasName("PK__Rol__3214EC071CAD7A92");

                    b.HasIndex("Nombre")
                        .IsUnique()
                        .HasFilter("[Nombre] IS NOT NULL");

                    b.ToTable("Rol", (string)null);
                });

            modelBuilder.Entity("job_board.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Estado")
                        .HasMaxLength(2)
                        .IsUnicode(false)
                        .HasColumnType("varchar(2)");

                    b.Property<int?>("IdAspirante")
                        .HasColumnType("int");

                    b.Property<int?>("IdEmpresa")
                        .HasColumnType("int");

                    b.Property<int?>("IdRol")
                        .HasColumnType("int");

                    b.Property<string>("Password")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Username")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id")
                        .HasName("PK__Usuario__3214EC079B16E5D1");

                    b.HasIndex("IdAspirante");

                    b.HasIndex("IdEmpresa");

                    b.HasIndex("IdRol");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasFilter("[Username] IS NOT NULL");

                    b.ToTable("Usuario", (string)null);
                });

            modelBuilder.Entity("job_board.Models.AplicacionTrabajo", b =>
                {
                    b.HasOne("job_board.Models.Aspirante", "IdAspiranteNavigation")
                        .WithMany("AplicacionTrabajos")
                        .HasForeignKey("IdAspirante")
                        .HasConstraintName("FK__Aplicacio__IdAsp__4D94879B");

                    b.HasOne("job_board.Models.OfertaLaboral", "IdOfertaNavigation")
                        .WithMany("AplicacionTrabajos")
                        .HasForeignKey("IdOferta")
                        .HasConstraintName("FK__Aplicacio__IdOfe__4CA06362");

                    b.Navigation("IdAspiranteNavigation");

                    b.Navigation("IdOfertaNavigation");
                });

            modelBuilder.Entity("job_board.Models.Certificacion", b =>
                {
                    b.HasOne("job_board.Models.Aspirante", "IdAspiranteNavigation")
                        .WithMany("Certificacions")
                        .HasForeignKey("IdAspirante")
                        .HasConstraintName("FK__Certifica__IdAsp__4222D4EF");

                    b.Navigation("IdAspiranteNavigation");
                });

            modelBuilder.Entity("job_board.Models.Conocimiento", b =>
                {
                    b.HasOne("job_board.Models.Aspirante", "IdAspiranteNavigation")
                        .WithMany("Conocimientos")
                        .HasForeignKey("IdAspirante")
                        .HasConstraintName("FK__Conocimie__IdAsp__60A75C0F");

                    b.HasOne("job_board.Models.OfertaLaboral", "IdOfertaNavigation")
                        .WithMany("Conocimientos")
                        .HasForeignKey("IdOferta")
                        .HasConstraintName("FK__Conocimie__IdOfe__5FB337D6");

                    b.Navigation("IdAspiranteNavigation");

                    b.Navigation("IdOfertaNavigation");
                });

            modelBuilder.Entity("job_board.Models.Educacion", b =>
                {
                    b.HasOne("job_board.Models.Aspirante", "IdAspiranteNavigation")
                        .WithMany("Educacions")
                        .HasForeignKey("IdAspirante")
                        .HasConstraintName("FK__Educacion__IdAsp__5070F446");

                    b.Navigation("IdAspiranteNavigation");
                });

            modelBuilder.Entity("job_board.Models.Evento", b =>
                {
                    b.HasOne("job_board.Models.Aspirante", "IdAspiranteNavigation")
                        .WithMany("Eventos")
                        .HasForeignKey("IdAspirante")
                        .HasConstraintName("FK__Evento__IdAspira__59063A47");

                    b.Navigation("IdAspiranteNavigation");
                });

            modelBuilder.Entity("job_board.Models.Experiencium", b =>
                {
                    b.HasOne("job_board.Models.Aspirante", "IdAspiranteNavigation")
                        .WithMany("Experiencia")
                        .HasForeignKey("IdAspirante")
                        .HasConstraintName("FK__Experienc__IdAsp__398D8EEE");

                    b.Navigation("IdAspiranteNavigation");
                });

            modelBuilder.Entity("job_board.Models.Habilidade", b =>
                {
                    b.HasOne("job_board.Models.Aspirante", "IdAspiranteNavigation")
                        .WithMany("Habilidades")
                        .HasForeignKey("IdAspirante")
                        .HasConstraintName("FK__Habilidad__IdAsp__5CD6CB2B");

                    b.HasOne("job_board.Models.OfertaLaboral", "IdOfertaNavigation")
                        .WithMany("Habilidades")
                        .HasForeignKey("IdOferta")
                        .HasConstraintName("FK__Habilidad__IdOfe__5BE2A6F2");

                    b.Navigation("IdAspiranteNavigation");

                    b.Navigation("IdOfertaNavigation");
                });

            modelBuilder.Entity("job_board.Models.Idioma", b =>
                {
                    b.HasOne("job_board.Models.Aspirante", "IdAspiranteNavigation")
                        .WithMany("Idiomas")
                        .HasForeignKey("IdAspirante")
                        .HasConstraintName("FK__Idioma__IdAspira__534D60F1");

                    b.Navigation("IdAspiranteNavigation");
                });

            modelBuilder.Entity("job_board.Models.Logro", b =>
                {
                    b.HasOne("job_board.Models.Aspirante", "IdAspiranteNavigation")
                        .WithMany("Logros")
                        .HasForeignKey("IdAspirante")
                        .HasConstraintName("FK__Logros__IdAspira__3C69FB99");

                    b.Navigation("IdAspiranteNavigation");
                });

            modelBuilder.Entity("job_board.Models.ModoTrabajo", b =>
                {
                    b.HasOne("job_board.Models.Empresa", "IdEmpresaNavigation")
                        .WithMany("modoTrabajo")
                        .HasForeignKey("IdEmpresa")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK__Modo_trabajo__IdEmp__49C3F6B7");

                    b.Navigation("IdEmpresaNavigation");
                });

            modelBuilder.Entity("job_board.Models.OfertaLaboral", b =>
                {
                    b.HasOne("job_board.Models.Empresa", "IdEmpresaNavigation")
                        .WithMany("OfertaLaborals")
                        .HasForeignKey("IdEmpresa")
                        .HasConstraintName("FK__OfertaLab__IdEmp__49C3F6B7");

                    b.HasOne("job_board.Models.ModoTrabajo", "IdModoTrabajoNavigation")
                        .WithMany("OfertaLaborals")
                        .HasForeignKey("IdModoTrabajo")
                        .HasConstraintName("FK__OfertaLab__IdMod__48CFD27E");

                    b.Navigation("IdEmpresaNavigation");

                    b.Navigation("IdModoTrabajoNavigation");
                });

            modelBuilder.Entity("job_board.Models.Publicacione", b =>
                {
                    b.HasOne("job_board.Models.Aspirante", "IdAspiranteNavigation")
                        .WithMany("Publicaciones")
                        .HasForeignKey("IdAspirante")
                        .HasConstraintName("FK__Publicaci__IdAsp__3F466844");

                    b.Navigation("IdAspiranteNavigation");
                });

            modelBuilder.Entity("job_board.Models.Resultado", b =>
                {
                    b.HasOne("job_board.Models.Aspirante", "IdAspiranteNavigation")
                        .WithMany("Resultados")
                        .HasForeignKey("IdAspirante")
                        .HasConstraintName("FK__Resultado__IdAsp__5629CD9C");

                    b.Navigation("IdAspiranteNavigation");
                });

            modelBuilder.Entity("job_board.Models.Usuario", b =>
                {
                    b.HasOne("job_board.Models.Aspirante", "IdAspiranteNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdAspirante")
                        .HasConstraintName("FK__Usuario__IdAspir__66603565");

                    b.HasOne("job_board.Models.Empresa", "IdEmpresaNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdEmpresa")
                        .HasConstraintName("FK__Usuario__IdEmpre__656C112C");

                    b.HasOne("job_board.Models.Rol", "IdRolNavigation")
                        .WithMany("Usuarios")
                        .HasForeignKey("IdRol")
                        .HasConstraintName("FK__Usuario__IdRol__6754599E");

                    b.Navigation("IdAspiranteNavigation");

                    b.Navigation("IdEmpresaNavigation");

                    b.Navigation("IdRolNavigation");
                });

            modelBuilder.Entity("job_board.Models.Aspirante", b =>
                {
                    b.Navigation("AplicacionTrabajos");

                    b.Navigation("Certificacions");

                    b.Navigation("Conocimientos");

                    b.Navigation("Educacions");

                    b.Navigation("Eventos");

                    b.Navigation("Experiencia");

                    b.Navigation("Habilidades");

                    b.Navigation("Idiomas");

                    b.Navigation("Logros");

                    b.Navigation("Publicaciones");

                    b.Navigation("Resultados");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("job_board.Models.Empresa", b =>
                {
                    b.Navigation("OfertaLaborals");

                    b.Navigation("Usuarios");

                    b.Navigation("modoTrabajo");
                });

            modelBuilder.Entity("job_board.Models.ModoTrabajo", b =>
                {
                    b.Navigation("OfertaLaborals");
                });

            modelBuilder.Entity("job_board.Models.OfertaLaboral", b =>
                {
                    b.Navigation("AplicacionTrabajos");

                    b.Navigation("Conocimientos");

                    b.Navigation("Habilidades");
                });

            modelBuilder.Entity("job_board.Models.Rol", b =>
                {
                    b.Navigation("Usuarios");
                });
#pragma warning restore 612, 618
        }
    }
}
