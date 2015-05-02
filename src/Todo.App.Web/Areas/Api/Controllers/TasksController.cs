using System.Web.Mvc;
using Newtonsoft.Json;
using Todo.App.Infrastructure.Models;
using Todo.App.Infrastructure.Repositories;

namespace Todo.App.Web.Areas.Api.Controllers
{
    [RoutePrefix("api/v1")]
    public class TasksController : Controller
    {
        private readonly ITasksRepository _tasksRepository;

        public TasksController()
        {
            _tasksRepository = new TasksRepository();
        }

        [Route("tasks")]
        [HttpGet]
        public JsonResult GetAll()
        {
            var tasks = _tasksRepository.GetAll();

            return Json(tasks, JsonRequestBehavior.AllowGet);
        }

        [Route("tasks/{Id}")]
        [HttpGet]
        public JsonResult Get(int id)
        {
            var task = _tasksRepository.GetById(id);

            return Json(task, JsonRequestBehavior.AllowGet);
        }

        [Route("tasks")]
        [HttpPost]
        public JsonResult Create(TaskModel taskAccessModel)
        {
            return Json(JsonConvert.SerializeObject(taskAccessModel));
        }

        [Route("tasks")]
        [HttpPut]
        public JsonResult Update(TaskModel taskAccessModel)
        {
            return Json(JsonConvert.SerializeObject(taskAccessModel));
        }

        [Route("tasks/{id}")]
        [HttpDelete]
        public JsonResult Delete(int id)
        {
            return Json(JsonConvert.SerializeObject(id));
        }
    }
}