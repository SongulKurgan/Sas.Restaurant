using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.DataAccess.Mappings
{
   public class TelefonMap: EntityTypeConfiguration<Telefon>
    {
        public TelefonMap()
        {
            Property(c => c.Telefonu).HasMaxLength(20);

            ToTable("Telefolar");
            Property(c => c.Telefonu).HasColumnName("Telefonu");
            Property(c => c.MusteriId).HasColumnName("MusteriId");
            Property(c => c.TelefonTip).HasColumnName("TelefonTip");
        }
    }
}
