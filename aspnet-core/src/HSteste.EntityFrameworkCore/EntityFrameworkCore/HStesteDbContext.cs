using System;
using System.Linq;
using Abp.Zero.EntityFrameworkCore;
using HSteste.Authorization.Roles;
using HSteste.Authorization.Users;
using HSteste.Core.Models;
using HSteste.MultiTenancy;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace HSteste.EntityFrameworkCore
{
    public class HStesteDbContext : AbpZeroDbContext<Tenant, Role, User, HStesteDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Funcionario> Funcionarios { get; set; }

        public HStesteDbContext(DbContextOptions<HStesteDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Adiciona conversão automática de DateTime para UTC
            foreach (var entityType in modelBuilder.Model.GetEntityTypes())
            {
                var properties = entityType.GetProperties()
                    .Where(p => p.ClrType == typeof(DateTime) || p.ClrType == typeof(DateTime?));

                foreach (var property in properties)
                {
                    property.SetValueConverter(new ValueConverter<DateTime, DateTime>(
                        v => v.Kind == DateTimeKind.Utc ? v : v.ToUniversalTime(),  // Converte para UTC antes de salvar
                        v => DateTime.SpecifyKind(v, DateTimeKind.Utc)));          // Garante UTC ao ler do banco
                }
            }

            // Configuração específica para a entidade Funcionario
            modelBuilder.Entity<Funcionario>(entity =>
            {
                entity.HasKey(f => f.Id); // Define a chave primária

                entity.Property(f => f.Nome)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.ToTable("Funcionarios"); // Nome da tabela no banco
            });




        }
    }
}

