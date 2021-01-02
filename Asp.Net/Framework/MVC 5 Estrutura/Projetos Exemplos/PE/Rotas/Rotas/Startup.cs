using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rotas.Startup))]
namespace Rotas
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
