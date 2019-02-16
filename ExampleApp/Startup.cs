using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExampleApp.Startup))]
namespace ExampleApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
