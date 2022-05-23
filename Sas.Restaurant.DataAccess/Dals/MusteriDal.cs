﻿using Sas.Restaurant.DataAccess.Dals.Base;
using Sas.Restaurant.DataAccess.Interfaces;
using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.DataAccess.Dals
{
    public class MusteriDal : Repository<Musteri>, IMusteriDal
    {
        public MusteriDal(DbContext context) : base(context)
        {
        }
    }
}
