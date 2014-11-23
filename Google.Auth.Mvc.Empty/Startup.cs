using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(Google.Auth.Mvc.Empty.Startup))]
namespace Google.Auth.Mvc.Empty
{

    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}