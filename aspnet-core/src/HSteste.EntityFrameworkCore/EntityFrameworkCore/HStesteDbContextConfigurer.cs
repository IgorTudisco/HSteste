using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace HSteste.EntityFrameworkCore;

public static class HStesteDbContextConfigurer
{
    // This is used by the EF Core DBContext to connect to the database.
    // Defining the use of the PostgreSQL DB as my bank and passing the connection string.
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
