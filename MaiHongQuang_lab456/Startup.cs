using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MaiHongQuang_lab456.Startup))]
namespace MaiHongQuang_lab456
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
