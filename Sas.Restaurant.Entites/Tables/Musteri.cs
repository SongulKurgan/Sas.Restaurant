using Sas.Restaurant.Entites.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Entites.Tables
{
   public class Musteri:EntityBase
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Sirket { get; set; }
        public string KartNo { get; set; }
        public Guid Telefon { get; set; }
        public ICollection<Telefon> Telefonlar { get; set; }
        public ICollection<Adres> Adresler { get; set; }
    }
}
