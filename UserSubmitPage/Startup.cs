using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(UserSubmitPage.Startup))]
namespace UserSubmitPage
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
