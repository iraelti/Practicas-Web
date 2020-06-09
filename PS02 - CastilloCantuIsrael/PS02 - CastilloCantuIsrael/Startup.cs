using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PS02.CastilloCantu.Startup))]
namespace PS02.CastilloCantu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
