using ProjetoDDD.Application;
using ProjetoDDD.Application.Interface;
using ProjetoDDD.Domain.Interfaces.Repositories;
using ProjetoDDD.Domain.Interfaces.Services;
using ProjetoDDD.Domain.Services;
using ProjetoDDD.Infra.Data.Repositories;
using System.Web.Mvc;
using Unity;
using Unity.Lifetime;
using Unity.Mvc5;

namespace ProjetoDDD.MVC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IClienteAppService, ClienteAppService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IProdutoAppService, ProdutoAppService>(new ContainerControlledLifetimeManager());

            container.RegisterType<IClienteService, ClienteService>(new ContainerControlledLifetimeManager());
            container.RegisterType<IProdutoService, ProdutoService>(new ContainerControlledLifetimeManager());

            container.RegisterType<IClienteRepository, ClienteRepository>(new ContainerControlledLifetimeManager());
            container.RegisterType<IProdutoRepository, ProdutoRepository>(new ContainerControlledLifetimeManager());

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}