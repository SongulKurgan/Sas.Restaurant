using Sas.Restaurant.Entites.Enums;
using Sas.Restaurant.Entites.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Entites.Tables
{
   public class UrunHareket:EntityBase
    {
        public UrunHareketTip UrunHareketTip { get; set; }
        public decimal Miktar { get; set; }
        public decimal BirimFiyat { get; set; }
        public decimal Indirim { get; set; }
        public decimal ToplamTutar
        {
            get
            {
                return (Miktar * BirimFiyat) - ((Miktar * BirimFiyat) / 100 * Indirim);
            }
        }
        public Guid UrunId { get; set; }
        public virtual Urun Urun { get; set; }
        public Guid PorsiyonId { get; set; }
        public virtual Porsiyon Porsiyon { get; set; }
        public Guid AdisyonId { get; set; }
        public virtual Adisyon Adisyon { get; set; }
        public virtual ICollection<EkMalzemeHareket> EkMalzemeHareketleri{ get; set; }
    }
}
