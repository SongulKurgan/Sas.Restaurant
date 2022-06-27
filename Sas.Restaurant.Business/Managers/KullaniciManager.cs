using Sas.Restaurant.Business.Managers.Base;
using Sas.Restaurant.Business.Services;
using Sas.Restaurant.DataAccess.UnitOfWork;
using Sas.Restaurant.Entites.Tables;
using Sas.Reustrant.Core.Tools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Business.Managers
{
   public class KullaniciManager:BaseManager<Kullanici>,IKullaniciService
    {
        private RestaurantUnitOfWork _uow;
        public KullaniciManager(IUnitOfWork uow):base(uow)
        {
            _uow = (RestaurantUnitOfWork)uow;
        }

        public Kullanici KullaniciKontrol(string kullaniciAdi, string parola)
        {
            string pass = Md5Hash.HashMd5(parola);
            return _uow.KullaniciDal.Get(c => c.KullaniciAdi == kullaniciAdi && c.Parola ==pass );
        }
    }
}
