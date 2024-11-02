using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Datos.Models;

namespace Datos;

public partial class Context : DbContext {
    public Context() {
    }
    public Context(DbContextOptions<Context> options)
        : base(options) {
    }

    public virtual DbSet<AlumnosInscripcione> AlumnosInscripciones { get; set; }

    public virtual DbSet<Comisione> Comisiones { get; set; }

    public virtual DbSet<Curso> Cursos { get; set; }

    public virtual DbSet<DocentesCurso> DocentesCursos { get; set; }

    public virtual DbSet<Especialidade> Especialidades { get; set; }

    public virtual DbSet<Materia> Materias { get; set; }

    public virtual DbSet<Persona> Personas { get; set; }

    public virtual DbSet<Plane> Planes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.UseCollation("Modern_Spanish_CI_AS");

        modelBuilder.Entity<AlumnosInscripcione>(entity => {
            entity.HasKey(e => e.IdInscripcion);

            entity.ToTable("alumnos_inscripciones");

            entity.Property(e => e.IdInscripcion).HasColumnName("id_inscripcion");
            entity.Property(e => e.Condicion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("condicion");
            entity.Property(e => e.IdAlumno).HasColumnName("id_alumno");
            entity.Property(e => e.IdCurso).HasColumnName("id_curso");
            entity.Property(e => e.Nota).HasColumnName("nota");

            entity.HasOne(d => d.IdAlumnoNavigation).WithMany(p => p.AlumnosInscripciones)
                .HasForeignKey(d => d.IdAlumno)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_alumnos_inscripciones_personas");

            entity.HasOne(d => d.IdCursoNavigation).WithMany(p => p.AlumnosInscripciones)
                .HasForeignKey(d => d.IdCurso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_alumnos_inscripciones_cursos");
        });

        modelBuilder.Entity<Comisione>(entity => {
            entity.HasKey(e => e.IdComision);

            entity.ToTable("comisiones");

            entity.Property(e => e.IdComision).HasColumnName("id_comision");
            entity.Property(e => e.AnioEspecialidad).HasColumnName("anio_especialidad");
            entity.Property(e => e.DescComision)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("desc_comision");
            entity.Property(e => e.IdPlan).HasColumnName("id_plan");

            entity.HasOne(d => d.IdPlanNavigation).WithMany(p => p.Comisiones)
                .HasForeignKey(d => d.IdPlan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_comisiones_planes");
        });

        modelBuilder.Entity<Curso>(entity => {
            entity.HasKey(e => e.IdCurso);

            entity.ToTable("cursos");

            entity.Property(e => e.IdCurso).HasColumnName("id_curso");
            entity.Property(e => e.AnioCalendario).HasColumnName("anio_calendario");
            entity.Property(e => e.Cupo).HasColumnName("cupo");
            entity.Property(e => e.IdComision).HasColumnName("id_comision");
            entity.Property(e => e.IdMateria).HasColumnName("id_materia");

            entity.HasOne(d => d.IdComisionNavigation).WithMany(p => p.Cursos)
                .HasForeignKey(d => d.IdComision)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cursos_comisiones");

            entity.HasOne(d => d.IdMateriaNavigation).WithMany(p => p.Cursos)
                .HasForeignKey(d => d.IdMateria)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_cursos_materias");
        });

        modelBuilder.Entity<DocentesCurso>(entity => {
            entity.HasKey(e => e.IdDictado);

            entity.ToTable("docentes_cursos");

            entity.Property(e => e.IdDictado).HasColumnName("id_dictado");
            entity.Property(e => e.Cargo).HasColumnName("cargo");
            entity.Property(e => e.IdCurso).HasColumnName("id_curso");
            entity.Property(e => e.IdDocente).HasColumnName("id_docente");

            entity.HasOne(d => d.IdCursoNavigation).WithMany(p => p.DocentesCursos)
                .HasForeignKey(d => d.IdCurso)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_docentes_cursos_cursos");

            entity.HasOne(d => d.IdDocenteNavigation).WithMany(p => p.DocentesCursos)
                .HasForeignKey(d => d.IdDocente)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_docentes_cursos_personas");
        });

        modelBuilder.Entity<Especialidade>(entity => {
            entity.HasKey(e => e.IdEspecialidad);

            entity.ToTable("especialidades");

            entity.Property(e => e.IdEspecialidad).HasColumnName("id_especialidad");
            entity.Property(e => e.DescEspecialidad)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("desc_especialidad");
        });

        modelBuilder.Entity<Materia>(entity => {
            entity.HasKey(e => e.IdMateria);

            entity.ToTable("materias");

            entity.Property(e => e.IdMateria).HasColumnName("id_materia");
            entity.Property(e => e.DescMateria)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("desc_materia");
            entity.Property(e => e.HsSemanales).HasColumnName("hs_semanales");
            entity.Property(e => e.HsTotales).HasColumnName("hs_totales");
            entity.Property(e => e.IdPlan).HasColumnName("id_plan");

            entity.HasOne(d => d.IdPlanNavigation).WithMany(p => p.Materia)
                .HasForeignKey(d => d.IdPlan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_materias_planes");
        });

        modelBuilder.Entity<Persona>(entity => {
            entity.HasKey(e => e.IdPersona);

            entity.ToTable("personas");

            entity.Property(e => e.IdPersona).HasColumnName("id_persona");
            entity.Property(e => e.Apellido)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("apellido");
            entity.Property(e => e.Clave)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("clave");
            entity.Property(e => e.Direccion)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("direccion");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FechaNac)
                .HasColumnType("datetime")
                .HasColumnName("fecha_nac");
            entity.Property(e => e.IdPlan).HasColumnName("id_plan");
            entity.Property(e => e.Legajo).HasColumnName("legajo");
            entity.Property(e => e.Nombre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre");
            entity.Property(e => e.NombreUsuario)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("nombre_usuario");
            entity.Property(e => e.Telefono)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("telefono");
            entity.Property(e => e.TipoPersona)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("tipo_persona");

            entity.HasOne(d => d.IdPlanNavigation).WithMany(p => p.Personas)
                .HasForeignKey(d => d.IdPlan)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_personas_planes");
        });

        modelBuilder.Entity<Plane>(entity => {
            entity.HasKey(e => e.IdPlan);

            entity.ToTable("planes");

            entity.Property(e => e.IdPlan).HasColumnName("id_plan");
            entity.Property(e => e.DescPlan)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("desc_plan");
            entity.Property(e => e.IdEspecialidad).HasColumnName("id_especialidad");

            entity.HasOne(d => d.IdEspecialidadNavigation).WithMany(p => p.Planes)
                .HasForeignKey(d => d.IdEspecialidad)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_planes_especialidades");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
