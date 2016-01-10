using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearningFives.Startup))]
namespace LearningFives
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
