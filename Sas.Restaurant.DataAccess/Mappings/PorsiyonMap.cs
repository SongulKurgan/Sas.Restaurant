using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.DataAccess.Mappings
{
   public  class PorsiyonMap:EntityTypeConfiguration<Porsiyon>
    {
        public PorsiyonMap()
        {
            Property(c => c.Adi).HasMaxLength(50);
            Property(c => c.Fiyat).HasPrecision(10,2);
            Property(c => c.EkMalzemeCarpan).HasPrecision(4, 2);

            ToTable("Porsiyonlar");
            Property(c => c.Adi).HasColumnName("Adi");
            Property(c => c.EkMalzemeCarpan).HasColumnName("EkMalzemeCarpani");
            Property(c => c.Fiyat).HasColumnName("Fiyat");
            Property(c => c.BirimId).HasColumnName("BrimId");
            Property(c => c.UrunId).HasColumnName("UrunId");

        }
    }
}
