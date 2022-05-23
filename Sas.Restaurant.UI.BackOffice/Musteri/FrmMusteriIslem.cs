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

namespace Sas.Restaurant.UI.BackOffice.Musteri
{
    public partial class FrmMusteriIslem : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        private Entites.Tables.Musteri _musteriEntity;
        private Telefon _telefonEntity;
        private Adres _adresEntity;
        public FrmMusteriIslem(Entites.Tables.Musteri musteriEntity)
        {
            InitializeComponent();
            _musteriEntity = musteriEntity;
            if (_musteriEntity.Id == Guid.Empty)
            {
                _musteriEntity.Id = Guid.NewGuid();
            }
        }
        void MusteriBinding()
        {
            txtMusteriAdi.DataBindings.Clear();
            txtMusteriSoyadi.DataBindings.Clear();
            txtSirketAdi.DataBindings.Clear();
            txtKartNo.DataBindings.Clear();
            txtMusteriAciklama.DataBindings.Clear();

            txtMusteriAdi.DataBindings.Add("Text", _musteriEntity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtMusteriSoyadi.DataBindings.Add("Text", _musteriEntity, "Soyadi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSirketAdi.DataBindings.Add("Text", _musteriEntity, "Sirket", false, DataSourceUpdateMode.OnPropertyChanged);
            txtKartNo.DataBindings.Add("Text", _musteriEntity, "KartNo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtMusteriAciklama.DataBindings.Add("Text", _musteriEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);

        }

        void TelefonBinding()
        {
            txtTelefonNumarasi.DataBindings.Clear();
            txtTelefonAciklama.DataBindings.Clear();

            txtTelefonNumarasi.DataBindings.Add("Text", _telefonEntity, "Telefonu", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTelefonAciklama.DataBindings.Add("Text", _telefonEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        void AdresBinding()
        {
            txtIl.DataBindings.Clear();
            txtIlce.DataBindings.Clear();
            txtSemt.DataBindings.Clear();
            txtAdres.DataBindings.Clear();

            txtIl.DataBindings.Add("Text", _adresEntity, "Il", false, DataSourceUpdateMode.OnPropertyChanged);
            txtIlce.DataBindings.Add("Text", _adresEntity, "Ilce", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSemt.DataBindings.Add("Text", _adresEntity, "Semt", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAdres.DataBindings.Add("Text", _adresEntity, "Adres", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void controlMenuTelefon_EkleClick(object sender, EventArgs e)
        {
            _telefonEntity = new Telefon();
            _telefonEntity.MusteriId = _musteriEntity.Id;
            controlMenuTelefon.KayitAc = true;
            groupTelefonBilgi.Visible = true;
            TelefonBinding();
        }

        private void controlMenuTelefon_DuzenleClick(object sender, EventArgs e)
        {
            _telefonEntity = (Telefon)gridTelefon.GetFocusedRow();
            controlMenuTelefon.KayitAc = true;
            groupTelefonBilgi.Visible = true;
            TelefonBinding();
        }

        private void controlMenuTelefon_SilClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan kaydı silmek istediğinize emin misiniz?","Uyarı",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                gridTelefon.DeleteSelectedRows();
            }
        }

        private void controlMenuTelefon_KaydetClick(object sender, EventArgs e)
        {
            worker.TelefonService.AddOrUpdate(_telefonEntity);
            controlMenuTelefon.KayitAc = false;
            groupTelefonBilgi.Visible = false;
        }

        private void controlMenuTelefon_VazgecClick(object sender, EventArgs e)
        {
            controlMenuTelefon.KayitAc = false;
            groupTelefonBilgi.Visible = false;
        }

        private void controlMenuAdres_EkleClick(object sender, EventArgs e)
        {

        }

        private void controlMenuAdres_DuzenleClick(object sender, EventArgs e)
        {

        }

        private void controlMenuAdres_KaydetClick(object sender, EventArgs e)
        {

        }

        private void controlMenuAdres_VazgecClick(object sender, EventArgs e)
        {

        }
    }
}