using System.Web.Mvc;
using System.Web.Script.Serialization;

namespace Todo.App.Web.Areas.Api.Controllers
{
    public class TaskController : Controller
    {
        [HttpGet]
        public JsonResult GetAll()
        {
            return Json("", JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetById(int id)
        {
            return Json("", JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult SaveTask()
        {
            return Json(new JavaScriptSerializer().Serialize(""));
        }
    }
}