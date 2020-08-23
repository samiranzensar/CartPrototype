using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MVCAppClassDemo
{
	public class RouteConfig
	{
		public static void RegisterRoutes(RouteCollection routes)
		{
			routes.IgnoreRoute("{resource}.axd/{*pathInfo}");
			routes.MapMvcAttributeRoutes();
			//default

			routes.MapRoute(
			   name: "Default",
			   url: "{controller}/{action}/{id}",
			   defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
			  );

			//routes.MapRoute(
			//   name: "Default",
			//   url: "{controller}/{action}/{id}",
			//   defaults: new { controller = "Movies", action = "Random", id = UrlParameter.Optional }
		   //);

			//modified
			//routes.MapRoute(
			//	"MoviesByReleaseDate",
			//	"Movies/released/{year}/{month}",
			//	new { controller = "Movies", action="ByReleaseDate" },
			//new { year=@"\d{4}" , month = @"\d{2}" }

			//AttributeRouting
		}
	}
}
