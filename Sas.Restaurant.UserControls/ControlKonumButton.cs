using DevExpress.XtraEditors;
using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.UserControls
{
   public class ControlKonumButton: CheckButton
    {
        public IEnumerable<Masa> Masalar { get; set; }
    }
}
