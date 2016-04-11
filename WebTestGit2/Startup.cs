using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebTestGit2.Startup))]
namespace WebTestGit2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
