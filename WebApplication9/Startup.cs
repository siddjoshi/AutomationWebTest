using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AutomationWebTest.Startup))]
namespace AutomationWebTest
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
