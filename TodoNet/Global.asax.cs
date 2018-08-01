using System.Data.Entity;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Http;
using TodoNet.Models;
using TodoNet.Models.Seeds;

namespace TodoNet
{
    public class Global : HttpApplication
    {
        protected void Application_Start()
        {
            // seed database
            Database.SetInitializer(new Seeder());
            
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
        }
    }
}