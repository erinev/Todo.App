using System.Diagnostics.CodeAnalysis;

namespace Todo.App.Infrastructure.Models
{
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class TaskModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public bool isCompleted { get; set; }
    }
}