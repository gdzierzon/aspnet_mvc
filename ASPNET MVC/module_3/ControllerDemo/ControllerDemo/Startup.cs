using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ControllerDemo.Startup))]
namespace ControllerDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
