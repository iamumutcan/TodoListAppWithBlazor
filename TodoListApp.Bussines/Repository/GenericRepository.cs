using TodoListApp.Bussiness.Repository.IRespository;
using TodoListApp.DataAccess.Data;

namespace TodoListApp.Bussiness.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly ApplicationDbContext _db;
        public GenericRepository(ApplicationDbContext db)
        {
            _db = db;
        }
    }
}
