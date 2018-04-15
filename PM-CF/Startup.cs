using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PM_CF.Startup))]
namespace PM_CF
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
