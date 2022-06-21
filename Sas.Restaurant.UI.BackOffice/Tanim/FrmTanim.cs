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

namespace Sas.Restaurant.UI.BackOffice.Tanim
{
    public partial class FrmTanim : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        public Entites.Tables.Tanim tanimEntity;
        public bool Secildi = false;
        private TanimTip _tanimTip;
        public FrmTanim(TanimTip tanimTip)
        {
            InitializeComponent();
            _tanimTip = tanimTip;
            worker.TanimService.Load(c=>c.TanimTip==tanimTip);
            gridControlTanim.DataSource = worker.TanimService.BindingList();
        }
        void TanimBinding()
        {
            txtTanim.DataBindings.Clear();
            txtAciklama.DataBindings.Clear();
            txtTanim.DataBindings.Add("Text", tanimEntity, "Adi", false, DataSourceUpdateMode.OnPropertyChanged);
            txtAciklama.DataBindings.Add("Text", tanimEntity, "Aciklama", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void controlMenu_SecClick(object sender, EventArgs e)
        {
            Secildi = true;
            tanimEntity =(Entites.Tables.Tanim) gridTanim.GetFocusedRow();
            Close();
        }

        private void controlMenu_EkleClick(object sender, EventArgs e)
        {
            controlMenu.KayitAc = true;
            groupTanimBilgi.Visible = true;
            tanimEntity = new Entites.Tables.Tanim();
            tanimEntity.Id = Guid.NewGuid();
            TanimBinding();
        }

        private void controlMenu_DuzenleClick(object sender, EventArgs e)
        {
            controlMenu.KayitAc = true;
            groupTanimBilgi.Visible = true;
            tanimEntity = (Entites.Tables.Tanim)gridTanim.GetFocusedRow();
            TanimBinding();
        }

        private void controlMenu_SilClick(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek ister misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridTanim.DeleteSelectedRows();
                worker.Commit();
            }
        }

        private void controlMenu_KaydetClick(object sender, EventArgs e)
        {
            controlMenu.KayitAc = false;
            groupTanimBilgi.Visible = false;
            tanimEntity.TanimTip = _tanimTip;
            worker.TanimService.AddOrUpdate(tanimEntity);
            worker.Commit();
        }

        private void controlMenu_VazgecClick(object sender, EventArgs e)
        {
            controlMenu.KayitAc = true;
            groupTanimBilgi.Visible = true;
        }

        private void controlMenu_KapatClick(object sender, EventArgs e)
        {
            Close();
        }
    }
}