using FlexiDevWitchSagaMVC.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Unity;
using Unity.Mvc5;

namespace FlexiDevWitchSagaMVC.Config
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
            var container = new UnityContainer();

            // Register all your components with the container here
            // e.g. container.RegisterType<ITestService, TestService>();

            // Register your controllers
            container.RegisterType<IController, PersonController>("PersonController");

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }
    }
}