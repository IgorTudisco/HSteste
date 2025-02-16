using Abp.Zero.EntityFrameworkCore;
using HSteste.Authorization.Roles;
using HSteste.Authorization.Users;
using HSteste.Core.Models;
using HSteste.MultiTenancy;
using Microsoft.EntityFrameworkCore;

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
    }

}


