using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace job_board.Models;

public partial class SupertexDbContext : DbContext
{
    public SupertexDbContext()
    {
    }

    public SupertexDbContext(DbContextOptions<SupertexDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AplicacionTrabajo> AplicacionTrabajos { get; set; }

    public virtual DbSet<Aspirante> Aspirantes { get; set; }

    public virtual DbSet<Certificacion> Certificacions { get; set; }

    public virtual DbSet<Conocimiento> Conocimientos { get; set; }

    public virtual DbSet<Educacion> Educacions { get; set; }

    public virtual DbSet<Empresa> Empresas { get; set; }

    public virtual DbSet<Evento> Eventos { get; set; }

    public virtual DbSet<Experiencium> Experiencia { get; set; }

    public virtual DbSet<Habilidade> Habilidades { get; set; }

    public virtual DbSet<Idioma> Idiomas { get; set; }

    public virtual DbSet<Logro> Logros { get; set; }

    public virtual DbSet<ModoTrabajo> ModoTrabajos { get; set; }

    public virtual DbSet<OfertaLaboral> OfertaLaborals { get; set; }

    public virtual DbSet<Publicacione> Publicaciones { get; set; }

    public virtual DbSet<Resultado> Resultados { get; set; }

    public virtual DbSet<Rol> Rols { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AplicacionTrabajo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Aplicaci__3214EC0700CDCDE1");

            entity.ToTable("AplicacionTrabajo");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Comentario)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Estado)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("date");

            entity.HasOne(d => d.IdAspiranteNavigation).WithMany(p => p.AplicacionTrabajos)
                .HasForeignKey(d => d.IdAspirante)
                .HasConstraintName("FK__Aplicacio__IdAsp__4D94879B");

