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

namespace Sas.Restaurant.UI.BackOffice.OdemeTuru
{
    public partial class FrmOdemeTuruIslem : DevExpress.XtraEditors.XtraForm
    {
        private Entites.Tables.OdemeTuru _odemeTuruEntity;
        public bool Kaydedildi = false;
        RestaurantWorker worker = new RestaurantWorker();
        public FrmOdemeTuruIslem(Entites.Tables.OdemeTuru odemeTuruEntity)
        {
            InitializeComponent();
            _odemeTuruEntity = odemeTuruEntity;
            OdemeTuruBinding();
        }
        void OdemeTuruBinding()
        {
            txtAdi.DataBindings.Clear();
            txtOdemeTuru.DataBindings.Clear();
            txtAciklama.DataBindings.Clear();
            txtAdi.DataBindings.Add("Text", _odemeTuruEntity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", _odemeTuruEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
            txtOdemeTuru.DataBindings.Add("Text", _odemeTuruEntity.OdemeTur??new Entites.Tables.Tanim(), "Adi", false, DataSourceUpdateMode.Never);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            worker.OdemeTuruService.AddOrUpdate(_odemeTuruEntity);
            worker.Commit();
            Kaydedildi = true;
            Close();
        }

        private void txtOdemeTuru_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            FrmTanim form = new FrmTanim(TanimTip.OdemeTuru);
            form.ShowDialog();
            if (form.Secildi)
            {
                _odemeTuruEntity.OdemeTurId = form.tanimEntity.Id;
                txtOdemeTuru.Text = form.tanimEntity.Adi;
            }
        }
    }
}