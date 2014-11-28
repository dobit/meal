using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LFNet.Meal.Web.Startup))]
namespace LFNet.Meal.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
