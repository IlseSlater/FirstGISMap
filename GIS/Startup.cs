using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GIS.Startup))]
namespace GIS
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
