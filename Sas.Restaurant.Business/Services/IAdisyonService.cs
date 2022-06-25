using Sas.Restaurant.Business.Services.Base;
using Sas.Restaurant.Entites.Dtos;
using Sas.Restaurant.Entites.Dtos.Mutfak;
using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Business.Services
{
  public  interface IAdisyonService: IBaseService<Adisyon>
    {
        AdisyonToplamDto AdisyonToplamGetir();
        List<AdisyonHareketDto> AdisyonHareketGetir(DateTime Tarih1, DateTime Tarih2);
        List<MutfakAdisyonHareketDto> MutfakAdisyonHareketGetir(Guid[] adisyonListe);
        List<MutfakUrunHareketDto> MutfakUrunHareketGetir(Guid adisyonId);
        List<MutfakEkMalzemeDto> MutfakEkMalzemeHareketGetir(Guid urunHareketId);
    }
}
