using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IndividualAccountDemo.Startup))]
namespace IndividualAccountDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
