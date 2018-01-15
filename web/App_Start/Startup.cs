using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(web.Startup))]
namespace web
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
        }
    }
}