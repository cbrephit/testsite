using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(testSite.Startup))]
namespace testSite
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
