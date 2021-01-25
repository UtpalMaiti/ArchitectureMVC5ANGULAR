using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace SMS.ALL.EntityFrameworkCore
{
    public static class ALLDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ALLDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ALLDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
