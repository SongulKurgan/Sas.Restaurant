using Sas.Restaurant.Entites.Enums;
using Sas.Restaurant.Entites.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Entites.Tables
{
   public class Kullanici:EntityBase
    {
        public string KullaniciAdi { get; set; }
        public string Parola { get; set; }
        public KullaniciRol KullaniciRol { get; set; }
    }
}
