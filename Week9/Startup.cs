using Microsoft.Owin;
using Owin;


[assembly: OwinStartupAttribute(typeof(Week9.Startup))]
namespace Week9
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
      
        }
    }
}
