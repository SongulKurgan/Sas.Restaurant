using DevExpress.XtraEditors;
using DevExpress.XtraLayout.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sas.Restaurant.UserControls
{
    public partial class ControlMenuKayit : DevExpress.XtraEditors.XtraUserControl
    {
        private bool kayitAc = false;
        [Category("İşlem butonları")]
        public event EventHandler SecClick;
        [Category("İşlem butonları")]
        public event EventHandler EkleClick;
        [Category("İşlem butonları")]
        public event EventHandler DuzenleClick;
        [Category("İşlem butonları")]
        public event EventHandler SilClick;
        [Category("İşlem butonları")]
        public event EventHandler KaydetClick;
        [Category("İşlem butonları")]
        public event EventHandler VazgecClick;
        [Category("İşlem butonları")]
        public event EventHandler KapatClick;

        public LayoutVisibility SecVisibility
        {
            get { return layoutItemSec.Visibility; }
            set
            {
                layoutItemSec.Visibility = value;
                Root.BestFit();
            }
        }

        public LayoutVisibility KapatVisibility
        {
            get { return layoutItemKapat.Visibility; }
            set
            {
                layoutItemKapat.Visibility = value;
                Root.BestFit();
            }
        }
        public bool KayitAc
        {
            get { return kayitAc; }
            set
            {
                btnEkle.Enabled = !value;
                btnDuzenle.Enabled = !value;
                btnSil.Enabled = !value;
                btnSec.Enabled = !value;
                btnKapat.Enabled = !value;
                btnKaydet.Enabled = value;
                btnVazgec.Enabled = value;
                kayitAc = value;
            }
        }

        public ControlMenuKayit()
        {
            InitializeComponent();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            SecClick?.Invoke(this, e);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            EkleClick?.Invoke(this, e);
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            DuzenleClick?.Invoke(this, e);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SilClick?.Invoke(this, e);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            KaydetClick?.Invoke(this, e);
        }

        private void btnVazgec_Click(object sender, EventArgs e)
        {
            VazgecClick?.Invoke(this, e);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            KapatClick?.Invoke(this, e);
        }
    }
}
