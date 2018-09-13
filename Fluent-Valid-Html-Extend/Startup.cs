using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Fluent_Valid_Html_Extend.Startup))]
namespace Fluent_Valid_Html_Extend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);

        }
    }
}
