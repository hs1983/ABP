using System;
using System.IO;
using System.Linq;
using System.Reflection;
using Abp.Application.Services;
using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.WebApi;
using Swashbuckle.Application;

namespace AbpCompanyName.AbpProjectName
{
    [DependsOn(typeof(AbpWebApiModule), typeof(AbpProjectNameApplicationModule))]
    public class AbpProjectNameWebApiModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());

            //配置动态生成webapi
            Configuration.Modules.AbpWebApi().DynamicApiControllerBuilder
                .ForAll<IApplicationService>(typeof(AbpProjectNameApplicationModule).Assembly, "app")
                .Build();

            ConfigureSwaggerUi();


        }
        private void ConfigureSwaggerUi()
        {
            Configuration.Modules.AbpWebApi().HttpConfiguration
                .EnableSwagger(c =>
                {
                    c.SingleApiVersion("v1", "API文档");
                    c.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                    var baseDirectory = AppDomain.CurrentDomain.BaseDirectory;

                    var commentsFileName = "bin//AbpCompanyName.AbpProjectName.Application.xml";
                    var commentsFile = Path.Combine(baseDirectory, commentsFileName);
                    //将注释的XML文档添加到SwaggerUI中
                    c.IncludeXmlComments(commentsFile);
                })
                .EnableSwaggerUi();



        }


    }
}
