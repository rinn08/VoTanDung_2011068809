using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Buoi6_2.Startup))]
namespace Buoi6_2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
