using Microsoft.EntityFrameworkCore;
using TodoListApp.Bussiness.Repository.IRespository;
using TodoListApp.DataAccess;
using TodoListApp.DataAccess.Data;

namespace TodoListApp.Bussiness.Repository
{
    public class StatusRepository : GenericRepository<TodoStatus>, IStatusRepository
    {
        public StatusRepository(ApplicationDbContext db) : base(db)
        {
        }

        public async Task<IEnumerable<TodoStatus>> GetAll()
        {
            return _db.TodoStatuses.Where(status => !status.IsDeleted);
        }
        public async Task<IEnumerable<TodoStatus>> GetAllWithTasks()
        {

            return _db.TodoStatuses
            .Where(status => !status.IsDeleted).Include(status => status.TodoTasks.Where(task => !task.IsDeleted));
        }

    }
}
