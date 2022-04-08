using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.DataAccess.Mappings
{
   public  class UrunMap:EntityTypeConfiguration<Urun>
    {
        public UrunMap()
        {
            Property(c => c.Adi).HasMaxLength(50);
            Property(c => c.Barkod).HasMaxLength(20);

            ToTable("Urunler");
            Property(c => c.Adi).HasColumnName("Adi");
            Property(c => c.Barkod).HasColumnName("Barkod");
            Property(c => c.Fotograf).HasColumnName("Fotograf");
            Property(c => c.UrunGrupId).HasColumnName("UrunGrupId");
        }
    }
}
