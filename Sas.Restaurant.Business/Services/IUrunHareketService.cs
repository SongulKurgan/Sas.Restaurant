using Sas.Restaurant.Business.Services.Base;
using Sas.Restaurant.Entites.Dtos;
using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Business.Services
{
    public interface IUrunHareketService:IBaseService<UrunHareket>
    {
        IEnumerable<UrunHareket> UrunHareketListesiGetir(DateTime baslangicTarihi, DateTime bitisTarihi);
        List<EnCokSatanUrunlerDto> EnCokSatanUrunleriGetir();
    }
}
