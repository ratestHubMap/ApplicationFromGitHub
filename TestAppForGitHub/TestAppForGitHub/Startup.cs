using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestAppForGitHub.Startup))]
namespace TestAppForGitHub
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
