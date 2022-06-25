using Sas.Restaurant.Business.Managers.Base;
using Sas.Restaurant.Business.Services;
using Sas.Restaurant.DataAccess.UnitOfWork;
using Sas.Restaurant.Entites.Dtos;
using Sas.Restaurant.Entites.Enums;
using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Business.Managers
{
    public class OdemeHareketManager : BaseManager<OdemeHareket>, IOdemeHareketService
    {
        private RestaurantUnitOfWork _uow;
        public OdemeHareketManager(IUnitOfWork uow) : base(uow)
        {
            _uow = (RestaurantUnitOfWork)uow;
        }

        public IEnumerable<OdemeHareket> OdemeHareketListesiGetir(DateTime baslangicTarihi, DateTime bitisTarihi)
        {
            return _uow.OdemeHareketDal.GetList(c => DbFunctions.TruncateTime(c.EklenmeTarihi) >= baslangicTarihi.Date && DbFunctions.TruncateTime(c.EklenmeTarihi) <= bitisTarihi.Date, c => c.OdemeTuru, c => c.OdemeTuru.OdemeTur);
        }
        public List<HaftalikKazancDto> HaftalikKazanciGetir()
        {
            int bugun = Convert.ToInt32(DateTime.Now.DayOfWeek);
            DateTime haftaninIkGunu = DateTime.Now.AddDays(-bugun);
            List<HaftalikKazancDto> liste = new List<HaftalikKazancDto>();

            for (int i = 0; i < 7; i++)
            {
                HaftaninGunleri gunAdi = (HaftaninGunleri)haftaninIkGunu.DayOfWeek + i;
                DateTime gun = haftaninIkGunu.AddDays(i + 1);
                liste.Add(new HaftalikKazancDto
                {
                    Gun = gunAdi,
                    Tarih = gun,
                    ToplamKazanc = _uow.OdemeHareketDal.GetList(c => DbFunctions.TruncateTime(c.EklenmeTarihi) == gun.Date).Sum(c => c.Tutar)
                });
            }
            return liste;
        }

        public List<AylikKazancDto> AylikKazancıGetir()
        {
            DateTime ayinSonGunu = DateTime.Now.AddMonths(1).AddDays(-DateTime.Now.Day);
            List<AylikKazancDto> liste = new List<AylikKazancDto>();
            for (int i = 1; i <= ayinSonGunu.Day; i++)
            {
                DateTime gun = new DateTime(DateTime.Now.Year, DateTime.Now.Month, i);
                liste.Add(new AylikKazancDto
                {
                    Tarih = gun,
                    ToplamKazanc = _uow.OdemeHareketDal.GetList(c => DbFunctions.TruncateTime(c.EklenmeTarihi) == gun.Date).Sum(c => c.Tutar)
                });
            }
            return liste;
        }

        public List<YillikKazancDto> YillikKazancıGetir()
        {
            List<YillikKazancDto> liste = new List<YillikKazancDto>();
            for (int i = 0; i < 12; i++)
            {
                liste.Add(new YillikKazancDto
                {
                    Ay=(Aylar) i,
                    ToplamKazanc=_uow.OdemeHareketDal.GetList(c=>c.EklenmeTarihi.Month==i+1).Sum(c=>c.Tutar)
                });
            }
            return liste;
        }
    }
}
