using Autofac;
using Vueling.Domain.Entities;
using Vueling.Infrastructure.Repositories.Contracts;
using Vueling.Infrastructure.Repositories.Implementations;
using Vueling.Test.Framework;

namespace Vueling.Infrastructure.Repository.Integration.Tests.AutofacModules
{
    public class RepositoryModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<StudentRepository>().As<IRepository<Student>>();

            builder.RegisterModule<LoggingModule>();

            base.Load(builder);
        }
    }
}
