using DevExpress.XtraEditors;
using Sas.Restaurant.Business.Workers;
using Sas.Restaurant.Entites.Dtos;
using Sas.Restaurant.Entites.Enums;
using Sas.Restaurant.Entites.Tables;
using Sas.Restaurant.UserControls;
using Sas.Reustrant.Core.Extensions;
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
        private UrunHareket urunHareketEntity;
        public FrmMain()
        {
            InitializeComponent();
            KategoriButtonOlustur();
            gridControl1.DataSource = worker.UrunHareketService.BindingList();

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
                    Urunler = worker.UrunService.GetList(c => c.UrunGrupId == Kategori.Id,c=>c.Porsiyonlar,calcEdit1=>calcEdit1.EkMalzemeler),
                    GroupIndex = 1,
                    Height=60,
                    Font=new Font("Tahoma",12,FontStyle.Bold),
                    Width=flowKategori.Width-6
                };
                button.CheckedChanged += KategoriSecim;
                flowKategori.Controls.Add(button);
            }
        }
        private void KategoriSecim(object sender, EventArgs e)
        {
            flowKategoriUrunleri.Controls.Clear();
            ControlKategoriButon button = (ControlKategoriButon)sender;
            foreach (var item in button.Urunler)
            {
                ControlKategoriUrun urunButton = new ControlKategoriUrun
                {
                    Name = item.Id.ToString(),
                    UrunAdi=item.Adi,
                    Id=item.Id,
                    UrunImage=item.Fotograf.ByteArrayToImage(),
                    Height=220,
                    Width=300,
                    Aciklama=item.Aciklama,
                    Porsiyonlar=item.Porsiyonlar,
                    EkMalzemeler=item.EkMalzemeler
                };
                urunButton.ButtonClick += UrunClick;
                flowKategoriUrunleri.Controls.Add(urunButton);
            }
        }
        
        private void UrunClick(object sender, EventArgs e)
        {
            flowPorsiyon.Controls.Clear();
            ControlKategoriUrun button = (ControlKategoriUrun)sender;
            urunHareketEntity = new UrunHareket();
            //Silinecek
            Adisyon entity = new Adisyon();
            entity.Id = Guid.NewGuid();
            worker.AdisyonService.Add(entity);
            urunHareketEntity.AdisyonId = entity.Id;
            //Silinecek
            urunHareketEntity.Id = Guid.NewGuid();
            urunHareketEntity.UrunId = button.Id;
            urunHareketEntity.Miktar = txtMiktar.Value;
            navigationKategori.SelectedPage = pageUrunPorsiyon;
            foreach (var porsiyon in button.Porsiyonlar)
            {
                ControlPorsiyonButton porsiyonButton = new ControlPorsiyonButton
                {
                    Name = porsiyon.Id.ToString(),
                    Text=porsiyon.Adi+System.Environment.NewLine+porsiyon.Fiyat.ToString("C2"),
                    Fiyat=porsiyon.Fiyat,
                    EkMalzemeCarpan=porsiyon.EkMalzemeCarpan,
                    Id=porsiyon.Id,
                    Height=200,
                    Width=200,
                    Font=new Font("Tahoma",10,FontStyle.Bold),
                    EkMalzemeler=button.EkMalzemeler
                };
                porsiyonButton.Click += PorsiyonClick;
                flowPorsiyon.Controls.Add(porsiyonButton);
            }
        }

        private void PorsiyonClick(object sender, EventArgs e)
        {
            flowEkMalzeme.Controls.Clear();
            ControlPorsiyonButton button = (ControlPorsiyonButton)sender;
            urunHareketEntity.PorsiyonId = button.Id;
            urunHareketEntity.BirimFiyat = button.Fiyat;
            foreach (var malzeme in button.EkMalzemeler)
            {
                ControlEkMalzemeButton MalzemeButton = new ControlEkMalzemeButton
                {
                    Name = malzeme.Id.ToString(),
                    Text = malzeme.Adi + System.Environment.NewLine+malzeme.Fiyat.ToString("C2"),
                    Height=200,
                    Width=200,
                    Font = new Font("Tahoma", 10, FontStyle.Bold),
                    Id=malzeme.Id,
                    Fiyat=malzeme.Fiyat
                };
                flowEkMalzeme.Controls.Add(MalzemeButton);
            }
            navigationKategori.SelectedPage =pageEkMalzeme;
        }

        private void btnEkMalzemeOnay_Click(object sender, EventArgs e)
        {
            foreach (ControlEkMalzemeButton button in flowEkMalzeme.Controls)
            {
                if (button.Checked)
                {
                    urunHareketEntity.BirimFiyat += button.Fiyat; ;
                    worker.EkMalzemeHareketService.AddOrUpdate(new EkMalzemeHareket
                    {
                        UrunHareketId = urunHareketEntity.Id,
                        EkMalzemeId=button.Id,
                        Fiyat=button.Fiyat
                    });
                       
                }
            }
            worker.UrunHareketService.AddOrUpdate(urunHareketEntity);
            worker.UrunService.Load(c=>c.Id==urunHareketEntity.UrunId);
            worker.PorsiyonService.Load(c => c.Id==urunHareketEntity.PorsiyonId);
            worker.TanimService.Load(c => c.Id==urunHareketEntity.Porsiyon.BirimId);
            layoutView1.RefreshData();
            navigationKategori.SelectedPage = pageKategoriUrunler;

        }
    }
}
