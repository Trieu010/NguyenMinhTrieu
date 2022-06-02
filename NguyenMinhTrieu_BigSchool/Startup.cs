using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NguyenMinhTrieu_BigSchool.Startup))]
namespace NguyenMinhTrieu_BigSchool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
