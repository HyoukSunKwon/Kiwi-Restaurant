using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(KiwiRestaurant.Web.Startup))]
namespace KiwiRestaurant.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
