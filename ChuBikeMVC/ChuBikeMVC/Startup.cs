using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ChuBikeMVC.Startup))]
namespace ChuBikeMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
