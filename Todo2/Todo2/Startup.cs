using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Todo2.Startup))]
namespace Todo2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
