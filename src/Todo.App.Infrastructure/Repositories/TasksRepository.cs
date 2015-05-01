using System.Collections.Generic;
using Todo.App.Infrastructure.Models;

namespace Todo.App.Infrastructure.Repositories
{
    public class TasksRepository : ITasksRepository
    {
        public List<Task> GetAll()
        {
            throw new System.NotImplementedException();
        }

        public Task GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task Create(Task task)
        {
            throw new System.NotImplementedException();
        }

        public Task Update(Task task)
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
        List<Task> GetAll();
        Task GetById(int id);
        Task Create(Task task);
        Task Update(Task task);
        void Delete(int id);
    }
}
