using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using L2Lab.Configuration;
using L2Lab.Web;

namespace L2Lab.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class L2LabDbContextFactory : IDesignTimeDbContextFactory<L2LabDbContext>
    {
        public L2LabDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<L2LabDbContext>();
            
            /*
             You can provide an environmentName parameter to the AppConfigurations.Get method. 
             In this case, AppConfigurations will try to read appsettings.{environmentName}.json.
             Use Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT") method or from string[] args to get environment if necessary.
             https://docs.microsoft.com/en-us/ef/core/cli/dbcontext-creation?tabs=dotnet-core-cli#args
             */
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            L2LabDbContextConfigurer.Configure(builder, configuration.GetConnectionString(L2LabConsts.ConnectionStringName));

            return new L2LabDbContext(builder.Options);
        }
    }
}
