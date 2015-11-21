using Microsoft.Owin;
using Owin;


[assembly: OwinStartup(typeof(Tekconf.API.Startup))]

namespace Tekconf.API
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseWebApi(WebApiConfig.Register()); 
             
        }
    }
}