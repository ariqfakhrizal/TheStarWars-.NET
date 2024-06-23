using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace FlexiDevWitchSagaMVC
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            UnityConfig.RegisterComponents(); // Ensure this line is present to register Unity
        }
    }
}
