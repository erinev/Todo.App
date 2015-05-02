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
            return new { Id = id };
        }

        public static string CreateQuery()
        {
            return @"INSERT INTO Tasks
                    VALUES(@Title, @IsCompleted)
                    SELECT CAST(SCOPE_IDENTITY() as int)";
        }

        public static object CreateParams(TaskModel task)
        {
            return new { Title = task.title, IsCompleted = task.isCompleted };
        }

        public static string UpdateQuery()
        {
            return @"UPDATE Tasks
                    SET Title = @Title, IsCompleted = @IsCompleted
                    WHERE Id = @Id
                    SELECT @Id";
        }

        public static object UpdateParams(TaskModel task)
        {
            return new { Id = task.id, Title = task.title, IsCompleted = task.isCompleted };
        }

        public static string DeleteQuery()
        {
            return @"DELETE FROM Tasks
                    WHERE Id = @Id";
        }

        public static object DeleteParams(int id)
        {
            return new { Id = id };
        }
    }
}
