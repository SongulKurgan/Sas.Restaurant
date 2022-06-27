using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.DataAccess.Mappings
{
   public class KullaniciMap:EntityTypeConfiguration<Kullanici>
    {
        public KullaniciMap()
        {
            Property(c => c.KullaniciAdi).HasMaxLength(30);
            Property(c => c.Parola).HasMaxLength(32);
            ToTable("Kullanicilar");
            Property(c => c.KullaniciAdi).HasColumnName("KullaniciAdi");
            Property(c => c.Parola).HasColumnName("Parola");
            Property(c => c.KullaniciRol).HasColumnName("KullaniciRol");

        }
    }
}
