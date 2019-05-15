using System.Web.Http;
using Unity;
using Unity.WebApi;
using BAL;
namespace Census_Data_Digitalization
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>();
            container.RegisterType<IUserService, UserService>();
            container.RegisterType<IPopulationService, PopulationService>();
            container.RegisterType<IHouseService, HouseService>();

            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}