using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc5;
using ToDoList.DataAccess.Repositories;
using ToDoList.Models;
using ToDoList.Utils;

namespace ToDoList
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();

            container.RegisterType<IRepository<TDList, int>, TDListRepository>();
            container.RegisterType<ILogger, Logger>();
            
            DependencyResolver.SetResolver(new Unity.Mvc5.UnityDependencyResolver(container));
        }
    }
}