using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCAppsWithAuthentication.Startup))]
namespace MVCAppsWithAuthentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
