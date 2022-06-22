using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.UserControls
{
   public class ControlGarsonCheckButton:CheckButton
    {
        public Guid GarsonId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
