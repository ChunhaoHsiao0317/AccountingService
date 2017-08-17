using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AccountingService.Startup))]
namespace AccountingService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
