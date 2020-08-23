using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebMvcTill22Aug.Startup))]
namespace WebMvcTill22Aug
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
