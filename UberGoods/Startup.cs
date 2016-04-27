using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UberGoods.Startup))]
namespace UberGoods
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
