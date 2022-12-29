
using Microsoft.EntityFrameworkCore;
using RepositoryCourses.Data_Access;
using RepositoryCourses.Domain.Repositories;
using System.Linq.Expressions;

namespace RepositoryCourses.Domain.Implementation
{
    public class Repository<T>:IRepository<T> where T : class
    {
        private readonly CourseContext _courseContext;
        private readonly DbSet<T> _dbset;
        public Repository(CourseContext context)
        {
            _courseContext = context;
            _dbset = _courseContext.Set<T>();
        }
        public async Task Add(T entity)
        {
           await _dbset.AddAsync(entity);
        }

        public async Task AddRange(IEnumerable<T> entities)
        {
            await _dbset.AddRangeAsync(entities);   
        }

        public async Task<IEnumerable<T>> Find(Expression<Func<T, bool>> predicate)
        {
            return await _dbset.Where(predicate).ToListAsync();
        }

        public async Task<T?> Get(int id)
        {
           return await _dbset.FindAsync(id);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
           return await _dbset.ToListAsync();
        }

        public void Remove(T entity)
        {
            _dbset.Remove(entity);
        }

        public void RemoveRange(IEnumerable<T> entities)
        {
            _dbset.RemoveRange(entities);
        }

        public void Update(T entity)
        {
            _dbset.Entry(entity).State=EntityState.Modified;
        }

        
    }
}
