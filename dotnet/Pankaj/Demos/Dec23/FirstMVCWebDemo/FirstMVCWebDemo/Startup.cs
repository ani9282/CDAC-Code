using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstMVCWebDemo.Startup))]
namespace FirstMVCWebDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
