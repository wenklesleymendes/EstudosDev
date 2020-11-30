using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RenderLayout.Startup))]
namespace RenderLayout
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
