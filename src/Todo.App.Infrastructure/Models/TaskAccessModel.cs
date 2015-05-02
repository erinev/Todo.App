namespace Todo.App.Infrastructure.Models
{
    public static class TaskAccessModel
    {
        public static string GetAllQuery()
        {
            return @"SELECT * FROM Tasks";
        }

        public static string GetByIdQuery()
        {
            return @"SELECT * FROM Tasks
                             WHERE Id = @Id";
        }

        public static object GetByIdParams(int id)
        {
            return new {Id = id};
        }
    }
}
