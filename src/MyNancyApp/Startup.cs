using Microsoft.Owin;
using MyNancyApp;
using Owin;

[assembly: OwinStartup(typeof(Startup))]

namespace MyNancyApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureNancy(app);
        }
    }
}