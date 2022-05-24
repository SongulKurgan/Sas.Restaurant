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

namespace Sas.Restaurant.UI.BackOffice.Urun
{
    public partial class FrmUrun : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        public FrmUrun()
        {
            InitializeComponent();
            Listele();
        }

        void Listele()
        {
            worker.UrunService.Load(null, c => c.UrunGrup);
            gridControlUrunler.DataSource = worker.UrunService.BindingList();
        }
        private void controlAnaMenu_ButtonEkle(object sender, EventArgs e)
        {
            FrmUrunIslem form = new FrmUrunIslem(new Entites.Tables.Urun());
            form.ShowDialog();
            if (form.Eklendi)
            {
                Listele();
            }
        }

        private void controlAnaMenu_ButtonDuzenle(object sender, EventArgs e)
        {
            FrmUrunIslem form = new FrmUrunIslem((Entites.Tables.Urun)gridUrunler.GetFocusedRow());
            form.ShowDialog();
            if (form.Eklendi)
            {
                Listele();
            }
        }

        private void controlAnaMenu_ButtonSil(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek ister misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridUrunler.DeleteSelectedRows();
                Listele();
            }

        }

        private void controlAnaMenu_ButtonGuncelle(object sender, EventArgs e)
        {
            Listele();
        }

        private void controlAnaMenu_ButtonKapat(object sender, EventArgs e)
        {
            Close();
        }
    }
}