using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using Dapper;
using Todo.App.Infrastructure.Models;

namespace Todo.App.Infrastructure.Repositories
{
    public class TasksRepository : ITasksRepository
    {
        private readonly SqlConnection _sqlConnection;

        public TasksRepository()
        {
            _sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["TodoApp"].ToString());
        }

        public IEnumerable<TaskModel> GetAll()
        {
            IEnumerable<TaskModel> result = _sqlConnection.Query<TaskModel>(
                sql: TaskAccessModel.GetAllQuery());

            return result;
        }

        public TaskModel GetById(int id)
        {
            TaskModel result = _sqlConnection.Query<TaskModel>(
                sql: TaskAccessModel.GetByIdQuery(), 
                param: TaskAccessModel.GetByIdParams(id)).Single();

            return result;
        }

        public TaskModel Create(TaskModel task)
        {
            var id = _sqlConnection.Query<int>(
                sql: TaskAccessModel.CreateQuery(), 
                param: TaskAccessModel.CreateParams(task)).Single();

            var result = this.GetById(id);

            return result;
        }

        public TaskModel Update(TaskModel task)
        {
            var id = _sqlConnection.Query<int>(
                sql: TaskAccessModel.UpdateQuery(),
                param: TaskAccessModel.UpdateParams(task)).Single();

            var result = this.GetById(id);

            return result;
        }

        public void Delete(int id)
        {
            _sqlConnection.Execute(
                sql: TaskAccessModel.DeleteQuery(),
                param: TaskAccessModel.DeleteParams(id));
        }
    }

    public interface ITasksRepository
    {
        IEnumerable<TaskModel> GetAll();
        TaskModel GetById(int id);
        TaskModel Create(TaskModel task);
        TaskModel Update(TaskModel task);
        void Delete(int id);
    }
}
