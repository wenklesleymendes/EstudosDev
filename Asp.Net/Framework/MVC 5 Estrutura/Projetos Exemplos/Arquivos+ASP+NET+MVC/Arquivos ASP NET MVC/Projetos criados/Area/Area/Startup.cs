using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Area.Startup))]
namespace Area
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
