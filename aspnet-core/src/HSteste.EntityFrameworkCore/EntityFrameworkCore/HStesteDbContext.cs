using Abp.Zero.EntityFrameworkCore;
using HSteste.Authorization.Roles;
using HSteste.Authorization.Users;
using HSteste.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace HSteste.EntityFrameworkCore;

public class HStesteDbContext : AbpZeroDbContext<Tenant, Role, User, HStesteDbContext>
{
    /* Define a DbSet for each entity of the application */

    public HStesteDbContext(DbContextOptions<HStesteDbContext> options)
        : base(options)
    {
    }
}
