using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Tennis.Startup))]
namespace Tennis
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
