using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(sampleApi.Startup))]
namespace sampleApi
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
