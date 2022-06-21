using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.DataAccess.Mappings
{
    public class MasaMap : EntityTypeConfiguration<Masa>
    {
        public MasaMap()
        {
            Property(c => c.Adi).HasMaxLength(30);

            ToTable("Masalar");
            Property(c => c.Adi).HasColumnName("Adi");
            Property(c => c.Kapasite).HasColumnName("Kapasite");
            Property(c => c.Dolu).HasColumnName("Dolu");
            Property(c => c.KonumId).HasColumnName("KonumId");
        }
    }
}
