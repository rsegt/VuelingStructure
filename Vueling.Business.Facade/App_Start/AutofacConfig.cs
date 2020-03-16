using Autofac;
using Autofac.Integration.WebApi;
using System.Web.Http;
using Vueling.Application.Logic.AutofacModules;
using Vueling.Business.Facade.AutofacModules;

namespace Vueling.Business.Facade.App_Start
{
    public class AutofacConfig
    {
        protected AutofacConfig()
        {
        }

        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterModule(new FacadeModule());
            builder.RegisterModule(new LogicModule());

            var container = builder.Build();
            var resolver = new AutofacWebApiDependencyResolver(container);
            GlobalConfiguration.Configuration.
                DependencyResolver = resolver;

            return container;
        }
    }
}