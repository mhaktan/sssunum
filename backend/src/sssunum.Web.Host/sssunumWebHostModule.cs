using Abp.AspNetCore;
using Abp.AspNetCore.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using sssunum.EntityFrameworkCore;

namespace sssunum.Web.Host
{
    [DependsOn(typeof(sssunumApplicationModule), typeof(sssunumEntityFrameworkCoreModule), typeof(AbpAspNetCoreModule))]
    public class sssunumWebHostModule : AbpModule
    {
        public override void PreInitialize()
        {
            // Expose all AppServices as dynamic API controllers
            Configuration.Modules.AbpAspNetCore()
                .CreateControllersForAppServices(
                    typeof(sssunumApplicationModule).GetAssembly(),
                    moduleName: "app",
                    useConventionalHttpVerbs: true
                );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(sssunumWebHostModule).GetAssembly());
        }
    }
}
