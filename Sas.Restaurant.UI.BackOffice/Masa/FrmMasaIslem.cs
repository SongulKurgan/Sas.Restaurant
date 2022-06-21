using DevExpress.XtraEditors;
using Sas.Restaurant.Business.Workers;
using Sas.Restaurant.Entites.Enums;
using Sas.Restaurant.UI.BackOffice.Tanim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sas.Restaurant.UI.BackOffice.Masa
{
    public partial class FrmMasaIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entites.Tables.Masa _masa;
        public bool Kaydedildi = false;
        RestaurantWorker worker = new RestaurantWorker();
        public FrmMasaIslem(Entites.Tables.Masa masa)
        {
            InitializeComponent();
            _masa = masa;
            MasaBinding();
        }
        void MasaBinding()
        {
            txtMasaAdi.DataBindings.Clear();
            txtKapasite.DataBindings.Clear();
            txtAciklama.DataBindings.Clear();
            txtKonumu.DataBindings.Clear();

            txtMasaAdi.DataBindings.Add("Text", _masa, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtKapasite.DataBindings.Add("Value", _masa, "Kapasite", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _masa, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            txtKonumu.DataBindings.Add("Text", _masa.Konum ?? new Entites.Tables.Tanim(), "Adi", false, DataSourceUpdateMode.Never);
        }

        private void txtKonumu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmTanim form = new FrmTanim(TanimTip.Konum);
            form.ShowDialog();
            if (form.Secildi)
            {
                txtKonumu.Text = form.tanimEntity.Adi;
                _masa.KonumId = form.tanimEntity.Id;
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            worker.MasaService.AddOrUpdate(_masa);
            worker.Commit();
            Kaydedildi = true;
            Close();
        }
    }
}