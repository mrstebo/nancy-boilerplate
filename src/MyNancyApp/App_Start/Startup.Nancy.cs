using Nancy;
using Nancy.Owin;
using Owin;

namespace MyNancyApp
{
    public partial class Startup
    {
        private static void ConfigureNancy(IAppBuilder app)
        {
            app.UseNancy(options => options.PassThroughWhenStatusCodesAre(HttpStatusCode.NotFound));
        }
    }
}