using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using SMS.ALL.Authorization.Roles;
using SMS.ALL.Authorization.Users;
using SMS.ALL.MultiTenancy;

namespace SMS.ALL.EntityFrameworkCore
{
    public class ALLDbContext : AbpZeroDbContext<Tenant, Role, User, ALLDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ALLDbContext(DbContextOptions<ALLDbContext> options)
            : base(options)
        {
        }
    }
}
