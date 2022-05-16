using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using L2Lab.Configuration;
using L2Lab.EntityFrameworkCore;
using L2Lab.Migrator.DependencyInjection;
using L2Lab.Messages;
using Abp.Dependency;
using Abp.Domain.Repositories;

namespace L2Lab.Migrator
{
    [DependsOn(typeof(L2LabEntityFrameworkModule))]
    public class L2LabMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public L2LabMigratorModule(L2LabEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(L2LabMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                L2LabConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.Register<IRepository, L2LabMessage>(DependencyLifeStyle.Transient);
            IocManager.Register<IMessageAppService, MessageAppService>(DependencyLifeStyle.Transient);
            IocManager.RegisterAssemblyByConvention(typeof(L2LabMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);

        }
    }
}
