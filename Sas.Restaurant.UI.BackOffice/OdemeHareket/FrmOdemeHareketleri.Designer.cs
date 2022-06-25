
namespace Sas.Restaurant.UI.BackOffice
{
    partial class FrmOdemeHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOdemeHareketleri));
            this.gridOdemeHareketleri = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOdemeTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeSekli = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSaat = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControlAdisyonHareket = new DevExpress.XtraGrid.GridControl();
            this.colTarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdisyonDurum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGarson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIndirim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.dateGunSecim2 = new DevExpress.XtraEditors.DateEdit();
            this.dateGunSecim = new DevExpress.XtraEditors.DateEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.controlMenu = new Sas.Restaurant.UserControls.ControlAnaMenuAlt();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdemeHareketleri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAdisyonHareket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunSecim2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunSecim2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunSecim.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunSecim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
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
            this.gridOdemeHareketleri.GroupCount = 1;
            this.gridOdemeHareketleri.Name = "gridOdemeHareketleri";
            this.gridOdemeHareketleri.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.colOdemeTuru, DevExpress.Data.ColumnSortOrder.Ascending)});
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
            this.colOdemeSekli.VisibleIndex = 0;
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
            this.colOdemeTarih.VisibleIndex = 1;
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
            this.colSaat.VisibleIndex = 2;
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
            this.colOdemeTutar.VisibleIndex = 3;
            this.colOdemeTutar.Width = 177;
            // 
            // gridControlAdisyonHareket
            // 
            this.gridControlAdisyonHareket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAdisyonHareket.Location = new System.Drawing.Point(0, 131);
            this.gridControlAdisyonHareket.MainView = this.gridOdemeHareketleri;
            this.gridControlAdisyonHareket.Name = "gridControlAdisyonHareket";
            this.gridControlAdisyonHareket.Size = new System.Drawing.Size(1185, 486);
            this.gridControlAdisyonHareket.TabIndex = 13;
            this.gridControlAdisyonHareket.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridOdemeHareketleri});
            // 
            // colTarih
            // 
            this.colTarih.Name = "colTarih";
            // 
            // colAdisyonDurum
            // 
            this.colAdisyonDurum.Name = "colAdisyonDurum";
            // 
            // colMusteri
            // 
            this.colMusteri.Name = "colMusteri";
            // 
            // colMasaAdi
            // 
            this.colMasaAdi.Name = "colMasaAdi";
            // 
            // colGarson
            // 
            this.colGarson.Name = "colGarson";
            // 
            // colIndirim
            // 
            this.colIndirim.Name = "colIndirim";
            // 
            // colTutar
            // 
            this.colTutar.Name = "colTutar";
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
            this.panelControl1.TabIndex = 14;
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
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.controlMenu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 617);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1185, 100);
            this.groupControl1.TabIndex = 12;
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
            this.labelControl1.TabIndex = 11;
            this.labelControl1.Text = "Ödeme Hareketleri";
            // 
            // FrmOdemeHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 717);
            this.Controls.Add(this.gridControlAdisyonHareket);
            this.Controls.Add(this.panelControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmOdemeHareketleri";
            this.Text = "FrmOdemeHareketleri";
            ((System.ComponentModel.ISupportInitialize)(this.gridOdemeHareketleri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAdisyonHareket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunSecim2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunSecim2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunSecim.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateGunSecim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlAdisyonHareket;
        private DevExpress.XtraGrid.Views.Grid.GridView gridOdemeHareketleri;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeSekli;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colSaat;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTutar;
        private DevExpress.XtraGrid.Columns.GridColumn colTarih;
        private DevExpress.XtraGrid.Columns.GridColumn colAdisyonDurum;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteri;
        private DevExpress.XtraGrid.Columns.GridColumn colMasaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colGarson;
        private DevExpress.XtraGrid.Columns.GridColumn colIndirim;
        private DevExpress.XtraGrid.Columns.GridColumn colTutar;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.DateEdit dateGunSecim2;
        private DevExpress.XtraEditors.DateEdit dateGunSecim;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private UserControls.ControlAnaMenuAlt controlMenu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}