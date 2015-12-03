using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WeddingPage.Startup))]
namespace WeddingPage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
