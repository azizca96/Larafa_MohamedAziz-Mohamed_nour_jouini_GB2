using serverAspNetCoreApi.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace serverAspNetCoreApi.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : BaseEntity
    {
        protected readonly DbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var toDelete = GetById(id);
            Delete(toDelete);           
        }

        public void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();           
        }

        public TEntity GetById(int id)
        {
            return _dbSet.SingleOrDefault<TEntity>(e => e.Id == id);
        }

        public void Update(TEntity entity)
        {
            if (_context.Entry(entity).State == EntityState.Detached)
            {
               _dbSet.Attach(entity);
            }
            _context.Entry(entity).State = EntityState.Modified;

            _context.SaveChanges();
        }
    }
}