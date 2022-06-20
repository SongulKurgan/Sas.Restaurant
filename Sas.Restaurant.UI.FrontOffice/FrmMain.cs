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
        enum KeypadIslem
        {
            Yok,
            FiyatDegistir,
            Iade,
            Ikram,
            Bol
        }

        RestaurantWorker worker = new RestaurantWorker();
        private UrunHareket urunHareketEntity;
        private KeypadIslem keypadIslem = KeypadIslem.Yok;
        public FrmMain()
        {
            InitializeComponent();
            KategoriButtonOlustur();
            gridControl1.DataSource = worker.UrunHareketService.BindingList();

        }
        void MiktarArttir(int sayi)
        {
            UrunHareket row = (UrunHareket)layoutView1.GetFocusedRow();
            if (sayi<0 && row.Miktar<=1)  // urun miktarı 1 den az olmasını önlüyor
            {
                return;
            }
            row.Miktar += sayi;    //Gelen sayıyı urun harekete atıyor
            layoutView1.RefreshData();
        }
        private void KategoriButtonOlustur()
        {
            foreach (var Kategori in worker.TanimService.Select(c => c.TanimTip == TanimTip.UrunGrup, c => new KategoriDto { Id = c.Id, Adi = c.Adi }).ToList())
            {
                ControlKategoriButon button = new ControlKategoriButon
                {
                    Name = Kategori.Id.ToString(),
                    Text = Kategori.Adi,
                    Id = Kategori.Id,
                    Urunler = worker.UrunService.GetList(c => c.UrunGrupId == Kategori.Id, c => c.Porsiyonlar, calcEdit1 => calcEdit1.EkMalzemeler),
                    GroupIndex = 1,
                    Height = 60,
                    Font = new Font("Tahoma", 12, FontStyle.Bold),
                    Width = flowKategori.Width - 6
                };
                button.CheckedChanged += KategoriSecim;
                flowKategori.Controls.Add(button);
            }
        }
        private void KategoriSecim(object sender, EventArgs e) // kategoriler listelendi,ürünü seçtim
        {
            flowKategoriUrunleri.Controls.Clear();
            ControlKategoriButon button = (ControlKategoriButon)sender;
            foreach (var item in button.Urunler)
            {
                ControlKategoriUrun urunButton = new ControlKategoriUrun
                {
                    Name = item.Id.ToString(),
                    UrunAdi = item.Adi,
                    Id = item.Id,
                    UrunImage = item.Fotograf.ByteArrayToImage(),
                    Height = 220,
                    Width = 300,
                    Aciklama = item.Aciklama,
                    Porsiyonlar = item.Porsiyonlar,
                    EkMalzemeler = item.EkMalzemeler
                };
                urunButton.ButtonClick += UrunClick;
                flowKategoriUrunleri.Controls.Add(urunButton);
            }
        }

        private void UrunClick(object sender, EventArgs e)
        {

            ControlKategoriUrun button = (ControlKategoriUrun)sender;
            //Porsiyon var mı yı kontrol ediyoruz
            if (!button.Porsiyonlar.Any())                       //Herhangi bir porsiyon yoksa bu mesajı ver ve bunu return et
            {
                MessageBox.Show("Bu ürüne atanmış bir porsiyon bulunamadı");
                return;
            }
            btnKategoriyeDon.Visible = true;
            flowPorsiyon.Controls.Clear();
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
                    Text = porsiyon.Adi + System.Environment.NewLine + porsiyon.Fiyat.ToString("C2"),
                    Fiyat = porsiyon.Fiyat,
                    EkMalzemeCarpan = porsiyon.EkMalzemeCarpan,
                    Id = porsiyon.Id,
                    Height = 200,
                    Width = 200,
                    Font = new Font("Tahoma", 10, FontStyle.Bold),
                    EkMalzemeler = button.EkMalzemeler
                };
                porsiyonButton.Click += PorsiyonClick;
                flowPorsiyon.Controls.Add(porsiyonButton);
            }
            if (button.Porsiyonlar.Count() == 1)          //Herhangi bir porsiyon varsa işlemleri yap
            {
                ControlPorsiyonButton buttonPorsiyon = (ControlPorsiyonButton)flowPorsiyon.Controls[0];    //buttonPorsiyon 1 tane ise count una bak ve ControlPorsiyonButton tipinde bir buton var , 0.indexsinden başayarak git o porsiyonu click le ki ek porsiyon tablosu gelsin
                buttonPorsiyon.PerformClick();


            }
        }

        private void PorsiyonClick(object sender, EventArgs e)
        {
            ControlPorsiyonButton button = (ControlPorsiyonButton)sender;

            urunHareketEntity.PorsiyonId = button.Id;
            urunHareketEntity.BirimFiyat = button.Fiyat;
            

            if (!button.EkMalzemeler.Any())
            {
                UrunHareketEkle();
                navigationKategori.SelectedPage = pageKategoriUrunler;
                return;
            }
            txtPorsiyonTutar.Value = button.Fiyat;
            flowEkMalzeme.Controls.Clear();
            foreach (var malzeme in button.EkMalzemeler)
            {
                ControlEkMalzemeButton MalzemeButton = new ControlEkMalzemeButton
                {
                    Name = malzeme.Id.ToString(),
                    Text = malzeme.Adi + System.Environment.NewLine + (malzeme.Fiyat * button.EkMalzemeCarpan).ToString("C2"),
                    Height = 200,
                    Width = 200,
                    Font = new Font("Tahoma", 10, FontStyle.Bold),
                    Id = malzeme.Id,
                    Fiyat = malzeme.Fiyat*button.EkMalzemeCarpan
                };
                MalzemeButton.CheckedChanged += MalzemeCheckedChanged;
                flowEkMalzeme.Controls.Add(MalzemeButton);
            }
            navigationKategori.SelectedPage = pageEkMalzeme;

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
                        EkMalzemeId = button.Id,
                        Fiyat = button.Fiyat
                    });

                }
            }
            UrunHareketEkle();
            navigationKategori.SelectedPage = pageKategoriUrunler;

        }
        void UrunHareketEkle()   //Urun ekleme kısmı
        {
            btnKategoriyeDon.Visible = false;
            worker.UrunHareketService.AddOrUpdate(urunHareketEntity);
            worker.UrunService.Load(c => c.Id == urunHareketEntity.UrunId);
            worker.PorsiyonService.Load(c => c.Id == urunHareketEntity.PorsiyonId);
            Guid id = urunHareketEntity.Porsiyon.BirimId;
            worker.TanimService.Load(c => c.Id == id);
            layoutView1.RefreshData();
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
           
        }

        private void layoutView1_CustomCardStyle(object sender, DevExpress.XtraGrid.Views.Layout.Events.LayoutViewCardStyleEventArgs e)
        {
            LayoutView view = (LayoutView)sender;
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

        private void btnKategoriyeDon_Click(object sender, EventArgs e)
        {
            navigationKategori.SelectedPage = pageKategoriUrunler;
            btnKategoriyeDon.Visible = false;
        }

        private void btnMiktarArttir_Click(object sender, EventArgs e)
        {
            MiktarArttir(1);   //urun miktarı arttırıyor
        }

        private void btnMiktarAzalt_Click(object sender, EventArgs e)
        {
            MiktarArttir(-1);    //urun miktarı azaltıyor
        }

        private void btnFiyatDegistir_Click(object sender, EventArgs e)
        {
            if (layoutView1.GetFocusedRow()==null)
            {
                return;
            }
            keypadIslem = KeypadIslem.FiyatDegistir;
            txtMiktar.Value = 0;
            txtMiktar.Properties.NullValuePrompt = "Lütfen yeni fiyat girin";
        }

        private void btnKeypadOk_Click(object sender, EventArgs e)
        {
            UrunHareket hareketEntity = (UrunHareket)layoutView1.GetFocusedRow();
            switch (keypadIslem)
            {
                case KeypadIslem.FiyatDegistir:
                    hareketEntity.BirimFiyat = txtMiktar.Value;
                    layoutView1.RefreshData();
                    break;
                case KeypadIslem.Iade:
                    if (hareketEntity.Miktar == txtMiktar.Value)
                    {
                        hareketEntity.UrunHareketTip = UrunHareketTip.Iptal;
                    }
                    else if(hareketEntity.Miktar < txtMiktar.Value)
                    {
                        MessageBox.Show($"{hareketEntity.Miktar}'den daha fazla iade yapılamaz");
                        return;
                    }
                    else
                    {
                        UrunHareket yeniEntity = hareketEntity.Clone();
                        yeniEntity.Id = Guid.NewGuid();
                        yeniEntity.UrunHareketTip = UrunHareketTip.Iptal;
                        yeniEntity.Miktar = txtMiktar.Value;
                        worker.UrunHareketService.AddOrUpdate(yeniEntity);
                        hareketEntity.Miktar -= txtMiktar.Value;
                        
                    }
                    layoutView1.RefreshData();
                    break;
                case KeypadIslem.Ikram:
                    if (hareketEntity.Miktar==txtMiktar.Value)
                    {
                        hareketEntity.UrunHareketTip = UrunHareketTip.Ikram;
                    }
                    else if (hareketEntity.Miktar<txtMiktar.Value)
                    {
                        MessageBox.Show($"{hareketEntity.Miktar}'den daha fazla ikram yapılamaz");
                    }
                    else
                    {
                        UrunHareket yeniEntity = hareketEntity.Clone();
                        yeniEntity.Id = Guid.NewGuid();
                        yeniEntity.UrunHareketTip = UrunHareketTip.Ikram;
                        yeniEntity.Miktar = txtMiktar.Value;
                        worker.UrunHareketService.AddOrUpdate(yeniEntity);
                        hareketEntity.Miktar -= txtMiktar.Value;
                    }
                    layoutView1.RefreshData();
                    break;
                case KeypadIslem.Bol:
                    if (hareketEntity.Miktar==txtMiktar.Value)
                    {
                        MessageBox.Show("Miktar alanıyla yeni girilen alan eşit olamaz");
                    }
                    else
                    {
                        UrunHareket yeniEntity = hareketEntity.Clone();
                        yeniEntity.Id = Guid.NewGuid();
                        yeniEntity.Miktar = txtMiktar.Value;
                        worker.UrunHareketService.AddOrUpdate(yeniEntity);
                        hareketEntity.Miktar -= txtMiktar.Value;
                    }
                    layoutView1.RefreshData();
                    break;
            }
            keypadIslem = KeypadIslem.Yok;
        }

        private void btnIade_Click(object sender, EventArgs e)
        {
            if (layoutView1.GetFocusedRow() == null) return;
            UrunHareket hareketEntity = (UrunHareket)layoutView1.GetFocusedRow();
            if (hareketEntity.UrunHareketTip==UrunHareketTip.Iptal)
            {
                MessageBox.Show("Seçtiğiniz ürün zaten iptal edilmiş ");
            }
            else if (hareketEntity.Miktar == 1)
            {
                hareketEntity.UrunHareketTip = UrunHareketTip.Iptal;
                layoutView1.RefreshData();
            }
            else
            {
                keypadIslem = KeypadIslem.Iade;
                txtMiktar.Properties.NullValuePrompt = "Lütfen iade edilecek miktarı girin";
            }
        }

        private void btnIkram_Click(object sender, EventArgs e)
        {
            if (layoutView1.GetFocusedRow() == null) return;
            UrunHareket hareketEntity = (UrunHareket)layoutView1.GetFocusedRow();
            if (hareketEntity.Miktar == 1)
            {
                hareketEntity.UrunHareketTip = UrunHareketTip.Ikram;
                layoutView1.RefreshData();
            }
            else
            {
                keypadIslem = KeypadIslem.Ikram;
                txtMiktar.Properties.NullValuePrompt = "Lütfen ikram edilecek miktarı girin";
            }
        }

        private void btnBol_Click(object sender, EventArgs e)
        {
            if (layoutView1.GetFocusedRow() == null) return;
            UrunHareket hareketEntity = (UrunHareket)layoutView1.GetFocusedRow();
            if (hareketEntity.Miktar==1)
            {
                MessageBox.Show("Miktarınız bölmeye uygun değil");
            }
            else
            {
                keypadIslem = KeypadIslem.Bol;
                txtMiktar.Properties.NullValuePrompt = "Lütfen bölünecek miktarı girin";
            }
        }
    }
}

