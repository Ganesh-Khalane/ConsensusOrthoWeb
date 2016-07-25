using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Consensus.Ortho.Web.Startup))]
namespace Consensus.Ortho.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
