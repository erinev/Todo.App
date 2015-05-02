using System.Web.Mvc;
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
        public JsonResult Create(TaskModel task)
        {
            var tasks = _tasksRepository.Create(task);

            return Json(tasks);
        }

        [Route("tasks/{id}")]
        [HttpPut]
        public JsonResult Update(TaskModel task)
        {
            var tasks = _tasksRepository.Update(task);

            return Json(tasks);
        }

        [Route("tasks/{id}")]
        [HttpDelete]
        public JsonResult Delete(TaskModel task)
        {
            _tasksRepository.Delete(task.id);

            return Json(string.Format("Task with id: {0} deleted successfully", task.id));
        }
    }
}