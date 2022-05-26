using Sas.Restaurant.Entites.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Entites.Tables
{
   public class Masa:EntityBase
    {
        public string Adi { get; set; }
        public bool Dolu { get; set; }
        public Guid KonumId { get; set; }
        public virtual Tanim Konum { get; set; }
        public Guid? AdisyonId { get; set; }
        public virtual Adisyon Adisyon { get; set; }
    }
}
