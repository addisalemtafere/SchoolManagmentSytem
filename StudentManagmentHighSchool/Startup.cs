using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(StudentManagmentHighSchool.Startup))]
namespace StudentManagmentHighSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
