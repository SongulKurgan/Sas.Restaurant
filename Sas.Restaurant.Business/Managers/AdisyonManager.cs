using Sas.Restaurant.Business.Managers.Base;
using Sas.Restaurant.Business.Services;
using Sas.Restaurant.DataAccess.UnitOfWork;
using Sas.Restaurant.Entites.Dtos;
using Sas.Restaurant.Entites.Enums;
using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Business.Managers
{
    public class AdisyonManager : BaseManager<Adisyon>, IAdisyonService
    {
        private RestaurantUnitOfWork _uow;
        public AdisyonManager(IUnitOfWork uow) : base(uow)
        {
            _uow = (RestaurantUnitOfWork)uow;
        }

        public AdisyonToplamDto AdisyonToplamGetir()
        {
            return _uow.AdisyonDal.BindingList().Select(c => new AdisyonToplamDto
            {
                ToplamTutar = c.UrunHareketleri == null ? 0 : c.UrunHareketleri.Where(f => f.UrunHareketTip == UrunHareketTip.Satis).Sum(f => f.ToplamTutar),
                IndirimTutar = c.UrunHareketleri == null ? 0 : c.UrunHareketleri.Where(f => f.UrunHareketTip == UrunHareketTip.Satis).Sum(f => f.ToplamTutar / 100 * f.Indirim),
                OdenenTutar = c.OdemeHareketleri == null ? 0 : c.OdemeHareketleri.Sum(f => f.Tutar),
            }).FirstOrDefault();
        }
    }
}
