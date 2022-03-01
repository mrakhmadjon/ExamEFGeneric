using ExamEFGeneric.Data.Contexts;
using ExamEFGeneric.Data.IRepositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExamEFGeneric.Data.Repositories
{
#pragma warning disable
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    {

        private MusicDbContext musicDb;

        private DbSet<T> dbSet;
        public GenericRepository()
        {
            musicDb = new MusicDbContext();
            dbSet = musicDb.Set<T>();
        }

        public async Task<T> CreateAsync(T entity)
        {
            EntityEntry entity1 =  await dbSet.AddAsync(entity);

            musicDb.SaveChanges();

            return  (T) entity1.Entity;

        }

        public async Task<bool> DeleteAsync(Expression<Func<T, bool>> predicate)
        {
           var entity = await dbSet.FirstOrDefaultAsync(predicate);

            if (entity == null)
                return false;
            dbSet.Remove(entity);
            await musicDb.SaveChangesAsync();

            return true;
        }

        public async Task<IQueryable<T>> GetAllAsync(Expression<Func<T, bool>> predicate = null)
        {
            Expression<Func<T, bool>> pred = p => true;

            return dbSet.Where(predicate ?? pred);

        }

        public Task<T> GetAsync(Expression<Func<T, bool>> predicate)
        {
            return dbSet.FirstOrDefaultAsync(predicate);

        }

        public async Task<T> UpdateAsync(T entity)
        {
            dbSet.Update(entity);
            await musicDb.SaveChangesAsync();

            return entity;
        }
    }
}
