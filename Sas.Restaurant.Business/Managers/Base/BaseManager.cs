using Sas.Restaurant.Business.Services.Base;
using Sas.Restaurant.DataAccess.UnitOfWork;
using Sas.Restaurant.Entites.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Business.Managers.Base
{
    public class BaseManager<TEntity> : IBaseService<TEntity> where TEntity : class, IEntity, new()
    {
        private IUnitOfWork _uow;
        public BaseManager(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public virtual void Add(TEntity entity)
        {
            _uow.Dal<TEntity>().Add(entity);
        }

        public virtual void Add(IEnumerable<TEntity> entities)
        {
            _uow.Dal<TEntity>().Add(entities);
        }

        public virtual void AddOrUpdate(TEntity entity)
        {
            _uow.Dal<TEntity>().AddOrUpdate(entity);
        }



        public virtual void AddOrUpdate(IEnumerable<TEntity> entities)
        {
            _uow.Dal<TEntity>().AddOrUpdate(entities);
        }

        public virtual void Update(TEntity entity)
        {
            _uow.Dal<TEntity>().Update(entity);
        }

        public virtual void Update(IEnumerable<TEntity> entities)
        {
            _uow.Dal<TEntity>().Update(entities);
        }


        public virtual void Delete(TEntity entity)
        {
            _uow.Dal<TEntity>().Delete(entity);
        }

        public virtual void Delete(IEnumerable<TEntity> entities)
        {
            _uow.Dal<TEntity>().Delete(entities);
        }

        public virtual void Delete(Expression<Func<TEntity, bool>> filter)
        {
            _uow.Dal<TEntity>().Delete(filter);
        }

        public void EntityStateChange(Expression<Func<TEntity, bool>> filter, EntityState state)
        {
            _uow.Dal<TEntity>().EntityStateChange(filter, state);
        }

        public void EntityStateChange(TEntity entity, EntityState state)
        {
            _uow.Dal<TEntity>().EntityStateChange(entity, state);
        }

        public void EntityStateChange(IEnumerable<TEntity> entities, EntityState state)
        {
            _uow.Dal<TEntity>().EntityStateChange(entities, state);
        }
        public virtual bool Exist(Expression<Func<TEntity, bool>> filter)
        {
            return _uow.Dal<TEntity>().Exist(filter);
        }

        public virtual TEntity Get(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            return _uow.Dal<TEntity>().Get(filter, includes);
        }

        public virtual IEnumerable<TEntity> GetList(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            return _uow.Dal<TEntity>().GetList(filter, includes);
        }

        public bool HasChanges()
        {
            return _uow.Dal<TEntity>().HasChanges();
        }

        public void Load(Expression<Func<TEntity, bool>> filter, params Expression<Func<TEntity, object>>[] includes)
        {
            _uow.Dal<TEntity>().Load(filter, includes);
        }

        public virtual IQueryable<TEntity> Select(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TEntity>> selector, params Expression<Func<TEntity, object>>[] includes)
        {
            return _uow.Dal<TEntity>().Select(filter, selector, includes);
        }

        public virtual IQueryable<TResult> Select<TResult>(Expression<Func<TEntity, bool>> filter, Expression<Func<TEntity, TResult>> selector, params Expression<Func<TEntity, object>>[] includes)
        {
            return _uow.Dal<TEntity>().Select(filter, selector, includes);
        }

        public virtual BindingList<TEntity> BindingList()
        {
            return _uow.Dal<TEntity>().BindingList();
        }

        private bool disposedValue;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: dispose managed state (managed objects)
                }

                // TODO: free unmanaged resources (unmanaged objects) and override finalizer
                // TODO: set large fields to null
                disposedValue = true;
            }
        }

        // // TODO: override finalizer only if 'Dispose(bool disposing)' has code to free unmanaged resources
        // ~BaseManager()
        // {
        //     // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
        //     Dispose(disposing: false);
        // }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        
    }
}
