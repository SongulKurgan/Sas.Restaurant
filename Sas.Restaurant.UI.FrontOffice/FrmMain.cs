using DevExpress.XtraEditors;
using Sas.Restaurant.Business.Workers;
using Sas.Restaurant.Entites.Dtos;
using Sas.Restaurant.Entites.Enums;
using Sas.Restaurant.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Sas.Restaurant.UI.FrontOffice
{
    public partial class FrmMain : DevExpress.XtraEditors.XtraForm
    {
        RestaurantWorker worker = new RestaurantWorker();
        public FrmMain()
        {
            InitializeComponent();
            KategoriButtonOlustur();
        }
        private void KategoriButtonOlustur()
        {
            foreach (var Kategori in worker.TanimService.Select(c=>c.TanimTip==TanimTip.UrunGrup,c=> new KategoriDto { Id=c.Id,Adi=c.Adi}).ToList())
            {
                ControlKategoriButon button = new ControlKategoriButon
                {
                    Name = Kategori.Id.ToString(),
                    Text = Kategori.Adi,
                    Id = Kategori.Id,
                    Urunler = worker.UrunService.GetList(c => c.UrunGrupId == Kategori.Id),
                    GroupIndex = 1,
                    Height=60,
                    Font=new Font("Tahoma",12,FontStyle.Bold),
                    Width=flowKategori.Width-6
                };
                button.CheckedChanged += KategoriSecim;
                flowKategori.Controls.Add(button);
            }
        }
        //60-2.49
        private void KategoriSecim(object sender, EventArgs e)
        {
            ControlKategoriButon button = (ControlKategoriButon)sender;
            foreach (var item in button.Urunler)
            {
                SimpleButton urunButton = new SimpleButton
                {
                    
                };
            }
        }
    }
}
