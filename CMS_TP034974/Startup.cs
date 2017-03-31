using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CMS_TP034974.Startup))]
namespace CMS_TP034974
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
