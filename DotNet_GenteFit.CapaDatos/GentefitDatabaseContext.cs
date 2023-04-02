using System;
using System.Collections.Generic;
using DotNet_GenteFit.CapaDatos.Entidades;
using Microsoft.EntityFrameworkCore;

namespace DotNet_GenteFit.CapaDatos;

public partial class GentefitDatabaseContext : DbContext
{
    public GentefitDatabaseContext()
    {
    }

    public GentefitDatabaseContext(DbContextOptions<GentefitDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Administrador> Administradors { get; set; }

    public virtual DbSet<Aula> Aulas { get; set; }

    public virtual DbSet<Cliente> Clientes { get; set; }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<Dium> Dia { get; set; }

    public virtual DbSet<Especialidad> Especialidads { get; set; }

    public virtual DbSet<Hora> Horas { get; set; }

    public virtual DbSet<Profesor> Profesors { get; set; }

    public virtual DbSet<Reserva> Reservas { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=(local);Initial Catalog=GentefitDatabase;Integrated Security=True;Trust Server Certificate=true");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.UseCollation("Latin1_General_CI_AS");

        modelBuilder.Entity<Administrador>(entity =>
        {
            entity.HasKey(e => e.IdAdmin);

            entity.ToTable("Administrador");

            entity.Property(e => e.IdAdmin).HasColumnName("idAdmin");
            entity.Property(e => e.EmailAdmin)
                .HasMaxLength(50)
                .HasColumnName("emailAdmin");
            entity.Property(e => e.PasswordAdmin)
                .HasMaxLength(50)
                .HasColumnName("passwordAdmin");
            entity.Property(e => e.UsernameAdmin)
                .HasMaxLength(50)
                .HasColumnName("usernameAdmin");
        });

        modelBuilder.Entity<Aula>(entity =>
        {
            entity.HasKey(e => e.IdAula);

            entity.ToTable("Aula");

            entity.Property(e => e.IdAula).HasColumnName("idAula");
            entity.Property(e => e.NumeroAula).HasColumnName("numeroAula");
        });

        modelBuilder.Entity<Cliente>(entity =>
        {
            entity.HasKey(e => e.IdCliente);

            entity.ToTable("Cliente");

            entity.Property(e => e.IdCliente).HasColumnName("idCliente");
            entity.Property(e => e.CuentaBanco)
                .HasMaxLength(50)
                .HasColumnName("cuentaBanco");
            entity.Property(e => e.DireccionCliente)
                .HasMaxLength(50)
                .HasColumnName("direccionCliente");
            entity.Property(e => e.EmailCliente)
                .HasMaxLength(50)
                .HasColumnName("emailCliente");
            entity.Property(e => e.FechaAlta)
                .HasColumnType("date")
                .HasColumnName("fechaAlta");
            entity.Property(e => e.FechanacimientoCliente)
                .HasColumnType("date")
                .HasColumnName("fechanacimientoCliente");
            entity.Property(e => e.GeneroCliente)
                .HasMaxLength(50)
                .HasColumnName("generoCliente");
            entity.Property(e => e.NombreCliente)
                .HasMaxLength(50)
                .HasColumnName("nombreCliente");
            entity.Property(e => e.PasswordCliente)
                .HasMaxLength(50)
                .HasColumnName("passwordCliente");
            entity.Property(e => e.UsernameCliente)
                .HasMaxLength(50)
                .HasColumnName("usernameCliente");
        });

        modelBuilder.Entity<Curso>(entity =>
        {
            entity.HasKey(e => e.IdCurso);

            entity.ToTable("Curso");

            entity.Property(e => e.IdCurso).HasColumnName("idCurso");
            entity.Property(e => e.IdAula).HasColumnName("idAula");
            entity.Property(e => e.IdDia).HasColumnName("idDia");
            entity.Property(e => e.IdHora).HasColumnName("idHora");
            entity.Property(e => e.IdProfesor).HasColumnName("idProfesor");
            entity.Property(e => e.NombreCurso)
                .HasMaxLength(50)
                .HasColumnName("nombreCurso");

            entity.HasOne(d => d.IdAulaNavigation).WithMany(p => p.Cursos)
                .HasForeignKey(d => d.IdAula)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Curso_Aula");

            entity.HasOne(d => d.IdDiaNavigation).WithMany(p => p.Cursos)
                .HasForeignKey(d => d.IdDia)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Curso_Dia");

            entity.HasOne(d => d.IdHoraNavigation).WithMany(p => p.Cursos)
                .HasForeignKey(d => d.IdHora)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Curso_Hora");

            entity.HasOne(d => d.IdProfesorNavigation).WithMany(p => p.Cursos)
                .HasForeignKey(d => d.IdProfesor)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Curso_Profesor");
        });

        modelBuilder.Entity<Dium>(entity =>
        {
            entity.HasKey(e => e.IdDia);

            entity.Property(e => e.IdDia).HasColumnName("idDia");
            entity.Property(e => e.Fecha)
                .HasColumnType("date")
                .HasColumnName("fecha");
        });

        modelBuilder.Entity<Especialidad>(entity =>
        {
            entity.HasKey(e => e.IdEspecialidad);

            entity.ToTable("Especialidad");

            entity.Property(e => e.IdEspecialidad).HasColumnName("idEspecialidad");
            entity.Property(e => e.NombreEspecialidad)
                .HasMaxLength(50)
                .HasColumnName("nombreEspecialidad");
        });

        modelBuilder.Entity<Hora>(entity =>
        {
            entity.HasKey(e => e.IdHora);

            entity.ToTable("Hora");

            entity.Property(e => e.IdHora).HasColumnName("idHora");
            entity.Property(e => e.HoraFinal).HasColumnName("horaFinal");
            entity.Property(e => e.HoraInicio).HasColumnName("horaInicio");
        });

        modelBuilder.Entity<Profesor>(entity =>
        {
            entity.HasKey(e => e.IdProfesor);

            entity.ToTable("Profesor");

            entity.Property(e => e.IdProfesor).HasColumnName("idProfesor");
            entity.Property(e => e.IdEspecialidad).HasColumnName("idEspecialidad");
            entity.Property(e => e.NombreProfesor)
                .HasMaxLength(50)
                .HasColumnName("nombreProfesor");

            entity.HasOne(d => d.IdEspecialidadNavigation).WithMany(p => p.Profesors)
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
            entity.Property(e => e.IdCurso).HasColumnName("idCurso");
            entity.Property(e => e.NumeroEspera).HasColumnName("numeroEspera");

            entity.HasOne(d => d.IdClienteNavigation).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.IdCliente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Reserva_Cliente");

            entity.HasOne(d => d.IdCursoNavigation).WithMany(p => p.Reservas)
                .HasForeignKey(d => d.IdCurso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Reserva_Curso");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
