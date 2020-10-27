using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TMDT4.Startup))]
namespace TMDT4
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
