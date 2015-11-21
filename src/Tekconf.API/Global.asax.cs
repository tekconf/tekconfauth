using AutoMapper;
using Tekconf.Data.Entities;

namespace Tekconf.API
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        { 
            var bootstrapper = new Bootstrapper();
            bootstrapper.Init();
        }
    }

    public class Bootstrapper
    {
        public void Init()
        {
            Mapper.CreateMap<Conference, DTO.Conference>();
        }
    }
}
