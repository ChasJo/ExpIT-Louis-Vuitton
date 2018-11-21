using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ExperienceIT_Final_Project.Startup))]
namespace ExperienceIT_Final_Project
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
