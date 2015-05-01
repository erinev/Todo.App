using System.Collections.Generic;
using System.Web.Mvc;
using Newtonsoft.Json;
using Todo.App.Infrastructure.Models;

namespace Todo.App.Web.Areas.Api.Controllers
{
    [RoutePrefix("api/v1")]
    public class TasksController : Controller
    {
        [Route("tasks")]
        [HttpGet]
        public JsonResult GetAll()
        {
            var tasks = new List<Task>()
            {
                new Task()
                {
                    Id = 1,
                    Title = "Go to work",
                    IsCompleted = false
                },
                new Task()
                {
                    Id = 2,
                    Title = "Go to work",
                    IsCompleted = false
                }
            };
            return Json(tasks, JsonRequestBehavior.AllowGet);
        }

        [Route("tasks/{id}")]
        [HttpGet]
        public JsonResult Get(int id)
        {
            var task = new Task()
            {
                Id = 1,
                Title = "Go to work",
                IsCompleted = false
            };

            return Json(task, JsonRequestBehavior.AllowGet);
        }

        [Route("tasks")]
        [HttpPost]
        public JsonResult Create(Task task)
        {
            return Json(JsonConvert.SerializeObject(task));
        }

        [Route("tasks")]
        [HttpPut]
        public JsonResult Update(Task task)
        {
            return Json(JsonConvert.SerializeObject(task));
        }

        [Route("tasks/{id}")]
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            return Json(JsonConvert.SerializeObject(id));
        }
    }
}