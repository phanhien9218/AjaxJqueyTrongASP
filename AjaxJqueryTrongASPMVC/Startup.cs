using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AjaxJqueryTrongASPMVC.Startup))]
namespace AjaxJqueryTrongASPMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
