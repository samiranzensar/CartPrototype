using System.Web;
using System.Web.Mvc;

namespace WebMvcTill22Aug
{
	public class FilterConfig
	{
		public static void RegisterGlobalFilters(GlobalFilterCollection filters)
		{
			filters.Add(new HandleErrorAttribute());
		}
	}
}
