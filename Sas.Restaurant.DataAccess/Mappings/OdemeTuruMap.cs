using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.DataAccess.Mappings
{
    public class OdemeTuruMap:EntityTypeConfiguration<OdemeTuru>
    {
        public OdemeTuruMap()
        {
            Property(c => c.Adi).HasMaxLength(50);

            ToTable("OdemeTurleri");
            Property(c => c.Adi).HasColumnName("Adi");
            Property(c => c.OdemeTurId).HasColumnName("OdemeTurId");
        }
    }
}
