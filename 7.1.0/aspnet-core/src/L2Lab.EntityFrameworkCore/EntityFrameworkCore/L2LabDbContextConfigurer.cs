using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace L2Lab.EntityFrameworkCore
{
    public static class L2LabDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<L2LabDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<L2LabDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
