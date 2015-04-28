using System.Web.Mvc;
using Newtonsoft.Json;

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
            return Json(id, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public JsonResult SaveTask()
        {
            return Json(JsonConvert.SerializeObject(""));
        }
    }
}