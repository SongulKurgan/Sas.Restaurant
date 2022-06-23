using Sas.Restaurant.Business.Managers.Base;
using Sas.Restaurant.Business.Services;
using Sas.Restaurant.DataAccess.UnitOfWork;
using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Business.Managers
{
   public class OdemeHareketManager:BaseManager<OdemeHareket>,IOdemeHareketService
    {
        public OdemeHareketManager(IUnitOfWork uow) : base(uow)
        {

        }
    }
}
