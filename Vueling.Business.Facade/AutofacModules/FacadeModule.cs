using Autofac;
using Autofac.Integration.WebApi;
using System.Reflection;
using Vueling.Application.Logic.AutofacModules;
using Vueling.Application.Logic.Contracts;
using Vueling.Application.Logic.Implementations;
using Vueling.Domain.Entities;

namespace Vueling.Business.Facade.AutofacModules
{
    public class FacadeModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterApiControllers(Assembly.
                    GetExecutingAssembly());

            builder.RegisterType<StudentService>().As<IService<Student>>();

            builder.RegisterModule(new LoggingModule());
            builder.RegisterModule(new ApplicationModule());

            base.Load(builder);
        }
    }
}