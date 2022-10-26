using Accounting.DataLayer.Bank;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace Accounting.DataLayer.Services
{
    public class MainRepository<TEntity> where TEntity : class
    {

        private Accounting_DBEntities _db;
        private DbSet<TEntity> _dbSet;

        public MainRepository(Accounting_DBEntities db)
        {
            _db = db;
            _dbSet = _db.Set<TEntity>();
        }

        public virtual IEnumerable<TEntity> Get(Expression<Func<TEntity,bool>> where=null)
        {
            IQueryable<TEntity> query = _dbSet;

            if (where!=null)
            {
                query = query.Where(where);
            }
            return query.ToList();

        }

        public virtual TEntity GetEntityById(object ID)
        {
            return _dbSet.Find(ID);
        }

        public virtual void Insert(TEntity entity)
        {

            _dbSet.Add(entity);

        }

        public virtual void Update(TEntity entity)
        {
            _dbSet.Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;

        }

        public virtual void Delete(TEntity entity)
        {
            _dbSet.Remove(entity);
        }




    }
}