            entity.HasOne(d => d.IdOfertaNavigation).WithMany(p => p.AplicacionTrabajos)
                .HasForeignKey(d => d.IdOferta)
                .HasConstraintName("FK__Aplicacio__IdOfe__4CA06362");
        });

        modelBuilder.Entity<Aspirante>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Aspirant__3214EC074A72A72A");

            entity.ToTable("Aspirante");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Apellido)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Correo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Direccion)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Documento)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.FechaNacimiento).HasColumnType("date");
            entity.Property(e => e.Genero)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Nit)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("NIT");
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nup)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("NUP");
            entity.Property(e => e.RedesSociales)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(25)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Certificacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Certific__3214EC07371B3EBA");

            entity.ToTable("Certificacion");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.CodigoCertificacion)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Institucion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(250)
                .IsUnicode(false);
            entity.Property(e => e.Periodo)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TipoCertificacion)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAspiranteNavigation).WithMany(p => p.Certificacions)
                .HasForeignKey(d => d.IdAspirante)
                .HasConstraintName("FK__Certifica__IdAsp__4222D4EF");
        });

        modelBuilder.Entity<Conocimiento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Conocimi__3214EC0793BAE874");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Nivel)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAspiranteNavigation).WithMany(p => p.Conocimientos)
                .HasForeignKey(d => d.IdAspirante)
                .HasConstraintName("FK__Conocimie__IdAsp__60A75C0F");

            entity.HasOne(d => d.IdOfertaNavigation).WithMany(p => p.Conocimientos)
                .HasForeignKey(d => d.IdOferta)
                .HasConstraintName("FK__Conocimie__IdOfe__5FB337D6");
        });

        modelBuilder.Entity<Educacion>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Educacio__3214EC071BA1ED92");

            entity.ToTable("Educacion");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Institucion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Periodo)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAspiranteNavigation).WithMany(p => p.Educacions)
                .HasForeignKey(d => d.IdAspirante)
                .HasConstraintName("FK__Educacion__IdAsp__5070F446");
        });

        modelBuilder.Entity<Empresa>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Empresa__3214EC07EE14BEFE");

            entity.ToTable("Empresa");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Email)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Ubicacion)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Evento>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Evento__3214EC07EB781DF8");

            entity.ToTable("Evento");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Anfitrion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.Lugar)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Pais)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TipoEvento)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAspiranteNavigation).WithMany(p => p.Eventos)
                .HasForeignKey(d => d.IdAspirante)
                .HasConstraintName("FK__Evento__IdAspira__59063A47");
        });

        modelBuilder.Entity<Experiencium>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Experien__3214EC079A40C1ED");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Funciones)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.NombreOrganizacion)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Periodo)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Puesto)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Telefono)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAspiranteNavigation).WithMany(p => p.Experiencia)
                .HasForeignKey(d => d.IdAspirante)
                .HasConstraintName("FK__Experienc__IdAsp__398D8EEE");
        });

        modelBuilder.Entity<Habilidade>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Habilida__3214EC071740BCC0");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAspiranteNavigation).WithMany(p => p.Habilidades)
                .HasForeignKey(d => d.IdAspirante)
                .HasConstraintName("FK__Habilidad__IdAsp__5CD6CB2B");

            entity.HasOne(d => d.IdOfertaNavigation).WithMany(p => p.Habilidades)
                .HasForeignKey(d => d.IdOferta)
                .HasConstraintName("FK__Habilidad__IdOfe__5BE2A6F2");
        });

        modelBuilder.Entity<Idioma>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Idioma__3214EC07DF43DB87");

            entity.ToTable("Idioma");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.NivelEscritura)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.NivelEscucha)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.NivelHabla)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.NivelLectura)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAspiranteNavigation).WithMany(p => p.Idiomas)
                .HasForeignKey(d => d.IdAspirante)
                .HasConstraintName("FK__Idioma__IdAspira__534D60F1");
        });

        modelBuilder.Entity<Logro>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Logros__3214EC0767B2F2B6");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Fecha).HasColumnType("date");

            entity.HasOne(d => d.IdAspiranteNavigation).WithMany(p => p.Logros)
                .HasForeignKey(d => d.IdAspirante)
                .HasConstraintName("FK__Logros__IdAspira__3C69FB99");
        });

        modelBuilder.Entity<ModoTrabajo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__ModoTrab__3214EC0741122761");

            entity.ToTable("ModoTrabajo");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<OfertaLaboral>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__OfertaLa__3214EC070657F216");

            entity.ToTable("OfertaLaboral");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Experiencia)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.PerfilAcademico)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.OfertaLaborals)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("FK__OfertaLab__IdEmp__49C3F6B7");

            entity.HasOne(d => d.IdModoTrabajoNavigation).WithMany(p => p.OfertaLaborals)
                .HasForeignKey(d => d.IdModoTrabajo)
                .HasConstraintName("FK__OfertaLab__IdMod__48CFD27E");
        });

        modelBuilder.Entity<Publicacione>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Publicac__3214EC075F4582C9");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Fecha).HasColumnType("date");
            entity.Property(e => e.Isbn)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("ISBN");
            entity.Property(e => e.Lugar)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.TipoPublicacion)
                .HasMaxLength(25)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAspiranteNavigation).WithMany(p => p.Publicaciones)
                .HasForeignKey(d => d.IdAspirante)
                .HasConstraintName("FK__Publicaci__IdAsp__3F466844");
        });

        modelBuilder.Entity<Resultado>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Resultad__3214EC077F4176E9");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Resultado1)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("Resultado");
            entity.Property(e => e.TipoExamen)
                .HasMaxLength(250)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAspiranteNavigation).WithMany(p => p.Resultados)
                .HasForeignKey(d => d.IdAspirante)
                .HasConstraintName("FK__Resultado__IdAsp__5629CD9C");
        });

        modelBuilder.Entity<Rol>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Rol__3214EC071CAD7A92");

            entity.ToTable("Rol");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Descripcion)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Nombre)
                .HasMaxLength(100)
                .IsUnicode(false);
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Usuario__3214EC079B16E5D1");

            entity.ToTable("Usuario");

            entity.Property(e => e.Id).ValueGeneratedOnAdd();
            entity.Property(e => e.Estado)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.IdAspiranteNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdAspirante)
                .HasConstraintName("FK__Usuario__IdAspir__66603565");

            entity.HasOne(d => d.IdEmpresaNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdEmpresa)
                .HasConstraintName("FK__Usuario__IdEmpre__656C112C");

            entity.HasOne(d => d.IdRolNavigation).WithMany(p => p.Usuarios)
                .HasForeignKey(d => d.IdRol)
                .HasConstraintName("FK__Usuario__IdRol__6754599E");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
