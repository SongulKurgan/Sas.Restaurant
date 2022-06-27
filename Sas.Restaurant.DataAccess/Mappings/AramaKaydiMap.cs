using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.DataAccess.Mappings
{
   public class AramaKaydiMap:EntityTypeConfiguration<AramaKaydi>
    {
        public AramaKaydiMap()
        {
            Property(c => c.Telefon).HasMaxLength(20);
            ToTable("AramaKayitlari");
            Property(c => c.Telefon).HasColumnName("Telefon");
            Property(c => c.MusteriId).HasColumnName("MusteriId");
        }
    }
}
