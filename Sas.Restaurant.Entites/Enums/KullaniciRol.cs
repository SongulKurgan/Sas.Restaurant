using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Entites.Enums
{
    public enum KullaniciRol
    {
        [Description("Admin Kullanıcısı")]
        Admin,
        [Description("Personel Kullanıcısı")]
        Personel,
        [Description("Mutfak Kullanıcısı")]
        Mutfak
    }
}
