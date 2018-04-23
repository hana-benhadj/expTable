using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(expTable.Startup))]
namespace expTable
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
