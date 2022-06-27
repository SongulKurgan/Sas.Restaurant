using Sas.Restaurant.UI.BackOffice.Masa;
using Sas.Restaurant.UI.BackOffice.Musteri;
using Sas.Restaurant.UI.BackOffice.Urun;
using Sas.Restaurant.Core.Functions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Sas.Restaurant.UI.BackOffice.Garson;
using Sas.Restaurant.UI.BackOffice.OdemeTuru;
using Sas.Restaurant.UI.BackOffice.Adisyon;
using Sas.Restaurant.UI.BackOffice.urunHareket;

namespace Sas.Restaurant.UI.BackOffice.AnaMenu
{
    public partial class FrmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FrmAnaMenu()
        {
            InitializeComponent();
            if (!ConnectionStringInfo.Check())
            {
                FrmSetupConnection form = new FrmSetupConnection();
                form.ShowDialog();
            }
            FrmAnaMenuBilgi formBilgi = new FrmAnaMenuBilgi();
            formBilgi.MdiParent = this;
            formBilgi.Show();
        }
        
        private void btnUrun_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUrun form = new FrmUrun();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMusteri form = new FrmMusteri();
            form.MdiParent = this;
            form.Show();
        }

        private void btnMasa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmMasa form =new FrmMasa();
            form.MdiParent = this;
            form.Show();
        }

        private void btnGarson_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmGarson form = new FrmGarson();
            form.MdiParent = this;
            form.Show();
        }

        private void btnOdemeTur_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmOdemeTuru form = new FrmOdemeTuru();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAdisyonHareket form = new FrmAdisyonHareket();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem1_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmUrunHareket form = new FrmUrunHareket();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmOdemeHareketleri form = new FrmOdemeHareketleri();
            form.MdiParent = this;
            form.Show();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraForm1 form = new XtraForm1();
            form.Show();
        }
    }
}
