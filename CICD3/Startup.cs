using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CICD3.Startup))]
namespace CICD3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
