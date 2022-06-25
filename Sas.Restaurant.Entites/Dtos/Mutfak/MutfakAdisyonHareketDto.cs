using Sas.Restaurant.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Entites.Dtos.Mutfak
{
   public class MutfakAdisyonHareketDto
    {
        public Guid AdisyonId { get; set; }
        public AdisyonDurum AdisyonDurum { get; set; }
        public string MusteriAdi { get; set; }
        public string MasaAdi { get; set; }
        public string GarsonAdi { get; set; }
        public DateTime Tarih { get; set; }
    }
}
