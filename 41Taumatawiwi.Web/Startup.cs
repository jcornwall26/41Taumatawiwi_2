using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_41Taumatawiwi.Web.Startup))]
namespace _41Taumatawiwi.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
