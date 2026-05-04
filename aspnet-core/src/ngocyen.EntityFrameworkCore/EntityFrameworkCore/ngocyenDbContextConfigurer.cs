using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ngocyen.EntityFrameworkCore
{
    public static class ngocyenDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ngocyenDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ngocyenDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
