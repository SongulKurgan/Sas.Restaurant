using Sas.Restaurant.Entites.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Entites.Tables
{
   public class EkMalzemeHareket:EntityBase
    {
        public decimal Fiyat { get; set; }
        public Guid EkMalzemeId { get; set; }
        public virtual EkMalzeme EkMalzeme { get; set; }
        public Guid UrunHareketId { get; set; }
        public virtual UrunHareket UrunHareket { get; set; }
    }
}
