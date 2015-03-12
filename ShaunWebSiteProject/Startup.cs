using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShaunWebSiteProject.Startup))]
namespace ShaunWebSiteProject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
