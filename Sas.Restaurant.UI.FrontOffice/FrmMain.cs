using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Layout;
using Sas.Restaurant.Business.Workers;
using Sas.Restaurant.Entites.Dtos;
using Sas.Restaurant.Entites.Enums;
using Sas.Restaurant.Entites.Tables;
using Sas.Restaurant.UserControls;
using Sas.Restaurant.Core.Extensions;
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
            Bol,
            Indirim
        }

        RestaurantWorker worker = new RestaurantWorker();
        private UrunHareket urunHareketEntity;
        private Adisyon secilenAdisyon;
        private Masa secilenMasa;
        private KeypadIslem keypadIslem = KeypadIslem.Yok;
        public FrmMain()
        {
            InitializeComponent();
            KategoriButtonOlustur();
            gridControl1.DataSource = worker.UrunHareketService.BindingList();
            MasaButonOlustur();
            GarsonButtonOlustur();

        }
        void GarsonButtonOlustur()
        {
            foreach (var garson in worker.GarsonService.GetList(null))
            {
                ControlGarsonCheckButton button = new ControlGarsonCheckButton
                {
                    Name = garson.Id.ToString(),
                    Text=$"{garson.Adi}{garson.Soyadi}",
                    Height=150,
                    Width=150,
                    Font = new Font("Tahoma", 12, FontStyle.Bold),
                    GroupIndex=1,
                    GarsonId=garson.Id,
                    Adi=garson.Adi,
                    Soyadi=garson.Soyadi
                };
                button.CheckedChanged += GarsonSecim;
                flowGarson.Controls.Add(button);
            }
        }

        private void GarsonSecim(object sender, EventArgs e)
        {
            ControlGarsonCheckButton button = (ControlGarsonCheckButton)sender;
            btnGarsonSecim.Adi = button.Adi;
            btnGarsonSecim.Soyadi = button.Soyadi;
            btnGarsonSecim.GarsonId = button.GarsonId;
            navigationKategori.SelectedPage = pageKategoriUrunler;
        }

        void MasaButonOlustur()
        {
            foreach (var konum in worker.TanimService.GetList(c=>c.TanimTip==TanimTip.Konum))
            {
                ControlKonumButton button = new ControlKonumButton
                {
                    Name = konum.Id.ToString(),
                    Text = konum.Adi,
                    Height = 88,
                    Width=150,
                    GroupIndex=1,
                    Font = new Font("Tahoma", 12, FontStyle.Bold),
                    Masalar =worker.MasaService.GetList(c=>c.KonumId==konum.Id)

                };
                button.CheckedChanged += KonumSecim;
                flowKonum.Controls.Add(button);
            }
        }

        private void KonumSecim(object sender, EventArgs e)
        {
            ControlKonumButton button = (ControlKonumButton)sender;
            flowMasalar.Controls.Clear();
            foreach (var masa in button.Masalar)
            {
                ControlMasaButton masaButton = new ControlMasaButton
                {
                    Name = masa.Id.ToString(),
                    Text = masa.Adi + System.Environment.NewLine + masa.Kapasite.ToString() + " Kişi",
                    Height = 150,
                    Width = 150,
                    Font = new Font("Tahoma", 12, FontStyle.Bold),
                    MasaId = masa.Id
                };
                masaButton.Click += MasaSec;
                flowMasalar.Controls.Add(masaButton);
            }
            foreach (var adisyon in worker.AdisyonService.GetList(c=>c.AdisyonAcik))
            {
                ControlMasaButton buttonMasa= flowMasalar.Controls.Cast<ControlMasaButton>().SingleOrDefault(c => c.MasaId == adisyon.MasaId);
                if (buttonMasa!=null)
                {
                    buttonMasa.MasaDurum = MasaDurum.Dolu;
                    buttonMasa.AdisyonId = adisyon.Id;
                }
            }
        }

        private void MasaSec(object sender, EventArgs e)
        {
            ControlMasaButton button = (ControlMasaButton)sender;
            btnGarsonSecim.Visible = true;
            if (button.MasaDurum==MasaDurum.Bos)
            {
                secilenAdisyon = new Adisyon();
                secilenAdisyon.Id = Guid.NewGuid();
                secilenMasa = worker.MasaService.Get(c=>c.Id==button.MasaId);
                secilenAdisyon.MasaId = button.MasaId;
                btnGarsonSecim.Text = "Garson Seçilmedi";
                button.AdisyonId = secilenAdisyon.Id;
                navigationMain.SelectedPage = pageAdisyonAyrinti;
            }
            else if (button.MasaDurum==MasaDurum.Dolu)
            {
                worker.UrunHareketService.Load(c => c.AdisyonId == button.AdisyonId,c=>c.Urun,c=>c.Porsiyon, c => c.Porsiyon.Birim, c => c.EkMalzemeHareketleri);
                worker.AdisyonService.Load(c => c.Id == button.AdisyonId);
                worker.EkMalzemeHareketService.Load(null);
                secilenAdisyon = worker.AdisyonService.Get(c => c.Id == button.AdisyonId);
                secilenMasa = worker.MasaService.Get(c => c.Id == button.MasaId);
                Garson garson = worker.GarsonService.Get(c => c.Id == secilenAdisyon.GarsonId);
                if (garson != null)
                {
                    btnGarsonSecim.Adi = garson.Adi;
                    btnGarsonSecim.Soyadi = garson.Soyadi;
                    btnGarsonSecim.GarsonId = garson.Id;
                }
                else
                {
                    btnGarsonSecim.Text = "Garson Seçilmedi";
                }
                button.AdisyonId = secilenAdisyon.Id;
                navigationMain.SelectedPage = pageAdisyonAyrinti;
                layoutView1.RefreshData();
            }
        }

        void MiktarArttir(int sayi)
        {
            UrunHareket row = (UrunHareket)layoutView1.GetFocusedRow();
            if (row == null) return;
            if (sayi < 0 && row.Miktar <= 1)  // urun miktarı 1 den az olmasını önlüyor
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
            urunHareketEntity.AdisyonId = secilenAdisyon.Id;
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
            EkMalzemeButonOlustur(button.EkMalzemeCarpan, button.EkMalzemeler);
            txtPorsiyonTutar.Value = button.Fiyat;

        }
        void EkMalzemeButonOlustur(decimal EkMalzemeCarpan, IEnumerable<EkMalzeme> EkMalzemeList)
        {
            flowEkMalzeme.Controls.Clear();
            foreach (var malzeme in EkMalzemeList)
            {
                ControlEkMalzemeButton MalzemeButton = new ControlEkMalzemeButton
                {
                    Name = malzeme.Id.ToString(),
                    Text = malzeme.Adi + System.Environment.NewLine + (malzeme.Fiyat * EkMalzemeCarpan).ToString("C2"),
                    Height = 200,
                    Width = 200,
                    Font = new Font("Tahoma", 10, FontStyle.Bold),
                    Id = malzeme.Id,
                    Fiyat = malzeme.Fiyat * EkMalzemeCarpan
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
                    if (!worker.EkMalzemeHareketService.Exist(c => c.UrunHareketId == urunHareketEntity.Id && c.EkMalzemeId == button.Id))
                    {
                        worker.EkMalzemeHareketService.AddOrUpdate(new EkMalzemeHareket
                        {
                           Id = Guid.NewGuid(),
                           UrunHareketId = urunHareketEntity.Id,
                           EkMalzemeId = button.Id,
                           Fiyat = button.Fiyat

                        });
                    }
                }
                else
                {
                    worker.EkMalzemeHareketService.EntityStateChange(c => c.UrunHareketId == urunHareketEntity.Id && c.EkMalzemeId == button.Id, System.Data.Entity.EntityState.Deleted);
                }
            }
            EkMalzemeHesapla();
            urunHareketEntity.BirimFiyat = txtToplamTutar.Value;
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

        

        private void btnFiyatDegistir_Click(object sender, EventArgs e)
        {
            if (layoutView1.GetFocusedRow() == null)
            {
                return;
            }
            keypadIslem = KeypadIslem.FiyatDegistir;
            txtMiktar.Text = null;
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
                    else if (hareketEntity.Miktar < txtMiktar.Value)
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
                    if (hareketEntity.Miktar == txtMiktar.Value)
                    {
                        hareketEntity.UrunHareketTip = UrunHareketTip.Ikram;
                    }
                    else if (hareketEntity.Miktar < txtMiktar.Value)
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
                    if (hareketEntity.Miktar == txtMiktar.Value)
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
                case KeypadIslem.Indirim:
                    if (txtMiktar.Value < 0 || txtMiktar.Value > 100)
                    {
                        MessageBox.Show("Girdiğiniz indirim oranı 0 ile 100 arasında olmalı");
                        return;
                    }
                    hareketEntity.Indirim = txtMiktar.Value;
                    layoutView1.RefreshData();
                    break;
            }
            keypadIslem = KeypadIslem.Yok;
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
                txtMiktar.Text = null;
                txtMiktar.Properties.NullValuePrompt = "Lütfen ikram edilecek miktarı girin";
            }
        }

        

        private void btnEkMalzeme_Click(object sender, EventArgs e)
        {
            urunHareketEntity = (UrunHareket)layoutView1.GetFocusedRow();
            if (layoutView1.GetFocusedRow() == null)
            {
                return;
            }
            Porsiyon porsiyonEntity = worker.PorsiyonService.Get(c => c.Id == urunHareketEntity.PorsiyonId);
            IEnumerable<EkMalzeme> ekMalzemesList = worker.EkMalzemeService.GetList(c => c.UrunId == urunHareketEntity.UrunId);
            EkMalzemeButonOlustur(porsiyonEntity.EkMalzemeCarpan, ekMalzemesList);
            List<EkMalzemeHareket> HareketList = worker.EkMalzemeHareketService.BindingList().ToList();
            foreach (var hareket in HareketList.Where(c => c.UrunHareketId == urunHareketEntity.Id).ToList())
            {
                ControlEkMalzemeButton button = (ControlEkMalzemeButton)flowEkMalzeme.Controls.Find(hareket.EkMalzemeId.ToString(), true)[0];
                button.Checked = true;
            }
        }

        private void btnİndirim_Click(object sender, EventArgs e)
        {
            UrunHareket entity = (UrunHareket)layoutView1.GetFocusedRow();
            if (entity==null)
            {
                return;
            }
            keypadIslem = KeypadIslem.Indirim;
            txtMiktar.Text = null;
            txtMiktar.Properties.NullValuePrompt = "Lütfen indirm oranını girin";
        }

        private void btnIade_Click(object sender, EventArgs e)
        {
            if (layoutView1.GetFocusedRow() == null) return;
            UrunHareket hareketEntity = (UrunHareket)layoutView1.GetFocusedRow();
            if (hareketEntity.UrunHareketTip == UrunHareketTip.Iptal)
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

        private void btnBol_Click(object sender, EventArgs e)
        {
            if (layoutView1.GetFocusedRow() == null) return;
            UrunHareket hareketEntity = (UrunHareket)layoutView1.GetFocusedRow();
            if (hareketEntity.Miktar == 1)
            {
                MessageBox.Show("Miktarınız bölmeye uygun değil");
            }
            else
            {
                keypadIslem = KeypadIslem.Bol;
                txtMiktar.Properties.NullValuePrompt = "Lütfen bölünecek miktarı girin";
            }
        }

        private void btnMiktarAzalt_Click_1(object sender, EventArgs e)
        {
            MiktarArttir(-1);    //urun miktarı azaltıyor
        }

        private void btnSiparisKaydet_Click(object sender, EventArgs e)
        {
            
            if (layoutView1.RowCount==0)
            {
                btnGarsonSecim.Visible = false;
                navigationMain.SelectedPage = pageMasalar;
                return;
            }
            if (btnGarsonSecim.GarsonId==Guid.Empty)
            {
                MessageBox.Show("Lütfen kaydedebilmek için bir garson seçin");
                return;
            }
            btnGarsonSecim.Visible = false;
            secilenAdisyon.GarsonId = btnGarsonSecim.GarsonId;
            btnGarsonSecim.Clear();
            worker.AdisyonService.AddOrUpdate(secilenAdisyon);
            ControlMasaButton button = (ControlMasaButton)flowMasalar.Controls.Find(secilenMasa.Id.ToString(),true)[0];
            button.MasaDurum = MasaDurum.Dolu;
            secilenAdisyon.AdisyonAcik = true;
            worker.Commit();
            worker = new RestaurantWorker();
            gridControl1.DataSource = worker.UrunHareketService.BindingList();
            navigationMain.SelectedPage = pageMasalar;
        }

        private void btnGarsonSecim_Click(object sender, EventArgs e)
        {

            navigationKategori.SelectedPage = pageGarson;
        }
        
    }
    
}

