﻿using Microsoft.EntityFrameworkCore;

namespace EFCoreCRUD.Models.Contexts
{
    public class EFCoreCRUDContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }

        public EFCoreCRUDContext(DbContextOptions<EFCoreCRUDContext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>(entidade =>
            {
                entidade.HasKey(u => u.Codigo);
                entidade.Property(u => u.Codigo)
                    .ValueGeneratedOnAdd()
                    .HasColumnType("integer");

                entidade.Property(u => u.Nome)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnType("varchar");

                entidade.Property(u => u.Idade)
                    .IsRequired()
                    .HasColumnType("integer");

                entidade.Property(u => u.Endereco)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .HasColumnType("varchar");

                entidade.Property(u => u.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnType("varchar");

                entidade.Property(u => u.Telefone)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnType("varchar");

                entidade.Property(u => u.InfoComplentares)
                    .HasMaxLength(1000)
                    .HasColumnType("varchar");
            });
        }
    }
}