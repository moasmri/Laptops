using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Laptops.Startup))]
namespace Laptops
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
