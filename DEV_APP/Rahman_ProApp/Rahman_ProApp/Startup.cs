using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rahman_ProApp.Startup))]
namespace Rahman_ProApp
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
