using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using SportsStore.WebUI.Infrastructure;

namespace SportsStore.WebUI
{
	public class MvcApplication : System.Web.HttpApplication
	{
		protected void Application_Start()
		{
			ControllerBuilder.Current.SetControllerFactory(new NinjectControllerFactory());
			AreaRegistration.RegisterAllAreas();
			FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
			RouteConfig.RegisterRoutes(RouteTable.Routes);
			BundleConfig.RegisterBundles(BundleTable.Bundles);	
		}
	}
}
