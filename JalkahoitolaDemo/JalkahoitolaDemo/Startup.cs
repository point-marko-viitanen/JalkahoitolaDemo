using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(JalkahoitolaDemo.Startup))]
namespace JalkahoitolaDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
