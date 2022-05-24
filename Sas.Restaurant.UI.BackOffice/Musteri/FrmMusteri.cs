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

namespace Sas.Restaurant.UI.BackOffice.Musteri
{
    public partial class FrmMusteri : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        public FrmMusteri()
        {
            InitializeComponent();
            
        }
        void Listele()
        {
            worker.MusteriService.Load(null);
            gridControlMusteri.DataSource = worker.MusteriService.BindingList();
        }

        private void controlMenu_ButtonEkle(object sender, EventArgs e)
        {
            FrmMusteriIslem form = new FrmMusteriIslem(new Entites.Tables.Musteri());
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                Listele();
            }
        }

        private void controlMenu_ButtonDuzenle(object sender, EventArgs e)
        {
            FrmMusteriIslem form = new FrmMusteriIslem((Entites.Tables.Musteri)gridMusteri.GetFocusedRow());
            form.ShowDialog();
        }
        private void controlMenu_ButtonSil(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seçili olan veriyi silmek ister misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                gridMusteri.DeleteSelectedRows();
                Listele();
            }
        }

        private void controlMenu_ButtonGuncelle(object sender, EventArgs e)
        {
            Listele();
        }

        private void controlMenu_ButtonKapat(object sender, EventArgs e)
        {
            Close();
        }
    }
}