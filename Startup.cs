using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(lab_authentication.Startup))]
namespace lab_authentication
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
