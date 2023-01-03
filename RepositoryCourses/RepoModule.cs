using Autofac;
using Microsoft.IdentityModel.Tokens;
using RepositoryCourses.Data_Access.Implementation;
using RepositoryCourses.Domain.Repositories;
using RepositoryCourses.Services;
using System.Reflection;
using System;
using RepositoryCourses.Domain.Implementation;

namespace RepositoryCourses
{
    public class RepoModule:Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterGeneric(typeof(Repository<>)).As(typeof(IRepository<>))
                .InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(GenericService<>)).As(typeof(IService<>)).InstancePerLifetimeScope();
            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>();
            

           }

    }
}
