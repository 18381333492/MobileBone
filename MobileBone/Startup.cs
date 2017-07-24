using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MobileBone.Startup))]
namespace MobileBone
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
