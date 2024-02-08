using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Clase11nuevo.Models;

namespace Clase11nuevo.Database
{
    public partial class CoderContext : DbContext
    {
        public CoderContext()
        {
        }

        public CoderContext(DbContextOptions<CoderContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Producto> Productos { get; set; } = null!;
        public virtual DbSet<Productosvendido> Productosvendidos { get; set; } = null!;
        public virtual DbSet<Usuario> Usuario { get; set; } = null!;
        public virtual DbSet<Ventum> Venta { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database = proyecto; Trusted_Connection = True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Producto>(entity =>
            {
                entity.ToTable("productos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Costo).HasColumnName("costo");

                entity.Property(e => e.Descripcion)
                    .IsUnicode(false)
                    .HasColumnName("descripcion");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");

                entity.Property(e => e.Precioventa).HasColumnName("precioventa");

                entity.Property(e => e.Stock).HasColumnName("stock");
            });

            modelBuilder.Entity<Productosvendido>(entity =>
            {
                entity.ToTable("productosvendidos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Idproducto).HasColumnName("idproducto");

                entity.Property(e => e.Idventa).HasColumnName("idventa");

                entity.Property(e => e.Stock).HasColumnName("stock");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.ToTable("usuarios");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Apellido)
                    .IsUnicode(false)
                    .HasColumnName("apellido");

                entity.Property(e => e.Contraseña)
                    .IsUnicode(false)
                    .HasColumnName("contraseña");

                entity.Property(e => e.Mail)
                    .IsUnicode(false)
                    .HasColumnName("mail");

                entity.Property(e => e.Nombre)
                    .IsUnicode(false)
                    .HasColumnName("nombre");

                entity.Property(e => e.NombreUsuario)
                    .IsUnicode(false)
                    .HasColumnName("nombreUsuario");
            });

            modelBuilder.Entity<Ventum>(entity =>
            {
                entity.ToTable("venta");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comentarios)
                    .IsUnicode(false)
                    .HasColumnName("comentarios");

                entity.Property(e => e.Idusuario).HasColumnName("idusuario");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
