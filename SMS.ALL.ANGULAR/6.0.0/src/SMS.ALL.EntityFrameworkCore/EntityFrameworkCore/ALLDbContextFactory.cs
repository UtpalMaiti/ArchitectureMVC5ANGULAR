using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using SMS.ALL.Configuration;
using SMS.ALL.Web;

namespace SMS.ALL.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ALLDbContextFactory : IDesignTimeDbContextFactory<ALLDbContext>
    {
        public ALLDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ALLDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ALLDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ALLConsts.ConnectionStringName));

            return new ALLDbContext(builder.Options);
        }
    }
}
