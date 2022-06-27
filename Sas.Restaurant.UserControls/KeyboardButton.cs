using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.UserControls
{
   public class KeyboardButton:SimpleButton
    {
        public char First { get; set; }
        public char Second { get; set; }
        public char Third { get; set; }
    }
}
