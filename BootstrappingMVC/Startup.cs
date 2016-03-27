using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrappingMVC.Startup))]
namespace BootstrappingMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
