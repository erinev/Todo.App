using System.Web.Mvc;
using System.Web.Routing;

namespace Todo.App.Web.Areas.Api
{
    public class ApiAreaRegistration : AreaRegistration
    {
        public override string AreaName
        {
            get
            {
                return "Api";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context)
        {
            context.MapRoute(
                "ApiHttpGetAll",
                "Api/{controller}",
                new { action = "HttpGetAll" },
                new { httpMethod = new HttpMethodConstraint("GET") },
                new[] { "Todo.App.Web.Areas.Api.Controllers" });
            context.MapRoute(
                "ApiHttpPostAll",
                "Api/{controller}",
                new { action = "HttpGetAll" },
                new { httpMethod = new HttpMethodConstraint("POST") },
                new[] { "Todo.App.Web.Areas.Api.Controllers" });
            context.MapRoute(
                "ApiHttpDelete",
                "Api/{controller}/{id}",
                new { action = "HttpDelete" },
                new { httpMethod = new HttpMethodConstraint("DELETE") },
                new[] { "Todo.App.Web.Areas.Api.Controllers" });
            context.MapRoute(
                "ApiHttpGet",
                "Api/{controller}/{action}",
                new { httpMethod = new HttpMethodConstraint("GET") },
                new[] { "Todo.App.Web.Areas.Api.Controllers" });
            context.MapRoute(
                "ApiHttpPost",
                "Api/{controller}/{action}",
                new {httpMethod = new HttpMethodConstraint("POST")},
                new[] { "Todo.App.Web.Areas.Api.Controllers" });
        }
    }
}
