using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Todo.App.Web.Controllers
{
    public class TaskController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.InitialData = new JavaScriptSerializer().Serialize("");

            return View();
        }
    }
}