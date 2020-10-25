using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bundle.Startup))]
namespace Bundle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
