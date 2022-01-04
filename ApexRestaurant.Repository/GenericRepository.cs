using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ApexRestaurant.Repository
{
    public abstract class GenericRepository<T> : IGenericRepository<T>
    where T : class, new()
    {
        protected RestaurantContext DbContext { get; set; }

        public T Get(int id)
        {
            return DbContext.Find<T>(id);
        }

        public IQueryable<T> Query()
        {
            return DbContext.Set<T>().AsQueryable();
        }

        public void Insert(T entity)
        {
            DbContext.Set<T>().Add(entity);
            DbContext.SaveChanges();
        }

        public void Update(T entity)
        {
            DbContext.Entry(entity).State = EntityState.Modified;
            DbContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            DbContext.Set<T>().Remove(entity);
            DbContext.SaveChanges();
        }
    }
}