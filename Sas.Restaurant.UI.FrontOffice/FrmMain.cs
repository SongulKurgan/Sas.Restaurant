using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Layout;
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
            urunHareketEntity.UrunHareketTip = UrunHareketTip.Satis;
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
            txtPorsiyonTutar.Value = button.Fiyat;
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
                MalzemeButton.CheckedChanged += MalzemeCheckedChanged;
                flowEkMalzeme.Controls.Add(MalzemeButton);
            }
            navigationKategori.SelectedPage =pageEkMalzeme;
        }

        private void MalzemeCheckedChanged(object sender, EventArgs e)
        {
            EkMalzemeHesapla();
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

        void EkMalzemeHesapla()
        {
            txtEkMalzemeTutar.Value = 0;
            foreach (ControlEkMalzemeButton button in flowEkMalzeme.Controls)
            {
                if (button.Checked)
                {
                    txtEkMalzemeTutar.Value += button.Fiyat;
                }
            }
            txtToplamTutar.Value = txtPorsiyonTutar.Value + txtEkMalzemeTutar.Value;
        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            UrunHareket entity = (UrunHareket)layoutView1.GetFocusedRow();
            entity.UrunHareketTip = UrunHareketTip.Iptal;
            layoutView1.RefreshData();
        }

        private void layoutView1_CustomCardStyle(object sender, DevExpress.XtraGrid.Views.Layout.Events.LayoutViewCardStyleEventArgs e)
        {
            LayoutView view = (LayoutView) sender;
            UrunHareket row = (UrunHareket)view.GetRow(e.RowHandle);
            if (view.FocusedRowHandle == e.RowHandle)
            {
                e.Appearance.BackColor = Color.DarkSeaGreen;
                return;
            }


            switch (row.UrunHareketTip)
            {
                case UrunHareketTip.Satis:
                    e.Appearance.BackColor = Color.PaleTurquoise;
                    break;
                case UrunHareketTip.Ikram:
                    e.Appearance.BackColor = Color.MediumSpringGreen;
                    break;
                case UrunHareketTip.Iptal:
                    e.Appearance.BackColor = Color.Tomato;
                    break;
            }

        }

        private void KeyPadSend(object sender, EventArgs e)
        {
            SimpleButton button = (SimpleButton)sender;
            txtMiktar.Focus();
            SendKeys.Send(button.Text);
        }
    }
    }

