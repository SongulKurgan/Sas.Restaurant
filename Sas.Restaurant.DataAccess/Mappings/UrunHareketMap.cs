using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.DataAccess.Mappings
{
   public class UrunHareketMap: EntityTypeConfiguration<UrunHareket>
    {
        public UrunHareketMap()
        {
            Property(c => c.Miktar).HasPrecision(8,3);
            Property(c => c.BirimFiyat).HasPrecision(10, 2);
            Property(c => c.Indirim).HasPrecision(5, 2);
            Ignore(c => c.ToplamTutar);
            ToTable("UrunHareketler");
            Property(c => c.Miktar).HasColumnName("Miktar");
            Property(c => c.BirimFiyat).HasColumnName("BirimFiyat");
            Property(c => c.Indirim).HasColumnName("Indirim");
            Property(c => c.AdisyonId).HasColumnName("AdisyonId");
            Property(c => c.PorsiyonId).HasColumnName("PorsiyonId");
            Property(c => c.UrunId).HasColumnName("UrunId");
            Property(c => c.UrunHareketTip).HasColumnName("UrunHareketTip");
        }
    }
}
