using Sas.Restaurant.Entites.Tables.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.Entites.Tables
{
    public class Adisyon : EntityBase
    {
        public bool AdisyonAcik { get; set; }
        public decimal Indirim { get; set; }
        public decimal Tutar { get; set; }
        public Guid? MasaId { get; set; }
        public Guid GarsonId { get; set; }
        public virtual Masa Masa { get; set; }
        public virtual Garson Garson { get; set; }
        public Guid? MusteriId { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual ICollection<UrunHareket> UrunHareketleri { get; set; }
    }
}
