using Microsoft.EntityFrameworkCore;
using TodoListApp.DataAccess;

namespace TodoListApp.DataAccess.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<TodoStatus> TodoStatuses { get; set; }
        public DbSet<TodoTask> TodoTasks { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TodoStatus>().HasData(
                new TodoStatus { Id = 1, Name = "Yapacaklarım", IsDeleted = false, btnclass = "btn btn-warning" },
                new TodoStatus { Id = 2, Name = "Yapıyorum", IsDeleted = false, btnclass = "btn btn-primary" },
                new TodoStatus { Id = 3, Name = "Yaptım", IsDeleted = false, btnclass = "btn btn-success" }
            );

            modelBuilder.Entity<TodoTask>().HasData(
                 new TodoTask { Id = 1, Text = "İlk görev", CreatedDate = DateTime.Now, StatusId = 1, IsDeleted = false },
                 new TodoTask { Id = 2, Text = "İkinci görev", CreatedDate = DateTime.Now, StatusId = 2, IsDeleted = false },
                 new TodoTask { Id = 3, Text = "Üçüncü görev", CreatedDate = DateTime.Now, StatusId = 3, IsDeleted = false },
                 new TodoTask { Id = 4, Text = "Dördüncü görev", CreatedDate = DateTime.Now, StatusId = 1, IsDeleted = false },
                 new TodoTask { Id = 5, Text = "Beşinci görev", CreatedDate = DateTime.Now, StatusId = 2, IsDeleted = false },
                 new TodoTask { Id = 6, Text = "Altıncı görev", CreatedDate = DateTime.Now, StatusId = 3, IsDeleted = false },
                 new TodoTask { Id = 7, Text = "Yedinci görev", CreatedDate = DateTime.Now, StatusId = 1, IsDeleted = false },
                 new TodoTask { Id = 8, Text = "Sekizinci görev", CreatedDate = DateTime.Now, StatusId = 2, IsDeleted = false },
                 new TodoTask { Id = 9, Text = "Dokuzuncu görev", CreatedDate = DateTime.Now, StatusId = 3, IsDeleted = false },
                 new TodoTask { Id = 10, Text = "Onuncu görev", CreatedDate = DateTime.Now, StatusId = 1, IsDeleted = false }
             );

        }



    }
}
