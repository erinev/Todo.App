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
            IEnumerable<TaskModel> result = _sqlConnection.Query<TaskModel>(sql: TaskAccessModel.GetAllQuery());
            return result;
        }

        public TaskModel GetById(int id)
        {
            TaskModel result = _sqlConnection.Query<TaskModel>(
                sql: TaskAccessModel.GetByIdQuery(), param: TaskAccessModel.GetByIdParams(id)).Single();
            return result;
        }

        public TaskModel Create(TaskModel taskAccessModel)
        {
            throw new System.NotImplementedException();
        }

        public TaskModel Update(TaskModel taskAccessModel)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
    }

    public interface ITasksRepository
    {
        IEnumerable<TaskModel> GetAll();
        TaskModel GetById(int id);
        TaskModel Create(TaskModel taskAccessModel);
        TaskModel Update(TaskModel taskAccessModel);
        void Delete(int id);
    }
}
