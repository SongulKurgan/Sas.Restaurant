using DevExpress.XtraEditors;
using Sas.Restaurant.Business.Workers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sas.Restaurant.UI.BackOffice.urunHareket
{
    public partial class FrmUrunHareket : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        public FrmUrunHareket()
        {
            InitializeComponent();
            dateGunSecim.DateTime = DateTime.Now;
            dateGunSecim2.DateTime = DateTime.Now;
            Listele(dateGunSecim.DateTime, dateGunSecim2.DateTime);
        }
        void Listele(DateTime baslangic,DateTime bitis)
        {
           gridControlUrunHareket.DataSource= worker.UrunHareketService.UrunHareketListesiGetir(baslangic, bitis);
        }

        private void dateGunSecim_SelectionChanged(object sender, EventArgs e)
        {
            if (dateGunSecim.DateTime > dateGunSecim2.DateTime)
            {
                dateGunSecim2.DateTime = dateGunSecim.DateTime;
            }
            Listele(dateGunSecim.DateTime, dateGunSecim2.DateTime);

        }

        private void dateGunSecim2_SelectionChanged(object sender, EventArgs e)
        {
            if (dateGunSecim.DateTime > dateGunSecim2.DateTime)
            {
                dateGunSecim.DateTime = dateGunSecim2.DateTime;
            }
            Listele(dateGunSecim.DateTime, dateGunSecim2.DateTime);
        }
    }
}