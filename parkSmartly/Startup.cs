using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(parkSmartly.Startup))]
namespace parkSmartly
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
