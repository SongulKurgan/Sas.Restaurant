using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.UserControls
{
   public class ControlEkMalzemeButton:CheckButton
    {
        public Guid Id { get; set; }
        public decimal Fiyat { get; set; }
    }
}
