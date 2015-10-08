using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TowerDefenceMVC.Startup))]
namespace TowerDefenceMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
