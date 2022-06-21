using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.DataAccess.Mappings
{
   public class AdisyonMap:EntityTypeConfiguration<Adisyon>
    {
        public AdisyonMap()
        {
            Property(c => c.Indirim).HasPrecision(5, 2);
            Property(c => c.Tutar).HasPrecision(10, 2);
            ToTable("Adisyonlar");
            Property(c => c.Tutar).HasColumnName("Tutar");
            Property(c => c.Indirim).HasColumnName("Indirim");
            Property(c => c.GarsonId).HasColumnName("GarsonId");
            Property(c => c.MasaId).HasColumnName("MasaId");
            Property(c => c.AdisyonAcik).HasColumnName("AdisyonAcik");

        }
    }
}
