using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(angular_engine.Startup))]
namespace angular_engine
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
