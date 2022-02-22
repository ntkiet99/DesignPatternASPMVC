using DesignPatternASPMVC.Data;
using DesignPatternASPMVC.Interfaces;
using DesignPatternASPMVC.Services;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace DesignPatternASPMVC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            //container.RegisterType<DataContext>();
           container.RegisterType<IUserService, UserService>();
            
            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}