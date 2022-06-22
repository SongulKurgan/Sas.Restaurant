using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.UserControls
{
   public class ControlGarsonButton:SimpleButton
    {
        private Guid garsonId;
        public Guid GarsonId
        {
            get
            {
                return garsonId;
            }
            set
            {
                Text = $"{Adi} {Soyadi}";
                garsonId = value;
            }
        }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public void Clear()
        {
            GarsonId = Guid.Empty;
            Adi = null;
            Soyadi = null;
        }
    }
}
