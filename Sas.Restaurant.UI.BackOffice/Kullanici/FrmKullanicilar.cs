using DevExpress.XtraEditors;
using Sas.Restaurant.Business.Workers;
using Sas.Restaurant.Entites.Enums;
using Sas.Reustrant.Core.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sas.Restaurant.UI.BackOffice.Kullanici
{
    public partial class FrmKullanicilar : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        private Entites.Tables.Kullanici _entity;

        public FrmKullanicilar()
        {
            InitializeComponent();
            worker.KullaniciService.Load(null);
            gridControlKullanicilar.DataSource = worker.KullaniciService.BindingList();
            lookYetki.Properties.DataSource = Enum.GetValues(typeof(KullaniciRol));
        }
        void KullaniciBinding()
        {
            txtKullaniciAdi.DataBindings.Clear();
            lookYetki.DataBindings.Clear();
            txtAciklama.DataBindings.Clear();
            txtKullaniciAdi.DataBindings.Add("Text", _entity, "KullaniciAdi", false, DataSourceUpdateMode.OnPropertyChanged);
            lookYetki.DataBindings.Add("EditValue", _entity, "KullaniciRol", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _entity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void controlKullaniciMenu_EkleClick(object sender, EventArgs e)
        {
            _entity = new Entites.Tables.Kullanici();
            controlKullaniciMenu.KayitAc = true;
            groupKullaniciBilgi.Visible = true;
            KullaniciBinding();
        }

        private void controlKullaniciMenu_DuzenleClick(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRow()==null)
            {
                return;
            }
            _entity = (Entites.Tables.Kullanici)gridView1.GetFocusedRow();
            controlKullaniciMenu.KayitAc = true;
            groupKullaniciBilgi.Visible = true;
            txtKullaniciAdi.Enabled = false;
            KullaniciBinding();

        }

        private void controlKullaniciMenu_SilClick(object sender, EventArgs e)
        {
            if (gridView1.GetFocusedRow() == null)
            {
                return;
            }
            if (MessageBox.Show("Seçili olan veriyi silmek istediğinize emin misiniz?","Uyari",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                gridView1.DeleteSelectedRows();
            }
        }

        private void controlKullaniciMenu_KaydetClick(object sender, EventArgs e)
        {
            if (txtParola.Text!=txtParolaTekrar.Text)
            {
                if (!(String.IsNullOrEmpty(txtParola.Text)&&txtKullaniciAdi.Enabled==false))
                {
                    MessageBox.Show("Girdiğiniz parolalar birbirine eşit değil");
                    return;
                }
                
            }
            else
            {
                if (!(String.IsNullOrEmpty(txtParola.Text) && txtKullaniciAdi.Enabled == false))
                {
                    _entity.Parola =Md5Hash.HashMd5(txtParola.Text);
                }
                
            }
            worker.KullaniciService.AddOrUpdate(_entity);
            worker.Commit();
            controlKullaniciMenu.KayitAc = false;
            groupKullaniciBilgi.Visible = false;
            txtParola.Text = null;
            txtParolaTekrar.Text = null;
            txtKullaniciAdi.Enabled = false;
        }

        private void controlKullaniciMenu_VazgecClick(object sender, EventArgs e)
        {
            _entity = null;
            controlKullaniciMenu.KayitAc = false;
            groupKullaniciBilgi.Visible = false;
            txtKullaniciAdi.Enabled = false;
        }

        private void controlKullaniciMenu_KapatClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}