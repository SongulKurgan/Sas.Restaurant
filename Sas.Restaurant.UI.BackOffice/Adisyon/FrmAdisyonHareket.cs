using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using Sas.Restaurant.Business.Workers;
using Sas.Restaurant.Entites.Dtos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sas.Restaurant.UI.BackOffice.Adisyon
{
    public partial class FrmAdisyonHareket : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        public FrmAdisyonHareket()
        {
            InitializeComponent();
            dateGunSecim.DateTime = DateTime.Now;
            dateGunSecim2.DateTime = DateTime.Now;
            Listele(DateTime.Now, DateTime.Now);
        }
        void Listele(DateTime tarih1, DateTime tarih2)
        {
            gridControlAdisyonHareket.DataSource = worker.AdisyonService.AdisyonHareketGetir(tarih1,tarih2);
        }
        private void dateGunSecim_SelectionChanged(object sender, EventArgs e)
        {
            if (dateGunSecim.DateTime>dateGunSecim2.DateTime)
            {
                dateGunSecim2.DateTime = dateGunSecim.DateTime;
            }
            Listele(dateGunSecim.DateTime,dateGunSecim2.DateTime);
        }

        private void dateGunSecim2_SelectionChanged(object sender, EventArgs e)
        {
            if (dateGunSecim.DateTime > dateGunSecim2.DateTime)
            {
                dateGunSecim.DateTime = dateGunSecim2.DateTime;
            }
            Listele(dateGunSecim.DateTime, dateGunSecim2.DateTime);
        }

        private void gridAdisyonHareket_MasterRowGetRelationCount(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs e)
        {
            e.RelationCount = 2;
        }

        private void gridAdisyonHareket_MasterRowGetRelationName(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs e)
        {
            switch (e.RelationIndex)
            {
                case 0:
                    e.RelationName = "Ürün Hareketleri";
                    break;
                case 1:
                    e.RelationName = "Ödeme Hareketleri";
                    break;
            }
            
        }

        private void gridAdisyonHareket_MasterRowGetChildList(object sender, DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs e)
        {
            GridView view = (GridView)sender;
            AdisyonHareketDto entity = (AdisyonHareketDto)view.GetRow(e.RowHandle);
            switch (e.RelationIndex)
            {
                case 0:
                    e.ChildList = worker.UrunHareketService.GetList(c => c.AdisyonId == entity.AdisyonId, c => c.Urun, c => c.Porsiyon, c => c.Porsiyon.Birim).ToList();
                    break;
                case 1:
                    e.ChildList = worker.odemeHareketService.GetList(c => c.AdisyonId == entity.AdisyonId, c => c.OdemeTuru, c => c.OdemeTuru.OdemeTur).ToList();
                    break;
            }
            
        }
    }
}