using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.DataAccess.Mappings
{
   public class PersonelMap: EntityTypeConfiguration<Personel>
    {
        public PersonelMap()
        {
            Property(c => c.Adi).HasMaxLength(50);
            Property(c => c.Soyadi).HasMaxLength(50);
            ToTable("Garsonlar");
            Property(c => c.Adi).HasColumnName("Adi");
            Property(c => c.Soyadi).HasColumnName("Soyadi");
            Property(c => c.PersonelTipi).HasColumnName("PersonelTipi");
        }
    }
}
