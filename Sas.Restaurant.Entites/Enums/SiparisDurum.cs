using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Entites.Enums
{
    public enum SiparisDurum
    {
        [Description("Hazırlanıyor")]
        Hazirlaniyor,
        [Description("Servise Hazir")]
        ServiseHazir,
        [Description("Servis Edildi")]
        ServisEdildi
    }
}
