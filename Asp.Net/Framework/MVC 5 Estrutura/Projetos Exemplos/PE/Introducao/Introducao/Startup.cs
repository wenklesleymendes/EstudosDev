using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Introducao.Startup))]
namespace Introducao
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
