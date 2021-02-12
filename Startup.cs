using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(New_controle.Startup))]
namespace New_controle
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
