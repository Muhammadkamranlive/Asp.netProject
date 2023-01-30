using Autofac;
using RepositoryCourses.Data_Access.Implementation;
using RepositoryCourses.Domain.Implementation;
using RepositoryCourses.Domain.Repositories;
using RepositoryCourses.Services.Implementation;
using RepositoryCourses.Services.Interfaces;

namespace RepositoryCourses
{
    public class RepoModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>))
                .InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(GenericService<>)).As(typeof(IGenericService<>)).InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();


        }

    }
}
