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
using DevExpress.Utils;
using Sas.Restaurant.Components.CallerId;
using Sas.Restaurant.UI.BackOffice.Musteri;
using Sas.Reustrant.Core.Monitors;
using System.Data.Entity;
using TableDependency.SqlClient.Base.Enums;

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
            Indirim,
            OdemeBol
        }

        RestaurantWorker worker = new RestaurantWorker();
        private UrunHareket urunHareketEntity;
        private Adisyon secilenAdisyon;
        private Masa secilenMasa;
        private KeypadIslem keypadIslem = KeypadIslem.Yok;
        private CallerId callerId;
        private SqlMonitor<AramaKaydi> aramaKaydiMonitor = new SqlMonitor<AramaKaydi>("AramaKayitlari", null, DmlTriggerType.All);
        private SqlMonitor<UrunHareket> urunHareketMonitor = new SqlMonitor<UrunHareket>("UrunHareketleri", c => c.SiparisDurum == SiparisDurum.ServiseHazir,DmlTriggerType.All);
        public FrmMain()
        {
            InitializeComponent();
            KategoriButtonOlustur();
            MasaButonOlustur();
            MusteriButtonOlustur();
            OdemeTuruButtonOlustur();
            SiparisButtonOlustur();
            aramaKaydiMonitor.OnChange += AramaKaydiChanged;
            urunHareketMonitor.OnChange += UrunHareketChanged;
            callerId = new CallerId(this);
            callerId.AlertYeniKayit += CallerIdYeniKayit;
            callerId.AlertYeniSiparis += CallerIdYeniSiparis;

        }

        private void UrunHareketChanged()
        {
            Invoke((MethodInvoker)delegate
           {
               controlBadgButton1.Count++;
               gridControlBildirim.DataSource = worker.AdisyonService.MutfakUrunHareketGetir(c => c.SiparisDurum == SiparisDurum.ServiseHazir&& DbFunctions.TruncateTime(c.EklenmeTarihi)==DateTime.Now.Date); //gece çalışan restorantlar için eklenme tarihini eklemeyebiliriz
           });
        }

        private void AramaKaydiChanged()
        {
            Invoke((MethodInvoker)delegate
            {
                AramaKaydiListele();
            });
        }

        private void CallerIdYeniSiparis(object sender, CallerIdEventArgs e)
        {
            if (navigationMain.SelectedPage == pageAdisyonAyrinti)
            {
                MessageBox.Show("Kaydedilmemiş bir adisyon var. Lütfen adisyonu kaydettikten sonra tekrar deneyin");
                return;
            }
            YeniSiparisEkle(e.Telefon.Musteri);
        }

        private void CallerIdYeniKayit(object sender, CallerIdEventArgs e)
        {
            YeniMusteriKaydet(e.Telefon);
        }
        private void YeniMusteriKaydet(Telefon telefon)
        {
            FrmMusteriIslem form = new FrmMusteriIslem(new Entites.Tables.Musteri(), telefon);
            form.ShowDialog();
            if (form.Kaydedildi)
            {
                MusteriButtonOlustur();
                if (MessageBox.Show("Kişiyi kaydettiniz. Bu kişiye bir adisyon oluşturmak ister misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    YeniSiparisEkle();
                }
            }
        }

        void OdemeTuruButtonOlustur()
        {
            foreach (var odemeTuru in worker.OdemeTuruService.GetList(null))
            {
                ControlOdemeTuruButton button = new ControlOdemeTuruButton
                {
                    Name = odemeTuru.Id.ToString(),
                    Text = odemeTuru.Adi,
                    OdemeTuruId = odemeTuru.Id,
                    Height = 75,
                    Width = 125,
                    Font = new Font("Tahoma", 8, FontStyle.Bold),
                    Appearance = { TextOptions = { WordWrap = WordWrap.Wrap } }
                };
                button.Click += OdemeButtonClick;
                flowOdemeTurleri.Controls.Add(button);
            }
        }

        private void OdemeButtonClick(object sender, EventArgs e)
        {
            ControlOdemeTuruButton button = (ControlOdemeTuruButton)sender;
            if (txtKalanTutar.Value == 0)
            {
                return;
            }
            if (txtOdemeTutari.Value <= 0)
            {
                return;
            }
            worker.OdemeTuruService.Load(c => c.Id == button.OdemeTuruId);
            worker.OdemeHareketService.AddOrUpdate(new OdemeHareket()
            {
                AdisyonId = secilenAdisyon.Id,
                OdemeTuruId = button.OdemeTuruId,
                Tutar = txtOdemeTutari.Value
            });
            UrunHareketToplamGetir();
            txtOdemeTutari.Value = 0;
            if (txtKalanTutar.Value < 0)
            {
                lblMesaj.Visible = true;
                lblMesaj.Text = ($"Müşteriye ödenecek para üstü{Math.Abs(txtKalanTutar.Value).ToString("C2")}'dir");
            }

        }

        void MusteriButtonOlustur()
        {
            flowMusteri.Controls.Clear();
            foreach (var musteri in worker.MusteriService.GetList(null))
            {
                ControlMusteriButton button = new ControlMusteriButton
                {
                    Name = musteri.Id.ToString(),
                    Adi = musteri.Adi,
                    Soyadi = musteri.Soyadi,
                    MusteriId = musteri.Id,
                    MusteriTip = musteri.MusteriTip,
                    Height = 150,
                    Width = 150,


                };
                button.Load();
                button.Click += MusteriSec;
                flowMusteri.Controls.Add(button);
            }
        }

        void SiparisButtonOlustur()
        {
            foreach (var siparis in worker.AdisyonService.GetList(c => c.AdisyonTipi == AdisyonTipi.Siparis && c.AdisyonDurum == AdisyonDurum.Acik))
            {
                ControlSiparisButton button = new ControlSiparisButton
                {
                    Name = siparis.Id.ToString(),
                    AdisyonId = siparis.Id,
                    Height = 100,
                    Width = 200,
                    Text = "Sipariş",
                    Font = new Font("Tahoma", 10, FontStyle.Bold)

                };
                button.Click += SiparisSec;
                flowSiparis.Controls.Add(button);
            }
        }
        private void MusteriSec(object sender, EventArgs e)
        {
            ControlMusteriButton button = (ControlMusteriButton)sender;
            btnMusteri.MusteriId = button.MusteriId;
            btnMusteri.Adi = button.Adi;
            btnMusteri.Soyadi = button.Soyadi;
            btnMusteri.MusteriTip = button.MusteriTip;
            btnMusteri.Load();
            navigationKategori.SelectedPage = pageKategoriUrunler;
        }

        void GarsonButtonOlustur(PersonelTipi personelTipi)
        {
            flowGarson.Controls.Clear();
            foreach (var garson in worker.GarsonService.GetList(c => c.PersonelTipi == personelTipi))
            {
                ControlGarsonCheckButton button = new ControlGarsonCheckButton
                {
                    Name = garson.Id.ToString(),
                    Text = $"{garson.Adi}{garson.Soyadi}",
                    Height = 150,
                    Width = 150,
                    Font = new Font("Tahoma", 12, FontStyle.Bold),
                    GroupIndex = 1,
                    GarsonId = garson.Id,
                    Adi = garson.Adi,
                    Soyadi = garson.Soyadi
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
            secilenAdisyon.GarsonId = button.GarsonId;
            navigationKategori.SelectedPage = pageKategoriUrunler;
        }

        void MasaButonOlustur()
        {
            foreach (var konum in worker.TanimService.GetList(c => c.TanimTip == TanimTip.Konum))
            {
                ControlKonumButton button = new ControlKonumButton
                {
                    Name = konum.Id.ToString(),
                    Text = konum.Adi,
                    Height = 88,
                    Width = 150,
                    GroupIndex = 1,
                    Font = new Font("Tahoma", 12, FontStyle.Bold),
                    Masalar = worker.MasaService.GetList(c => c.KonumId == konum.Id)

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
            foreach (var adisyon in worker.AdisyonService.GetList(c => c.AdisyonDurum == AdisyonDurum.Acik))
            {
                ControlMasaButton buttonMasa = flowMasalar.Controls.Cast<ControlMasaButton>().SingleOrDefault(c => c.MasaId == adisyon.MasaId);
                if (buttonMasa != null)
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
            btnMusteri.Visible = true;
            gridControl1.DataSource = worker.UrunHareketService.BindingList();
            gridControlOdeme.DataSource = worker.OdemeHareketService.BindingList();
            GarsonButtonOlustur(PersonelTipi.Garson);
            navigationKategori.SelectedPage = pageKategoriUrunler;
            if (button.MasaDurum == MasaDurum.Bos)
            {
                secilenAdisyon = new Adisyon();
                secilenAdisyon.Id = Guid.NewGuid();
                secilenAdisyon.AdisyonTipi = AdisyonTipi.Masa;
                secilenMasa = worker.MasaService.Get(c => c.Id == button.MasaId);
                secilenAdisyon.MasaId = button.MasaId;
                btnGarsonSecim.Image = ımageList2.Images[0];
                btnGarsonSecim.Text = "Garson Seçilmedi";
                button.AdisyonId = secilenAdisyon.Id;
                btnMusteri.Load();
                ToplamlariSifirla();
                navigationMain.SelectedPage = pageAdisyonAyrinti;
            }
            else if (button.MasaDurum == MasaDurum.Dolu)
            {
                worker.UrunHareketService.Load(c => c.AdisyonId == button.AdisyonId, c => c.Urun, c => c.Porsiyon, c => c.Porsiyon.Birim, c => c.EkMalzemeHareketleri);
                worker.AdisyonService.Load(c => c.Id == button.AdisyonId);
                worker.OdemeHareketService.Load(c => c.AdisyonId == button.AdisyonId, c => c.OdemeTuru);
                worker.EkMalzemeHareketService.Load(null);
                secilenAdisyon = worker.AdisyonService.Get(c => c.Id == button.AdisyonId);
                secilenMasa = worker.MasaService.Get(c => c.Id == button.MasaId);
                Personel garson = worker.GarsonService.Get(c => c.Id == secilenAdisyon.GarsonId);
                btnGarsonSecim.Image = ımageList2.Images[0];
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
                if (secilenAdisyon.MusteriId != Guid.Empty)
                {
                    Musteri musteri = worker.MusteriService.Get(c => c.Id == secilenAdisyon.MusteriId);
                    if (musteri != null)
                    {
                        btnMusteri.MusteriId = musteri.Id;
                        btnMusteri.Adi = musteri.Adi;
                        btnMusteri.Soyadi = musteri.Soyadi;
                        btnMusteri.MusteriTip = musteri.MusteriTip;
                        btnMusteri.Load();
                    }
                }

                button.AdisyonId = secilenAdisyon.Id;
                navigationMain.SelectedPage = pageAdisyonAyrinti;
                layoutView1.RefreshData();
                UrunHareketToplamGetir();
            }

        }

        void ToplamlariSifirla()
        {
            txtKalanTutar.Value = 0;
            txtOdemeTutari.Value = 0;
            txtOdenenTutar.Value = 0;
            txtToplamUrunHareketTutar.Value = 0;
            txtUrunHareketIndirimTutar.Value = 0;
            txtUrunHareketOdenecekTutar.Value = 0;
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
            UrunHareketToplamGetir();
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
            EkMalzemeHesapla();
            urunHareketEntity.EkMalzemeFiyat = txtEkMalzemeTutar.Value;
            UrunHareketEkle();
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

            navigationKategori.SelectedPage = pageKategoriUrunler;

        }
        void UrunHareketEkle()   //Urun ekleme kısmı
        {
            if (!worker.AdisyonService.Exist(c => c.Id == secilenAdisyon.Id))
            {
                worker.AdisyonService.AddOrUpdate(secilenAdisyon);
                worker.Commit();
            }
            btnKategoriyeDon.Visible = false;
            worker.UrunHareketService.AddOrUpdate(urunHareketEntity);
            worker.UrunService.Load(c => c.Id == urunHareketEntity.UrunId);
            worker.PorsiyonService.Load(c => c.Id == urunHareketEntity.PorsiyonId);
            Guid id = urunHareketEntity.Porsiyon.BirimId;
            worker.TanimService.Load(c => c.Id == id);
            layoutView1.RefreshData();
            UrunHareketToplamGetir();
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
            if (navigationKategori.SelectedPage == pageOdemeEkrani)
            {
                txtOdemeTutari.Focus();
                SendKeys.Send(button.Text);
            }
            else
            {
                txtMiktar.Focus();
                SendKeys.Send(button.Text);
            }

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
                case KeypadIslem.OdemeBol:
                    txtOdemeTutari.Value = txtKalanTutar.Value / txtOdemeTutari.Value;
                    break;
            }
            keypadIslem = KeypadIslem.Yok;
            UrunHareketToplamGetir();
        }



        private void btnIkram_Click(object sender, EventArgs e)
        {
            if (layoutView1.GetFocusedRow() == null) return;
            UrunHareket hareketEntity = (UrunHareket)layoutView1.GetFocusedRow();
            if (hareketEntity.Miktar == 1)
            {
                hareketEntity.UrunHareketTip = UrunHareketTip.Ikram;
                layoutView1.RefreshData();
                UrunHareketToplamGetir();
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
            txtPorsiyonTutar.Value = porsiyonEntity.Fiyat;
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
            if (entity == null)
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
                UrunHareketToplamGetir();
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

            if (layoutView1.RowCount == 0)
            {
                btnMusteri.Clear();
                btnGarsonSecim.Visible = false;
                btnMusteri.Visible = false;
                navigationMain.SelectedPage = pageMasalar;
                return;
            }
            if (btnGarsonSecim.GarsonId == Guid.Empty)
            {
                MessageBox.Show("Lütfen kaydedebilmek için bir personel seçin");
                return;
            }

            secilenAdisyon.GarsonId = btnGarsonSecim.GarsonId;
            if (btnMusteri.MusteriId != Guid.Empty)
            {
                secilenAdisyon.MusteriId = btnMusteri.MusteriId;
            }
            btnGarsonSecim.Clear();
            btnMusteri.Clear();
            secilenAdisyon.Tutar = txtUrunHareketOdenecekTutar.Value;
            btnGarsonSecim.Visible = false;
            btnMusteri.Visible = false;
            worker.AdisyonService.AddOrUpdate(secilenAdisyon);
            if (secilenAdisyon.AdisyonTipi == AdisyonTipi.Masa)
            {
                ControlMasaButton button = (ControlMasaButton)flowMasalar.Controls.Find(secilenMasa.Id.ToString(), true)[0];
                if (secilenAdisyon.AdisyonDurum == AdisyonDurum.Iptal || txtKalanTutar.Value <= 0)
                {
                    button.MasaDurum = MasaDurum.Bos;
                }
                else
                {
                    button.MasaDurum = MasaDurum.Dolu;
                }
            }
            if (secilenAdisyon.AdisyonTipi == AdisyonTipi.Siparis)
            {
                ControlSiparisButton button = (ControlSiparisButton)flowSiparis.Controls.Find(secilenAdisyon.Id.ToString(), true)[0];
                if (secilenAdisyon.AdisyonDurum == AdisyonDurum.Iptal && txtKalanTutar.Value <= 0)
                {
                    button.Dispose(); //tamamen programdan sil
                }
            }
            if (txtKalanTutar.Value <= 0)
            {

                secilenAdisyon.AdisyonDurum = AdisyonDurum.Kapali;
                btnSiparisKaydet.Text = "Değişiklikleri\nKaydet";
                btnSiparisKaydet.ImageOptions.ImageIndex = 0;
            }
            else
            {

                secilenAdisyon.AdisyonDurum = AdisyonDurum.Acik;
            }

            worker.Commit();
            worker = new RestaurantWorker();
            gridControl1.DataSource = worker.UrunHareketService.BindingList();
            gridControlOdeme.DataSource = worker.OdemeHareketService.BindingList();
            lblMesaj.Visible = false;
            navigationMain.SelectedPage = pageMasalar;
        }

        private void btnGarsonSecim_Click(object sender, EventArgs e)
        {

            if (navigationKategori.SelectedPage == pageGarson)
            {
                navigationKategori.SelectedPage = pageKategoriUrunler;
            }
            else
            {
                navigationKategori.SelectedPage = pageGarson;
            }
        }

        private void btnMusteri_Click(object sender, EventArgs e)
        {
            if (navigationKategori.SelectedPage == pageMusteri)
            {
                navigationKategori.SelectedPage = pageKategoriUrunler;
            }
            else
            {
                navigationKategori.SelectedPage = pageMusteri;
            }

        }

        private void UrunHareketToplamGetir()
        {
            AdisyonToplamDto toplamlar = worker.AdisyonService.AdisyonToplamGetir();
            txtToplamUrunHareketTutar.Value = toplamlar.ToplamTutar;
            txtUrunHareketIndirimTutar.Value = toplamlar.IndirimTutar;
            txtUrunHareketOdenecekTutar.Value = toplamlar.OdenecekTutar;
            txtOdenenTutar.Value = toplamlar.OdenenTutar;
            txtKalanTutar.Value = toplamlar.KalanTutar;
            if (toplamlar.KalanTutar <= 0)
            {
                btnSiparisKaydet.ImageOptions.ImageIndex = 1;
                btnSiparisKaydet.Text = "Masayı Kapat";
            }
            else
            {
                btnSiparisKaydet.ImageOptions.ImageIndex = 0;
                btnSiparisKaydet.Text = "Şiparişi\nKaydet";
            }
        }


        private void btnOdemeTumu_Click(object sender, EventArgs e)
        {
            txtOdemeTutari.Value = txtKalanTutar.Value;
        }


        private void btnOdemeYarim_Click(object sender, EventArgs e)
        {
            txtOdemeTutari.Value = txtKalanTutar.Value / 2;
        }

        private void btnOdemeCeyrek_Click(object sender, EventArgs e)
        {
            txtOdemeTutari.Value = txtKalanTutar.Value / 4;
        }

        private void btnOdemeN_Click(object sender, EventArgs e)
        {
            keypadIslem = KeypadIslem.OdemeBol;
            txtMiktar.Text = null;
            txtMiktar.Properties.NullValuePrompt = "Lütfen bölünecek değeri girin";
        }

        private void ParaClick(object sender, EventArgs e)
        {
            ControlParaButton button = (ControlParaButton)sender;
            txtOdemeTutari.Value += button.Deger;
        }

        private void btnKeypadBack_Click(object sender, EventArgs e)
        {
            if (navigationKategori.SelectedPage == pageOdemeEkrani)
            {
                txtOdemeTutari.Focus();
                SendKeys.Send("{BACKSPACE}");
            }
            else
            {
                txtMiktar.Focus();
                SendKeys.Send("{BACKSPACE}");
            }
        }

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            if (navigationKategori.SelectedPage == pageOdemeEkrani)
            {
                navigationKategori.SelectedPage = pageKategoriUrunler;
            }
            else
            {
                navigationKategori.SelectedPage = pageOdemeEkrani;
            }
        }

        private void btnKeypadDel_Click(object sender, EventArgs e)
        {
            if (navigationKategori.SelectedPage == pageOdemeEkrani)
            {
                txtOdemeTutari.Value = 0;

            }
            else
            {
                txtMiktar.Value = 0;
            }
        }

        private void btnSiparisİptal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Adisyonu iptal edeceksiniz. Emin misiniz?", "Uyarı", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                secilenAdisyon.AdisyonDurum = AdisyonDurum.Iptal;
                btnSiparisKaydet.PerformClick();
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void UrunNotClick(object sender, EventArgs e)
        {
            SimpleButton button = (SimpleButton)sender;
            if (String.IsNullOrEmpty(txturunNotu.Text))
            {
                txturunNotu.Text = button.Text;
            }
            else
            {
                txturunNotu.Text = ", " + button.Text;
            }
        }

        private void btnUrunNotOnayla_Click(object sender, EventArgs e)
        {
            UrunHareket entity = (UrunHareket)layoutView1.GetFocusedRow();
            entity.Aciklama = txturunNotu.Text;
            layoutView1.RefreshData();
            navigationKategori.SelectedPage = pageKategoriUrunler;
        }

        private void btnUrunNotu_Click(object sender, EventArgs e)
        {
            flowUrunNotlari.Controls.Clear();
            UrunHareket entity = (UrunHareket)layoutView1.GetFocusedRow();
            if (entity == null)
            {
                return;
            }
            navigationKategori.SelectedPage = pageUrunNotlari;
            txturunNotu.Text = entity.Aciklama;
            foreach (var urunNot in worker.UrunNotService.GetList(c => c.UrunId == entity.UrunId))
            {
                SimpleButton button = new SimpleButton
                {
                    Name = urunNot.Id.ToString(),
                    Text = urunNot.Notu,
                    Width = 200,
                    Height = 40


                };
                button.Click += UrunNotClick;
                flowUrunNotlari.Controls.Add(button);
            }
        }

        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
            navigationKategori.SelectedPage = pageKategoriUrunler;
        }

        private void btnMasalar_Click(object sender, EventArgs e)
        {
            navigationMain.SelectedPage = pageMasalar;
        }

        private void btnSiparisler_Click(object sender, EventArgs e)
        {
            navigationMain.SelectedPage = pageSiparis;
        }

        private void navigationMain_SelectedPageChanged(object sender, DevExpress.XtraBars.Navigation.SelectedPageChangedEventArgs e)
        {
            if (e.Page == pageAdisyonAyrinti)
            {
                panelAnaSolMenu.Visible = false;
            }
            else
            {
                panelAnaSolMenu.Visible = true;
            }

        }

        private void btnYeniSiparisEkle_Click(object sender, EventArgs e)
        {
            YeniSiparisEkle();
        }

        private void YeniSiparisEkle(Musteri musteri = null)
        {
            btnGarsonSecim.Visible = true;
            btnMusteri.Visible = true;
            gridControl1.DataSource = worker.UrunHareketService.BindingList();
            gridControlOdeme.DataSource = worker.OdemeHareketService.BindingList();
            GarsonButtonOlustur(PersonelTipi.Kurye);
            navigationKategori.SelectedPage = pageKategoriUrunler;
            secilenAdisyon = new Adisyon();
            secilenAdisyon.Id = Guid.NewGuid();
            secilenAdisyon.AdisyonTipi = AdisyonTipi.Siparis;
            if (musteri != null)
            {
                btnMusteri.MusteriId = musteri.Id;
                btnMusteri.MusteriTip = musteri.MusteriTip;
                btnMusteri.Adi = musteri.Adi;
                btnMusteri.Soyadi = musteri.Soyadi;
            }
            ControlSiparisButton button = new ControlSiparisButton
            {
                Height = 100,
                Width = 200,
                Name = secilenAdisyon.Id.ToString(),
                AdisyonId = secilenAdisyon.Id,
                Text = "Sipariş"
            };
            button.Click += SiparisSec;
            flowSiparis.Controls.Add(button);
            btnGarsonSecim.Image = ımageList2.Images[1];
            btnGarsonSecim.Text = "Kurye Seçilmedi";
            button.AdisyonId = secilenAdisyon.Id;
            btnMusteri.Load();
            ToplamlariSifirla();
            navigationMain.SelectedPage = pageAdisyonAyrinti;
        }
        private void SiparisSec(object sender, EventArgs e)
        {
            ControlSiparisButton button = (ControlSiparisButton)sender;
            btnGarsonSecim.Visible = true;
            btnMusteri.Visible = true;
            gridControl1.DataSource = worker.UrunHareketService.BindingList();
            gridControlOdeme.DataSource = worker.OdemeHareketService.BindingList();
            GarsonButtonOlustur(PersonelTipi.Kurye);
            navigationKategori.SelectedPage = pageKategoriUrunler;

            worker.UrunHareketService.Load(c => c.AdisyonId == button.AdisyonId, c => c.Urun, c => c.Porsiyon, c => c.Porsiyon.Birim, c => c.EkMalzemeHareketleri);
            worker.AdisyonService.Load(c => c.Id == button.AdisyonId);
            worker.OdemeHareketService.Load(c => c.AdisyonId == button.AdisyonId, c => c.OdemeTuru);
            worker.EkMalzemeHareketService.Load(null);
            secilenAdisyon = worker.AdisyonService.Get(c => c.Id == button.AdisyonId);
            Personel garson = worker.GarsonService.Get(c => c.Id == secilenAdisyon.GarsonId);
            btnGarsonSecim.Image = ımageList2.Images[1];
            if (garson != null)
            {
                btnGarsonSecim.Adi = garson.Adi;
                btnGarsonSecim.Soyadi = garson.Soyadi;
                btnGarsonSecim.GarsonId = garson.Id;
            }
            else
            {
                btnGarsonSecim.Text = "Kurye Seçilmedi";
            }
            if (secilenAdisyon.MusteriId != Guid.Empty)
            {
                Musteri musteri = worker.MusteriService.Get(c => c.Id == secilenAdisyon.MusteriId);
                if (musteri != null)
                {
                    btnMusteri.MusteriId = musteri.Id;
                    btnMusteri.Adi = musteri.Adi;
                    btnMusteri.Soyadi = musteri.Soyadi;
                    btnMusteri.MusteriTip = musteri.MusteriTip;
                    btnMusteri.Load();
                }
            }

            button.AdisyonId = secilenAdisyon.Id;
            navigationMain.SelectedPage = pageAdisyonAyrinti;
            layoutView1.RefreshData();
            UrunHareketToplamGetir();
        }

        private void btnAramaKaydi_Click(object sender, EventArgs e)
        {
            navigationMain.SelectedPage = pageAramaKaydi;

            AramaKaydiListele();

        }
        void AramaKaydiListele()
        {
            //using (RestaurantWorker worker = new RestaurantWorker())
            //{
                gridControl2.DataSource = worker.AramaKaydiService.AramaKaydiList(DateTime.Now);
            //}
        }
        private void repoYeniKayitEkle_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DtoAramaKaydi row = (DtoAramaKaydi)gridView1.GetFocusedRow();
            if (row.MusteriAdi == " ")
            {
                YeniMusteriKaydet(new Telefon
                {
                    Telefonu = row.Telefon
                });
            }
            else
            {
                MessageBox.Show("Bu müşteri bilgisi zaten kaydedilmiş");
            }


        }

        private void repoAdisyonOlustur_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DtoAramaKaydi row = (DtoAramaKaydi)gridView1.GetFocusedRow();
            if (row.MusteriAdi == " ")
            {
                MessageBox.Show("Bu müşteri bilgisi  kaydedilmemiş.Öncelikle kaydedin");
            }
            else
            {

                YeniSiparisEkle(worker.MusteriService.Get(c => c.Id == row.MusteriId));
            }
        }

        private void controlBadgButton1_Click(object sender, EventArgs e)
        {
            navigationMain.SelectedPage = pageBildirim;
        }
    }
}

