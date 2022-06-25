
namespace Sas.Restaurant.UI.BackOffice.Adisyon
{
    partial class FrmAdisyonHareket
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAdisyonHareket));
            this.gridUrunHareketleri = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colHareketTip = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPorsiyon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMiktar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBirimFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEkMalzemeFiyat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunIndirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunToplam = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlAdisyonHareket = new DevExpress.XtraGrid.GridControl();
            this.gridOdemeHareketleri = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOdemeTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeSekli = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridAdisyonHareket = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdisyonDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGarson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.controlMenu = new Sas.Restaurant.UserControls.ControlAnaMenuAlt();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateGunSecim2 = new DevExpress.XtraEditors.DateEdit();
            this.dateGunSecim = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunHareketleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAdisyonHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdemeHareketleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdisyonHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunSecim2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunSecim2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunSecim.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunSecim.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridUrunHareketleri
            // 
            this.gridUrunHareketleri.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colHareketTip,
            this.colUrunAdi,
            this.colUrunTarih,
            this.colUrunSaat,
            this.colPorsiyon,
            this.colBirim,
            this.colMiktar,
            this.colBirimFiyat,
            this.colEkMalzemeFiyat,
            this.colUrunIndirim,
            this.colUrunToplam});
            this.gridUrunHareketleri.GridControl = this.gridControlAdisyonHareket;
            this.gridUrunHareketleri.Name = "gridUrunHareketleri";
            this.gridUrunHareketleri.OptionsView.ShowGroupPanel = false;
            // 
            // colHareketTip
            // 
            this.colHareketTip.Caption = "Hareket";
            this.colHareketTip.FieldName = "UrunHareketTip";
            this.colHareketTip.MinWidth = 25;
            this.colHareketTip.Name = "colHareketTip";
            this.colHareketTip.OptionsColumn.AllowEdit = false;
            this.colHareketTip.Visible = true;
            this.colHareketTip.VisibleIndex = 0;
            this.colHareketTip.Width = 96;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.Caption = "Ürün Adı";
            this.colUrunAdi.FieldName = "Urun.Adi";
            this.colUrunAdi.MinWidth = 25;
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.OptionsColumn.AllowEdit = false;
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 1;
            this.colUrunAdi.Width = 268;
            // 
            // colUrunTarih
            // 
            this.colUrunTarih.Caption = "Tarih";
            this.colUrunTarih.DisplayFormat.FormatString = "d";
            this.colUrunTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colUrunTarih.FieldName = "EklenmeTarihi";
            this.colUrunTarih.MinWidth = 25;
            this.colUrunTarih.Name = "colUrunTarih";
            this.colUrunTarih.OptionsColumn.AllowEdit = false;
            this.colUrunTarih.Visible = true;
            this.colUrunTarih.VisibleIndex = 2;
            this.colUrunTarih.Width = 94;
            // 
            // colUrunSaat
            // 
            this.colUrunSaat.Caption = "Saat";
            this.colUrunSaat.DisplayFormat.FormatString = "T";
            this.colUrunSaat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colUrunSaat.FieldName = "EklenmeTarihi";
            this.colUrunSaat.MinWidth = 25;
            this.colUrunSaat.Name = "colUrunSaat";
            this.colUrunSaat.OptionsColumn.AllowEdit = false;
            this.colUrunSaat.Visible = true;
            this.colUrunSaat.VisibleIndex = 3;
            this.colUrunSaat.Width = 94;
            // 
            // colPorsiyon
            // 
            this.colPorsiyon.Caption = "Porsiyon";
            this.colPorsiyon.FieldName = "Porsiyon.Adi";
            this.colPorsiyon.MinWidth = 25;
            this.colPorsiyon.Name = "colPorsiyon";
            this.colPorsiyon.OptionsColumn.AllowEdit = false;
            this.colPorsiyon.Visible = true;
            this.colPorsiyon.VisibleIndex = 4;
            this.colPorsiyon.Width = 263;
            // 
            // colBirim
            // 
            this.colBirim.Caption = "Birim";
            this.colBirim.FieldName = "Porsiyon.Birim.Adi";
            this.colBirim.MinWidth = 25;
            this.colBirim.Name = "colBirim";
            this.colBirim.OptionsColumn.AllowEdit = false;
            this.colBirim.Visible = true;
            this.colBirim.VisibleIndex = 5;
            this.colBirim.Width = 79;
            // 
            // colMiktar
            // 
            this.colMiktar.Caption = "Miktar";
            this.colMiktar.DisplayFormat.FormatString = "N0";
            this.colMiktar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colMiktar.FieldName = "Miktar";
            this.colMiktar.MinWidth = 25;
            this.colMiktar.Name = "colMiktar";
            this.colMiktar.OptionsColumn.AllowEdit = false;
            this.colMiktar.Visible = true;
            this.colMiktar.VisibleIndex = 6;
            this.colMiktar.Width = 80;
            // 
            // colBirimFiyat
            // 
            this.colBirimFiyat.Caption = "Birim Fiyat";
            this.colBirimFiyat.DisplayFormat.FormatString = "C2";
            this.colBirimFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colBirimFiyat.FieldName = "BirimFiyat";
            this.colBirimFiyat.MinWidth = 25;
            this.colBirimFiyat.Name = "colBirimFiyat";
            this.colBirimFiyat.OptionsColumn.AllowEdit = false;
            this.colBirimFiyat.Visible = true;
            this.colBirimFiyat.VisibleIndex = 7;
            // 
            // colEkMalzemeFiyat
            // 
            this.colEkMalzemeFiyat.Caption = "Ek Malzeme Tutar";
            this.colEkMalzemeFiyat.DisplayFormat.FormatString = "C2";
            this.colEkMalzemeFiyat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colEkMalzemeFiyat.FieldName = "EkMalzemeFiyat";
            this.colEkMalzemeFiyat.MinWidth = 25;
            this.colEkMalzemeFiyat.Name = "colEkMalzemeFiyat";
            this.colEkMalzemeFiyat.OptionsColumn.AllowEdit = false;
            this.colEkMalzemeFiyat.Visible = true;
            this.colEkMalzemeFiyat.VisibleIndex = 8;
            this.colEkMalzemeFiyat.Width = 116;
            // 
            // colUrunIndirim
            // 
            this.colUrunIndirim.Caption = "İndirim";
            this.colUrunIndirim.DisplayFormat.FormatString = "\'%\' 0.00";
            this.colUrunIndirim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUrunIndirim.FieldName = "Indirim";
            this.colUrunIndirim.MinWidth = 25;
            this.colUrunIndirim.Name = "colUrunIndirim";
            this.colUrunIndirim.OptionsColumn.AllowEdit = false;
            this.colUrunIndirim.Visible = true;
            this.colUrunIndirim.VisibleIndex = 9;
            this.colUrunIndirim.Width = 63;
            // 
            // colUrunToplam
            // 
            this.colUrunToplam.Caption = "Toplam Tutar";
            this.colUrunToplam.DisplayFormat.FormatString = "C2";
            this.colUrunToplam.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colUrunToplam.FieldName = "ToplamTutar";
            this.colUrunToplam.MinWidth = 25;
            this.colUrunToplam.Name = "colUrunToplam";
            this.colUrunToplam.OptionsColumn.AllowEdit = false;
            this.colUrunToplam.Visible = true;
            this.colUrunToplam.VisibleIndex = 10;
            this.colUrunToplam.Width = 115;
            // 
            // gridControlAdisyonHareket
            // 
            this.gridControlAdisyonHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.LevelTemplate = this.gridUrunHareketleri;
            gridLevelNode1.RelationName = "Ürün Hareketleri";
            gridLevelNode2.LevelTemplate = this.gridOdemeHareketleri;
            gridLevelNode2.RelationName = "Ödeme Hareketleri";
            this.gridControlAdisyonHareket.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2});
            this.gridControlAdisyonHareket.Location = new System.Drawing.Point(0, 131);
            this.gridControlAdisyonHareket.MainView = this.gridAdisyonHareket;
            this.gridControlAdisyonHareket.Name = "gridControlAdisyonHareket";
            this.gridControlAdisyonHareket.Size = new System.Drawing.Size(1185, 486);
            this.gridControlAdisyonHareket.TabIndex = 9;
            this.gridControlAdisyonHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridOdemeHareketleri,
            this.gridAdisyonHareket,
            this.gridUrunHareketleri});
            // 
            // gridOdemeHareketleri
            // 
            this.gridOdemeHareketleri.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOdemeTuru,
            this.colOdemeSekli,
            this.colOdemeTarih,
            this.colSaat,
            this.colOdemeTutar});
            this.gridOdemeHareketleri.GridControl = this.gridControlAdisyonHareket;
            this.gridOdemeHareketleri.Name = "gridOdemeHareketleri";
            this.gridOdemeHareketleri.OptionsView.ShowGroupPanel = false;
            // 
            // colOdemeTuru
            // 
            this.colOdemeTuru.Caption = "Ödeme Türü";
            this.colOdemeTuru.FieldName = "OdemeTuru.Adi";
            this.colOdemeTuru.MinWidth = 25;
            this.colOdemeTuru.Name = "colOdemeTuru";
            this.colOdemeTuru.OptionsColumn.AllowEdit = false;
            this.colOdemeTuru.Visible = true;
            this.colOdemeTuru.VisibleIndex = 0;
            this.colOdemeTuru.Width = 231;
            // 
            // colOdemeSekli
            // 
            this.colOdemeSekli.Caption = "Ödeme Şekli";
            this.colOdemeSekli.FieldName = "OdemeTuru.OdemeTur.Adi";
            this.colOdemeSekli.MinWidth = 25;
            this.colOdemeSekli.Name = "colOdemeSekli";
            this.colOdemeSekli.OptionsColumn.AllowEdit = false;
            this.colOdemeSekli.Visible = true;
            this.colOdemeSekli.VisibleIndex = 1;
            this.colOdemeSekli.Width = 393;
            // 
            // colOdemeTarih
            // 
            this.colOdemeTarih.Caption = "Tarih";
            this.colOdemeTarih.DisplayFormat.FormatString = "d";
            this.colOdemeTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colOdemeTarih.FieldName = "EklenmeTarihi";
            this.colOdemeTarih.MinWidth = 25;
            this.colOdemeTarih.Name = "colOdemeTarih";
            this.colOdemeTarih.OptionsColumn.AllowEdit = false;
            this.colOdemeTarih.Visible = true;
            this.colOdemeTarih.VisibleIndex = 2;
            this.colOdemeTarih.Width = 177;
            // 
            // colSaat
            // 
            this.colSaat.Caption = "Saat";
            this.colSaat.DisplayFormat.FormatString = "T";
            this.colSaat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colSaat.FieldName = "EklenmeTarihi";
            this.colSaat.MinWidth = 25;
            this.colSaat.Name = "colSaat";
            this.colSaat.OptionsColumn.AllowEdit = false;
            this.colSaat.Visible = true;
            this.colSaat.VisibleIndex = 3;
            this.colSaat.Width = 177;
            // 
            // colOdemeTutar
            // 
            this.colOdemeTutar.Caption = "Tutar";
            this.colOdemeTutar.DisplayFormat.FormatString = "C2";
            this.colOdemeTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colOdemeTutar.FieldName = "Tutar";
            this.colOdemeTutar.MinWidth = 25;
            this.colOdemeTutar.Name = "colOdemeTutar";
            this.colOdemeTutar.OptionsColumn.AllowEdit = false;
            this.colOdemeTutar.Visible = true;
            this.colOdemeTutar.VisibleIndex = 4;
            this.colOdemeTutar.Width = 177;
            // 
            // gridAdisyonHareket
            // 
            this.gridAdisyonHareket.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTarih,
            this.colAdisyonDurum,
            this.colMusteri,
            this.colMasaAdi,
            this.colGarson,
            this.colIndirim,
            this.colTutar});
            this.gridAdisyonHareket.GridControl = this.gridControlAdisyonHareket;
            this.gridAdisyonHareket.Name = "gridAdisyonHareket";
            this.gridAdisyonHareket.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.gridAdisyonHareket.OptionsDetail.DetailMode = DevExpress.XtraGrid.Views.Grid.DetailMode.Embedded;
            this.gridAdisyonHareket.MasterRowGetChildList += new DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(this.gridAdisyonHareket_MasterRowGetChildList);
            this.gridAdisyonHareket.MasterRowGetRelationName += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventHandler(this.gridAdisyonHareket_MasterRowGetRelationName);
            this.gridAdisyonHareket.MasterRowGetRelationCount += new DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventHandler(this.gridAdisyonHareket_MasterRowGetRelationCount);
            // 
            // colTarih
            // 
            this.colTarih.Caption = "Tarih";
            this.colTarih.DisplayFormat.FormatString = "d";
            this.colTarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colTarih.FieldName = "Tarih";
            this.colTarih.MinWidth = 25;
            this.colTarih.Name = "colTarih";
            this.colTarih.OptionsColumn.AllowEdit = false;
            this.colTarih.Visible = true;
            this.colTarih.VisibleIndex = 0;
            this.colTarih.Width = 94;
            // 
            // colAdisyonDurum
            // 
            this.colAdisyonDurum.Caption = "Durumu";
            this.colAdisyonDurum.FieldName = "AdisyonDurum";
            this.colAdisyonDurum.MinWidth = 25;
            this.colAdisyonDurum.Name = "colAdisyonDurum";
            this.colAdisyonDurum.OptionsColumn.AllowEdit = false;
            this.colAdisyonDurum.Visible = true;
            this.colAdisyonDurum.VisibleIndex = 1;
            this.colAdisyonDurum.Width = 94;
            // 
            // colMusteri
            // 
            this.colMusteri.Caption = "Müşteri Adı";
            this.colMusteri.FieldName = "MusteriAdi";
            this.colMusteri.MinWidth = 25;
            this.colMusteri.Name = "colMusteri";
            this.colMusteri.OptionsColumn.AllowEdit = false;
            this.colMusteri.Visible = true;
            this.colMusteri.VisibleIndex = 2;
            this.colMusteri.Width = 94;
            // 
            // colMasaAdi
            // 
            this.colMasaAdi.Caption = "Masa";
            this.colMasaAdi.FieldName = "MasaAdi";
            this.colMasaAdi.MinWidth = 25;
            this.colMasaAdi.Name = "colMasaAdi";
            this.colMasaAdi.OptionsColumn.AllowEdit = false;
            this.colMasaAdi.Visible = true;
            this.colMasaAdi.VisibleIndex = 3;
            this.colMasaAdi.Width = 94;
            // 
            // colGarson
            // 
            this.colGarson.Caption = "Garson";
            this.colGarson.FieldName = "GarsonAdi";
            this.colGarson.MinWidth = 25;
            this.colGarson.Name = "colGarson";
            this.colGarson.OptionsColumn.AllowEdit = false;
            this.colGarson.Visible = true;
            this.colGarson.VisibleIndex = 4;
            this.colGarson.Width = 94;
            // 
            // colIndirim
            // 
            this.colIndirim.Caption = "İndirim";
            this.colIndirim.DisplayFormat.FormatString = "\'%\' 0.00";
            this.colIndirim.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colIndirim.FieldName = "Indirim";
            this.colIndirim.MinWidth = 25;
            this.colIndirim.Name = "colIndirim";
            this.colIndirim.OptionsColumn.AllowEdit = false;
            this.colIndirim.Visible = true;
            this.colIndirim.VisibleIndex = 5;
            this.colIndirim.Width = 94;
            // 
            // colTutar
            // 
            this.colTutar.Caption = "Tutar";
            this.colTutar.DisplayFormat.FormatString = "C2";
            this.colTutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colTutar.FieldName = "Tutar";
            this.colTutar.MinWidth = 25;
            this.colTutar.Name = "colTutar";
            this.colTutar.OptionsColumn.AllowEdit = false;
            this.colTutar.Visible = true;
            this.colTutar.VisibleIndex = 6;
            this.colTutar.Width = 94;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.controlMenu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 617);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1185, 100);
            this.groupControl1.TabIndex = 8;
            this.groupControl1.Text = "Menü";
            // 
            // controlMenu
            // 
            this.controlMenu.ButtonFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.controlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlMenu.Location = new System.Drawing.Point(2, 28);
            this.controlMenu.Name = "controlMenu";
            this.controlMenu.Size = new System.Drawing.Size(1181, 70);
            this.controlMenu.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.ImageAlignToText = DevExpress.XtraEditors.ImageAlignToText.LeftCenter;
            this.labelControl1.ImageOptions.Alignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelControl1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.ImageOptions.Image")));
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1185, 69);
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Adisyon Hareketleri";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.labelControl4);
            this.panelControl1.Controls.Add(this.labelControl3);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.dateGunSecim2);
            this.panelControl1.Controls.Add(this.dateGunSecim);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 69);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1185, 62);
            this.panelControl1.TabIndex = 10;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(500, 23);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 16);
            this.labelControl4.TabIndex = 11;
            this.labelControl4.Text = "arasında";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(581, 11);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(99, 40);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Tarih :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(12, 11);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(99, 40);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "Tarih :";
            // 
            // dateGunSecim2
            // 
            this.dateGunSecim2.EditValue = null;
            this.dateGunSecim2.Location = new System.Drawing.Point(686, 11);
            this.dateGunSecim2.Name = "dateGunSecim2";
            this.dateGunSecim2.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateGunSecim2.Properties.Appearance.Options.UseFont = true;
            this.dateGunSecim2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGunSecim2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGunSecim2.Size = new System.Drawing.Size(357, 40);
            this.dateGunSecim2.TabIndex = 0;
            this.dateGunSecim2.SelectionChanged += new System.EventHandler(this.dateGunSecim2_SelectionChanged);
            // 
            // dateGunSecim
            // 
            this.dateGunSecim.EditValue = null;
            this.dateGunSecim.Location = new System.Drawing.Point(117, 11);
            this.dateGunSecim.Name = "dateGunSecim";
            this.dateGunSecim.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateGunSecim.Properties.Appearance.Options.UseFont = true;
            this.dateGunSecim.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGunSecim.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateGunSecim.Size = new System.Drawing.Size(357, 40);
            this.dateGunSecim.TabIndex = 0;
            this.dateGunSecim.SelectionChanged += new System.EventHandler(this.dateGunSecim_SelectionChanged);
            // 
            // FrmAdisyonHareket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 717);
            this.Controls.Add(this.gridControlAdisyonHareket);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmAdisyonHareket";
            this.Text = "Adisyon Hareketleri";
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunHareketleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAdisyonHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdemeHareketleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAdisyonHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunSecim2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunSecim2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunSecim.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunSecim.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlAdisyonHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridAdisyonHareket;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private UserControls.ControlAnaMenuAlt controlMenu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.DateEdit dateGunSecim;
        private DevExpress.XtraGrid.Columns.GridColumn colAdisyonDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteri;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraGrid.Columns.GridColumn colMasaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colGarson;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirim;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.DateEdit dateGunSecim2;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Views.Grid.GridView gridUrunHareketleri;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colPorsiyon;
        private DevExpress.XtraGrid.Columns.GridColumn colBirim;
        private DevExpress.XtraGrid.Columns.GridColumn colMiktar;
        private DevExpress.XtraGrid.Columns.GridColumn colBirimFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colEkMalzemeFiyat;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunIndirim;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunToplam;
        private DevExpress.XtraGrid.Columns.GridColumn colHareketTip;
        private DevExpress.XtraGrid.Views.Grid.GridView gridOdemeHareketleri;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeSekli;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunSaat;
    }
}