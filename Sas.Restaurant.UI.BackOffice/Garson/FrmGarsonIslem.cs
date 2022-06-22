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

namespace Sas.Restaurant.UI.BackOffice.Garson
{
    public partial class FrmGarsonIslem : DevExpress.XtraEditors.XtraForm
    {
       private Entites.Tables.Garson _garson;
        public bool Kaydedildi = false;
        RestaurantWorker worker = new RestaurantWorker();
        public FrmGarsonIslem(Entites.Tables.Garson garson)
        {
            InitializeComponent();
            _garson = garson;
            GarsonBinding();
        }
        void GarsonBinding()
        {
            txtAdi.DataBindings.Clear();
            txtSoyadi.DataBindings.Clear();
            txtAciklama.DataBindings.Clear();

            txtAdi.DataBindings.Add("Text", _garson, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSoyadi.DataBindings.Add("Text", _garson, "Soyadi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _garson, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
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