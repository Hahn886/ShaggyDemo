using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ShaggyDemo.Startup))]
namespace ShaggyDemo
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
