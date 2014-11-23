using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Google.Auth.Mvc.Startup))]
namespace Google.Auth.Mvc
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
