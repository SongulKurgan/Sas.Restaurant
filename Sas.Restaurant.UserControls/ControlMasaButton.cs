using DevExpress.XtraEditors;
using Sas.Restaurant.Entites.Enums;
using Sas.Restaurant.Entites.Tables;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.UserControls
{
   public class ControlMasaButton:SimpleButton
    {
        MasaDurum _masaDurum;
        public ControlMasaButton()
        {
            MasaDurum = MasaDurum.Bos;
        }
        public MasaDurum MasaDurum
        {
            get
            {
                return _masaDurum;
            }
            set
            {
                _masaDurum = value;
                switch (_masaDurum)
                {
                    case MasaDurum.Bos:
                        Appearance.BackColor = Color.Olive;
                        break;
                    case MasaDurum.Dolu:
                        Appearance.BackColor = Color.OrangeRed;
                        break;
                    case MasaDurum.Rezervasyon:
                        Appearance.BackColor = Color.DodgerBlue;
                        break;
                }
            }
        }

        public Adisyon Adisyon { get; set; }

    }
}
