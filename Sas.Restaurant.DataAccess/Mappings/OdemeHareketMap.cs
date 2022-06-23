using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.DataAccess.Mappings
{
    public class OdemeHareketMap: EntityTypeConfiguration<OdemeHareket>
    {
        public OdemeHareketMap()
        {
            Property(c => c.Tutar).HasPrecision(10, 2);
            ToTable("OdemeHareketleri");
            Property(c => c.Tutar).HasColumnName("Tutar");
            Property(c => c.AdisyonId).HasColumnName("AdisyonId");
            Property(c => c.OdemeTuruId).HasColumnName("OdemeTuruId");
        }
    }
}
