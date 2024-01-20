using Microsoft.EntityFrameworkCore;
using TodoListApp.Bussiness.Repository.IRespository;
using TodoListApp.DataAccess;
using TodoListApp.DataAccess.Data;

namespace TodoListApp.Bussiness.Repository
{
    public class TaskRepository : GenericRepository<TodoTask>, ITaskRepository
    {
        public TaskRepository(ApplicationDbContext db) : base(db)
        {
        }


        public async Task<TodoTask> Create(TodoTask entity)
        {
            entity.CreatedDate = DateTime.Now;
            var resultObj = _db.TodoTasks.Add(entity);
            await _db.SaveChangesAsync();
            return resultObj.Entity;
        }

        public async Task<int> Delete(int id)
        {
            var entity = await _db.TodoTasks.FirstOrDefaultAsync(x => x.Id == id);
            if (entity != null)
            {
                entity.IsDeleted = true;
                _db.TodoTasks.Update(entity);
                await _db.SaveChangesAsync();
            }
            return 0;
        }

        public async Task<TodoTask> GetById(int id)
        {
            return await _db.TodoTasks.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<TodoTask> Update(TodoTask entity)
        {
            _db.Entry(entity).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return entity;
        }
    }
}
