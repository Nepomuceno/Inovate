using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Inovate.Web.Startup))]
namespace Inovate.Web
{
    public partial class Startup 
    {
        public void Configuration(IAppBuilder app) 
        {
            ConfigureAuth(app);
        }
    }
}
