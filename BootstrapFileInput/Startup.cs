using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BootstrapFileInput.Startup))]
namespace BootstrapFileInput
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
