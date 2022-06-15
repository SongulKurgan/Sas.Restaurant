using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Entites.Enums
{
   public enum UrunHareketTip
    {
        [Description("Satış")]
        Satis,
        [Description("İptal")]
        Iptal,
        [Description("İkram")]
        Ikram
    }
}
