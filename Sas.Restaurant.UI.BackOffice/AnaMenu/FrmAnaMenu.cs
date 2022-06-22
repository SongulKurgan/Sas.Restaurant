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
    }
}
