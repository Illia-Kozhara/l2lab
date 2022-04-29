using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using L2Lab.Authorization;

namespace L2Lab
{
    [DependsOn(
        typeof(L2LabCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class L2LabApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<L2LabAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(L2LabApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
