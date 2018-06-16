using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VidlyMVCApp.Startup))]
namespace VidlyMVCApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
