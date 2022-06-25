using Sas.Restaurant.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Entites.Dtos
{
   public class YillikKazancDto
    {
        public Aylar Ay { get; set; }
        public decimal ToplamKazanc { get; set; }
    }
}
