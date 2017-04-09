using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UpMyPartyFrontEnd.Startup))]
namespace UpMyPartyFrontEnd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
