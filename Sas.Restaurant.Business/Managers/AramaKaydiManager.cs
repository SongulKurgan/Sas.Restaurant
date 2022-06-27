using Sas.Restaurant.Business.Managers.Base;
using Sas.Restaurant.Business.Services;
using Sas.Restaurant.DataAccess.UnitOfWork;
using Sas.Restaurant.Entites.Dtos;
using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Business.Managers
{
    public class AramaKaydiManager:BaseManager<AramaKaydi>, IAramaKaydiService
    {
        private RestaurantUnitOfWork _uow;

        public AramaKaydiManager(IUnitOfWork uow):base(uow)
        {
            _uow = (RestaurantUnitOfWork)uow;
        }

        public List<DtoAramaKaydi> AramaKaydiList(DateTime tarih)
        {
            return _uow.AramaKaydiDal.Select(c => DbFunctions.TruncateTime(c.EklenmeTarihi) == tarih.Date, c => new DtoAramaKaydi
            {
                Telefon = c.Telefon,
                MusteriId = c.MusteriId,
                MusteriAdi = c.Musteri.Adi + " " + c.Musteri.Soyadi,
                Tarih = c.EklenmeTarihi
            }, c => c.Musteri).OrderBy(c=>c.Tarih).ToList();
        }
    }
}
