using DevExpress.XtraEditors;
using Sas.Restaurant.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sas.Restaurant.UserControls
{
    public class ControlMusteriButton : SimpleButton
    {
        public ControlMusteriButton()
        {
            MusteriTip = MusteriTip.Yok;
        }
        public Guid MusteriId { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public MusteriTip MusteriTip { get; set; }
        public void Load()
        {
            Text = $"{Adi} {Soyadi}";
            switch (MusteriTip)
            {
                case MusteriTip.Yok:
                    Appearance.BackColor = Color.Empty;
                    break;
                case MusteriTip.Platin:
                    Appearance.BackColor = Color.LightPink;
                    break;
                case MusteriTip.Gold:
                    Appearance.BackColor = Color.Gold;
                    break;
                case MusteriTip.Silver:
                    Appearance.BackColor = Color.Silver;
                    break;
            }
        }
        public void Clear()
        {
            Text = "Müşteri seçilmedi";
            MusteriId = Guid.Empty;
            Adi = null;
            Soyadi = null;
        }
    }
}



