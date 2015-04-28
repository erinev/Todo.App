using System.Web.Mvc;

namespace Todo.App.Web.Controllers
{
    public class TaskController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
    }
}