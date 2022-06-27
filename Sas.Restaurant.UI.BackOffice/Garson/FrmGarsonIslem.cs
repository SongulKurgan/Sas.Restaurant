using DevExpress.XtraEditors;
using Sas.Restaurant.Business.Workers;
using Sas.Restaurant.Entites.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sas.Restaurant.UI.BackOffice.Garson
{
    public partial class FrmGarsonIslem : DevExpress.XtraEditors.XtraForm
    {
       private Entites.Tables.Personel _garson;
        public bool Kaydedildi = false;
        RestaurantWorker worker = new RestaurantWorker();
        public FrmGarsonIslem(Entites.Tables.Personel garson)
        {
            InitializeComponent();
            _garson = garson;
            lookTelefonTip.Properties.DataSource = Enum.GetValues(typeof(PersonelTipi));
            GarsonBinding();
        }
        void GarsonBinding()
        {
            txtAdi.DataBindings.Clear();
            txtSoyadi.DataBindings.Clear();
            txtAciklama.DataBindings.Clear();
            lookTelefonTip.DataBindings.Clear();
            txtAdi.DataBindings.Add("Text", _garson, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSoyadi.DataBindings.Add("Text", _garson, "Soyadi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _garson, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            lookTelefonTip.DataBindings.Add("EditValue", _garson, "PersonelTipi", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            worker.GarsonService.AddOrUpdate(_garson);
            worker.Commit();
            Kaydedildi = true;
            Close();
        }
    }
}