using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GestionEmpleados.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        TEntity Get(Expression<Func<TEntity, bool>> where);
        IQueryable<TEntity> GetMany(Expression<Func<TEntity, bool>> where);
        void Insert(TEntity entity);
        void Delete(Expression<Func<TEntity, bool>> where);
        void Update(TEntity entity);
    }
}
