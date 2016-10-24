using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TESTGIT.Startup))]
namespace TESTGIT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
