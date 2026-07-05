using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace sssunum
{
    [DependsOn(typeof(sssunumCoreModule), typeof(AbpAutoMapperModule))]
    public class sssunumApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                cfg.AddMaps(typeof(sssunumApplicationModule).GetAssembly());
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(sssunumApplicationModule).GetAssembly());
        }
    }
}
