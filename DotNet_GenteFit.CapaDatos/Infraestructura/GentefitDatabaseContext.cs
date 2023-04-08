using System;
using System.Collections.Generic;
using DotNet_GenteFit.CapaDatos.Entidades;
using Microsoft.EntityFrameworkCore;

namespace DotNet_GenteFit.CapaDatos.Infraestructura;

public partial class GentefitDatabaseContext : DbContext
{
    public GentefitDatabaseContext(DbContextOptions<GentefitDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actividad> Actividads { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Especialidad> Especialidads { get; set; }

    public virtual DbSet<Horario> Horarios { get; set; }

    public virtual DbSet<Monitor> Monitors { get; set; }

    public virtual DbSet<Reserva> Reservas { get; set; }

    public virtual DbSet<Sala> Salas { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AS");

        modelBuilder.Entity<Actividad>(entity =>
        {
            entity.HasKey(e => e.IdActividad).HasName("PK_Actividades");

            entity.ToTable("Actividad");

            entity.Property(e => e.IdActividad).HasColumnName("idActividad");
            entity.Property(e => e.NombreActividad)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombreActividad");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente);

            entity.ToTable("Cliente");

            entity.Property(e => e.IdCliente).HasColumnName("idCliente");
            entity.Property(e => e.CuentaBanco)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("cuentaBanco");
            entity.Property(e => e.DireccionCliente)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("direccionCliente");
            entity.Property(e => e.EmailCliente)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("emailCliente");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("date")
                .HasColumnName("fechaAlta");
            entity.Property(e => e.FechanacimientoCliente)
                .HasColumnType("date")
                .HasColumnName("fechanacimientoCliente");
            entity.Property(e => e.GeneroCliente)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("generoCliente");
            entity.Property(e => e.NombreCliente)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("nombreCliente");
            entity.Property(e => e.PasswordCliente)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("passwordCliente");
            entity.Property(e => e.UsernameCliente)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("usernameCliente");
        });

        modelBuilder.Entity<Especialidad>(entity =>
        {
            entity.HasKey(e => e.IdEspecialidad);

            entity.ToTable("Especialidad");

            entity.Property(e => e.IdEspecialidad).HasColumnName("idEspecialidad");
            entity.Property(e => e.NombreEspecialidad)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("nombreEspecialidad");
        });

        modelBuilder.Entity<Horario>(entity =>
        {
            entity.HasKey(e => e.IdHorario).HasName("PK_Curso");

            entity.ToTable("Horario");

            entity.Property(e => e.IdHorario).HasColumnName("idHorario");
            entity.Property(e => e.CapacidadMaxima).HasColumnName("capacidadMaxima");
            entity.Property(e => e.Dia)
                .HasColumnType("date")
                .HasColumnName("dia");
            entity.Property(e => e.HoraFin).HasColumnName("horaFin");
            entity.Property(e => e.HoraInicio).HasColumnName("horaInicio");
            entity.Property(e => e.IdActividad).HasColumnName("idActividad");
            entity.Property(e => e.IdMonitor).HasColumnName("idMonitor");
            entity.Property(e => e.IdSala).HasColumnName("idSala");

            entity.HasOne(d => d.IdActividadNavigation).WithMany(p => p.Horarios)
                .HasForeignKey(d => d.IdActividad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Horario_Actividad");

            entity.HasOne(d => d.IdMonitorNavigation).WithMany(p => p.Horarios)
                .HasForeignKey(d => d.IdMonitor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Curso_Monitor");

            entity.HasOne(d => d.IdSalaNavigation).WithMany(p => p.Horarios)
                .HasForeignKey(d => d.IdSala)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Curso_Sala");
        });

        modelBuilder.Entity<Monitor>(entity =>
        {
            entity.HasKey(e => e.IdMonitor).HasName("PK_Profesor");

            entity.ToTable("Monitor");

            entity.Property(e => e.IdMonitor).HasColumnName("idMonitor");
            entity.Property(e => e.IdEspecialidad).HasColumnName("idEspecialidad");
            entity.Property(e => e.NombreMonitor)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnName("nombreMonitor");

            entity.HasOne(d => d.IdEspecialidadNavigation).WithMany(p => p.Monitors)
                .HasForeignKey(d => d.IdEspecialidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Profesor_Profesor");
        });

        modelBuilder.Entity<Reserva>(entity =>
        {
            entity.HasKey(e => e.IdReserva);

            entity.ToTable("Reserva");

            entity.Property(e => e.IdReserva).HasColumnName("idReserva");
            entity.Property(e => e.Estado).HasColumnName("estado");
            entity.Property(e => e.IdCliente).HasColumnName("idCliente");
            entity.Property(e => e.IdHorario).HasColumnName("idHorario");
            entity.Property(e => e.OrdenInscripcion).HasColumnName("ordenInscripcion");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Reserva_Cliente");

            entity.HasOne(d => d.IdHorarioNavigation).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.IdHorario)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Reserva_Horario");
        });

        modelBuilder.Entity<Sala>(entity =>
        {
            entity.HasKey(e => e.IdSala).HasName("PK_Aula");

            entity.ToTable("Sala");

            entity.Property(e => e.IdSala).HasColumnName("idSala");
            entity.Property(e => e.NombreSala)
                .IsRequired()
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("nombreSala");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
