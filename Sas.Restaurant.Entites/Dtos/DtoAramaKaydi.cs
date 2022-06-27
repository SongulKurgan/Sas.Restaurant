using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Entites.Dtos
{
   public class DtoAramaKaydi
    {
        public Guid? MusteriId { get; set; }
        public string MusteriAdi { get; set; }
        public string Telefon { get; set; }
        public DateTime Tarih { get; set; }
    }
}
