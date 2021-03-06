
using Sas.Restaurant.Entites.Enums;
using Sas.Restaurant.Entites.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Entites.Tables
{
   public class Telefon: EntityBase
    {
        public TelefonAdresTip TelefonTip { get; set; }
        public string Telefonu { get; set; }
        public Guid MusteriId { get; set; }
        public virtual Musteri Musteri { get; set; }
    }
}
