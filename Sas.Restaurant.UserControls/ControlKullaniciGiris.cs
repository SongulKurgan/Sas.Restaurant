using DevExpress.XtraEditors;
using Sas.Restaurant.Business.Workers;
using Sas.Restaurant.Entites.Tables;
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
    public partial class ControlKullaniciGiris : DevExpress.XtraEditors.XtraUserControl
    {
        private RestaurantWorker worker;
        private Kullanici kullaniciEntity;
        public event EventHandler<KullaniciControlEventArgs> KullaniciControlEvent;
        public Action KapatButton;
        public RestaurantWorker RestaurantWorker
        {
            get
            {
                if (worker==null)
                {
                    worker = new RestaurantWorker();
                }
                return worker;
            }
        }
        public ControlKullaniciGiris()
        {
            InitializeComponent();
        }

        private void btnKullaniciGiris_Click(object sender, EventArgs e)
        {
             kullaniciEntity=RestaurantWorker.KullaniciService.KullaniciKontrol(txtKullaniciAdi.Text, txtKullaniciParola.Text);
            KullaniciControlEvent?.Invoke(sender, new KullaniciControlEventArgs
            {
                Kullanici=kullaniciEntity
            });
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            KapatButton();
        }
    }
}
