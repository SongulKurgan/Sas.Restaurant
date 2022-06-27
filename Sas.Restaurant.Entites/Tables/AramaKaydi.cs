using Sas.Restaurant.Entites.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Entites.Tables
{
   public class AramaKaydi: EntityBase
    {
        public string Telefon { get; set; }
        public Guid? MusteriId { get; set; }
        public virtual Musteri Musteri { get; set; }

    }
}
