using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Dirk_van_Zyl_basic.Startup))]
namespace Dirk_van_Zyl_basic
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
