using Sas.Restaurant.Entites.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Reustrant.Core.Extensions
{
   public static class CloneEntity
    {
        public static TEntity Clone<TEntity>(this TEntity entity) where TEntity : class, IEntity, new()
        {
            TEntity newEntity = new TEntity();
            foreach (var property in typeof(TEntity).GetProperties())
            {
                var editedProperty = property.GetValue(entity);
                if (editedProperty == null) continue;
                if (property.CanWrite)
                {
                    property.SetValue(newEntity, editedProperty);
                }
                
            }
            return newEntity;
        }
    }
}
