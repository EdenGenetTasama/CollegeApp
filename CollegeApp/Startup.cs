using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CollegeApp.Startup))]
namespace CollegeApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
