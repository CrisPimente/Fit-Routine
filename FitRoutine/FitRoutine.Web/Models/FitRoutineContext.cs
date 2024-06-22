using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FitRoutine.Web.Models;

public partial class FitRoutineContext : DbContext
{
    public FitRoutineContext()
    {
    }

    public FitRoutineContext(DbContextOptions<FitRoutineContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actividade> Actividades { get; set; }

    public virtual DbSet<Categoria> Categorias { get; set; }

    public virtual DbSet<Entrenadore> Entrenadores { get; set; }

    public virtual DbSet<Sesione> Sesiones { get; set; }

    public virtual DbSet<Usuario> Usuarios { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("#");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actividade>(entity =>
        {
            entity.HasKey(e => e.ActividadId).HasName("PK__Activida__981483F0B1720E08");

            entity.Property(e => e.ActividadId).HasColumnName("ActividadID");
            entity.Property(e => e.CategoriaId).HasColumnName("CategoriaID");
            entity.Property(e => e.Descripción).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(100);

            entity.HasOne(d => d.Categoria).WithMany(p => p.Actividades)
                .HasForeignKey(d => d.CategoriaId)
                .HasConstraintName("FK__Actividad__Categ__4F7CD00D");
        });

        modelBuilder.Entity<Categoria>(entity =>
        {
            entity.HasKey(e => e.CategoriaId).HasName("PK__Categorí__F353C1C5BE81660C");

            entity.Property(e => e.CategoriaId).HasColumnName("CategoriaID");
            entity.Property(e => e.Descripción).HasMaxLength(255);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<Entrenadore>(entity =>
        {
            entity.HasKey(e => e.EntrenadorId).HasName("PK__Entrenad__D0EE8545551CAA25");

            entity.Property(e => e.EntrenadorId).HasColumnName("EntrenadorID");
            entity.Property(e => e.Apellido).HasMaxLength(100);
            entity.Property(e => e.Especialidad).HasMaxLength(100);
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        modelBuilder.Entity<Sesione>(entity =>
        {
            entity.HasKey(e => e.SesionId).HasName("PK__Sesiones__52FD7C06B5DA7579");

            entity.Property(e => e.SesionId).HasColumnName("SesionID");
            entity.Property(e => e.ActividadId).HasColumnName("ActividadID");
            entity.Property(e => e.EntrenadorId).HasColumnName("EntrenadorID");
            entity.Property(e => e.Fecha).HasColumnType("datetime");
            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");

            entity.HasOne(d => d.Actividad).WithMany(p => p.Sesiones)
                .HasForeignKey(d => d.ActividadId)
                .HasConstraintName("FK__Sesiones__Activi__5535A963");

            entity.HasOne(d => d.Entrenador).WithMany(p => p.Sesiones)
                .HasForeignKey(d => d.EntrenadorId)
                .HasConstraintName("FK__Sesiones__Entren__5629CD9C");

            entity.HasOne(d => d.Usuario).WithMany(p => p.Sesiones)
                .HasForeignKey(d => d.UsuarioId)
                .HasConstraintName("FK__Sesiones__Usuari__5441852A");
        });

        modelBuilder.Entity<Usuario>(entity =>
        {
            entity.HasKey(e => e.UsuarioId).HasName("PK__Usuarios__2B3DE798F80E75F5");

            entity.HasIndex(e => e.Email, "UQ__Usuarios__A9D1053406E0E79C").IsUnique();

            entity.Property(e => e.UsuarioId).HasColumnName("UsuarioID");
            entity.Property(e => e.Apellido).HasMaxLength(100);
            entity.Property(e => e.Contraseña).HasMaxLength(100);
            entity.Property(e => e.Email).HasMaxLength(100);
            entity.Property(e => e.FechaRegistro)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.Genero)
                .HasMaxLength(1)
                .IsUnicode(false)
                .IsFixedLength();
            entity.Property(e => e.Nombre).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
