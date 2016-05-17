using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TestniCMS2.Startup))]
namespace TestniCMS2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
