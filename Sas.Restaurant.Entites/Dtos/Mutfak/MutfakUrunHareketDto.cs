using Sas.Restaurant.Entites.Enums;
using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Entites.Dtos.Mutfak
{
   public class MutfakUrunHareketDto
    {
        public Guid Id { get; set; }
        public Guid AdisyonId { get; set; }
        public SiparisDurum SiparisDurum { get; set; }
        public decimal Miktar { get; set; }
        public string UrunAdi { get; set; }
        public string Porsiyon  { get; set; }
        public string Birim { get; set; }
        public string EkMalzeme { get; set; }
    }
}
