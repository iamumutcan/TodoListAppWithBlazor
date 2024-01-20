using TodoListApp.DataAccess;

namespace TodoListApp.Bussiness.Repository.IRespository
{
    public interface ITaskRepository
    {
        public Task<TodoTask> Create(TodoTask entity);
        public Task<TodoTask> Update(TodoTask entity);
        public Task<int> Delete(int id);
        public Task<TodoTask> GetById(int id);
    }
}
