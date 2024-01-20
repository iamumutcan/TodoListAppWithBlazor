using System.ComponentModel.DataAnnotations;

namespace TodoListApp.DataAccess
{
    public class TodoStatus
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }
        public string btnclass { get; set; }
        public virtual IEnumerable<TodoTask> TodoTasks { get; set; }

    }
}
