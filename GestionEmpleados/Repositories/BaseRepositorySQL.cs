using GestionEmpleados.Context;
using GestionEmpleados.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GestionEmpleados.Repositories
{
    public class BaseRepositorySQL<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {


        protected readonly EmpleadosDbContext context;
        protected readonly DbSet<TEntity> DbSet;

        public BaseRepositorySQL(EmpleadosDbContext _context)
        {
            context = _context;
            DbSet = context.Set<TEntity>();
        }


        public void Delete(Expression<Func<TEntity, bool>> where)
        {
            try
            {

                TEntity obj = DbSet.Where(where).FirstOrDefault();
                DbSet.Remove(obj);
                context.SaveChanges();

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> where)
        {
            return  DbSet.Where(where).FirstOrDefault();
        }

         IQueryable<TEntity> IBaseRepository<TEntity>.GetAll()
        {
            try
            {
                return DbSet;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public IQueryable<TEntity> GetMany(Expression<Func<TEntity, bool>> where)
        {
            return DbSet.Where(where);
        }

        public void Insert(TEntity entity)
        {
            try
            {
                DbSet.Add(entity);
                context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();

        }
    }
}
