using FlexiDevWitchSagaMVC.Controllers;
using FlexiDevWitchSagaMVC.Services.Implementations;
using FlexiDevWitchSagaMVC.Services.Interfaces;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace FlexiDevWitchSagaMVC
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // Register your service with the container
            container.RegisterType<IVillagerService, VillagerService>();
            container.RegisterType<IWitcherService, WitcherService>();

            // Register your controllers
            container.RegisterType<PersonController>();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}