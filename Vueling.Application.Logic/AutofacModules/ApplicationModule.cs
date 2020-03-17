using Autofac;
using Vueling.Domain.Entities;
using Vueling.Infrastructure.Repositories.Contracts;
using Vueling.Infrastructure.Repositories.Implementations;

namespace Vueling.Application.Logic.AutofacModules
{
    public class ApplicationModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentRepository>().
                    As<IRepository<Student>>();

            base.Load(builder);
        }
    }
}
