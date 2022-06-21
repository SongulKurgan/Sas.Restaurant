using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Entites.Enums
{
   public enum TelefonAdresTip
    {
        [Description("Ev")]
        Ev,
        [Description("İş")]
        Is,
        [Description("Diğer")]
        Diger
    }
}
