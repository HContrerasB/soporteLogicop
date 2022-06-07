using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AplicacionSL.Models.DB
{
    public partial class UsuarioContext : DbContext
    {
        public UsuarioContext()
        {
        }

        public UsuarioContext(DbContextOptions<UsuarioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Empleado> Empleado { get; set; }
        public virtual DbSet<Vinculacion> Vinculacion { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("server=DESKTOP-4ED3OF1; Database=Usuario; trusted_Connection=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Empleado>(entity =>
            {
                entity.HasKey(e => e.IdEmpleado);

                entity.Property(e => e.IdEmpleado).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Apellidos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Direccion)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IdCiudad).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.IdGenero).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Nombres)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Vinculacion>(entity =>
            {
                entity.HasKey(e => e.Idvinculacion);

                entity.Property(e => e.Idvinculacion).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.FechaIngreso).HasColumnType("datetime");

                entity.Property(e => e.FechaRegistro).HasColumnType("datetime");

                entity.Property(e => e.FechaRetiro).HasColumnType("datetime");

                entity.Property(e => e.IdEmpleado).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Idcargo).HasColumnType("decimal(18, 0)");

                entity.HasOne(d => d.IdEmpleadoNavigation)
                    .WithMany(p => p.Vinculacion)
                    .HasForeignKey(d => d.IdEmpleado)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vinculacion");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
