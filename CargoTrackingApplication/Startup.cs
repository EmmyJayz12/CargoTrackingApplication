using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CargoTrackingApplication.Startup))]
namespace CargoTrackingApplication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
