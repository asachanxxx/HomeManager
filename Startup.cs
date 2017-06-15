using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeManager.Startup))]
namespace HomeManager
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
