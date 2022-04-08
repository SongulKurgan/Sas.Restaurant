using Sas.Restaurant.Entites.Tables.Base;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.DataAccess.Functions
{
    public static class EntityBaseInfo
    {
        public static void Add(DbContext context)
        {
            foreach (var entry in context.ChangeTracker.Entries())
            {
                EntityBase changingEntity = (EntityBase)entry.Entity;
                switch (entry.State)
                {
                    case EntityState.Added:
                        if (changingEntity.Id==Guid.Empty)
                        {
                            changingEntity.Id = Guid.NewGuid();
                        }
                        
                        changingEntity.EklenmeTarihi = DateTime.Now;
                        changingEntity.Ekleyen = "Sas Ekibi";
                        break;

                    case EntityState.Modified:
                        changingEntity.DuzenlenmeTarihi = DateTime.Now;
                        changingEntity.Duzenleyen = "Sas ekibi";
                        break;
                }
            }
        }
    }
}
