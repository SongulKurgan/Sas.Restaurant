﻿using Sas.Restaurant.Entites.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Core.Extensions
{
    public static  class IncludeMultiple
    {
        public static IQueryable<TEntity> MultipleInclude<TEntity>(this IQueryable<TEntity> query, params Expression<Func<TEntity,object>>[] includes) where TEntity : class, IEntity, new()
        {
            if (includes != null)
            {
                query=includes.Aggregate(query,(current,include)=>current.Include(include))
            }
        }
        
    }
}
