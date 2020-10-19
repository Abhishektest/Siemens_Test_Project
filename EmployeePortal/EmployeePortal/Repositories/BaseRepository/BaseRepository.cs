using System.Linq;
using EmployeePortal.DataContext;
using Microsoft.EntityFrameworkCore;

namespace EmployeePortal.Repositories.BaseRepository
{
    public class BaseRepository<T, TId> where T : Entity<TId>
    {
        private readonly DbContext _database = null;
        protected readonly DbSet<T> DbSet;

        public BaseRepository(ApplicationDbContext context)
        {

            _database = context;
            DbSet = _database.Set<T>();
        }
        public virtual T Add(T entity)
        {
            return DbSet.Add(entity).Entity;
        }
        public virtual T AddWithContextSave(T entity)
        {
            var addedEntity= DbSet.Add(entity).Entity;
            _database.SaveChanges();
            return addedEntity;

        }

        public virtual T Update(T entity)
        {
            T updated = DbSet.Attach(entity).Entity;
            _database.Entry(entity).State = EntityState.Modified;
            return updated;
        }

        public virtual T Upsert(T entity)
        {
            var dbEntityEntry = _database.Entry(entity);
            if (dbEntityEntry.State == EntityState.Detached)
                return Add(entity);
            
            return  Update(entity);
          
        }

        public virtual T Delete(T entity)
        {
            return DbSet.Remove(entity).Entity;
        }

        public virtual T FetchById(TId id)
        {
            return DbSet.Find(id);
        }

        public virtual IQueryable<T> GetAll()
        {
            return DbSet;
        }

    }
}
