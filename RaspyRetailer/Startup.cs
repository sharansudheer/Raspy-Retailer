using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RaspyRetailer.Startup))]
namespace RaspyRetailer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
