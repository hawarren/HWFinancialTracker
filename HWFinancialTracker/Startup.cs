using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HWFinancialTracker.Startup))]
namespace HWFinancialTracker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
