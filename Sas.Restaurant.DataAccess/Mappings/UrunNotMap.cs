using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.DataAccess.Mappings
{
   public class UrunNotMap:EntityTypeConfiguration<UrunNot>
    {
        public UrunNotMap()
        {
            Property(c => c.Notu).HasMaxLength(100);
            ToTable("UrunNotlari");
            Property(c => c.Notu).HasColumnName("Notu");
            Property(c => c.UrunId).HasColumnName("UrunId");
        }
    }
}
