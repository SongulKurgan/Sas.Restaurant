using Sas.Restaurant.DataAccess.Interfaces.Base;
using Sas.Restaurant.Entites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.DataAccess.UnitOfWork
{
    public interface IUnitOfWork:IDisposable
    {
        IRepository<TEntity> Dal<TEntity>() where TEntity : class, IEntity, new();
        bool HasChanges();
        void DetectChanges();
        bool Commit();

    }
}
