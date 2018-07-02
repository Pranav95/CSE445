using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Assignment_5_Final.Startup))]
namespace Assignment_5_Final
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
