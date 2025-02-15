using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace HSteste.EntityFrameworkCore;

public static class HStesteDbContextConfigurer
{
    public static void Configure(DbContextOptionsBuilder<HStesteDbContext> builder, string connectionString)
    {
        //builder.UseSqlServer(connectionString);
        builder.UseNpgsql(connectionString);
    }

    public static void Configure(DbContextOptionsBuilder<HStesteDbContext> builder, DbConnection connection)
    {
        //builder.UseSqlServer(connection);
        builder.UseNpgsql(connection);
    }
}
