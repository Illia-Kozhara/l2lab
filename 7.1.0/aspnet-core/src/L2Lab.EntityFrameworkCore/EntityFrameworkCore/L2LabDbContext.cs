using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using L2Lab.Authorization.Roles;
using L2Lab.Authorization.Users;
using L2Lab.MultiTenancy;

namespace L2Lab.EntityFrameworkCore
{
    public class L2LabDbContext : AbpZeroDbContext<Tenant, Role, User, L2LabDbContext> 
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<L2LabMessage> L2LabMessages { get; set; }
        //ToDo add entity!!
        public L2LabDbContext(DbContextOptions<L2LabDbContext> options)
            : base(options)
        {

        }
    }
}
