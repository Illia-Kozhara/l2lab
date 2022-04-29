using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using L2Lab.EntityFrameworkCore;
using L2Lab.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace L2Lab.Web.Tests
{
    [DependsOn(
        typeof(L2LabWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class L2LabWebTestModule : AbpModule
    {
        public L2LabWebTestModule(L2LabEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(L2LabWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(L2LabWebMvcModule).Assembly);
        }
    }
}