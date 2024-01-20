using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TodoListApp.DataAccess
{
    public class TodoTask
    {
        [Key]
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreatedDate { get; set; }
        public int StatusId { get; set; }
        [ForeignKey("StatusId")]
        public TodoStatus Status { get; set; }
        public bool IsDeleted { get; set; }
    }

}
