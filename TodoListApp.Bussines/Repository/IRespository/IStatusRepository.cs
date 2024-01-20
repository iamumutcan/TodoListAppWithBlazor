using TodoListApp.DataAccess;

namespace TodoListApp.Bussiness.Repository.IRespository
{
    public interface IStatusRepository
    {

        public Task<IEnumerable<TodoStatus>> GetAll();
        public Task<IEnumerable<TodoStatus>> GetAllWithTasks();

    }
}
