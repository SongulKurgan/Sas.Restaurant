
namespace Sas.Restaurant.UI.BackOffice.Urun
{
    partial class FrmUrun
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUrun));
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.controlAnaMenu = new Sas.Restaurant.UserControls.ControlAnaMenuAlt();
            this.gridControlUrunler = new DevExpress.XtraGrid.GridControl();
            this.gridUrunler = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.collFotograf = new DevExpress.XtraGrid.Columns.GridColumn();
            this.picFotograf = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.collAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collBarkod = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collurunGrup = new DevExpress.XtraGrid.Columns.GridColumn();
            this.collFotografEkle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnFotografEkle = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotograf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFotografEkle)).BeginInit();
            this.SuspendLayout();
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
            this.labelControl1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("labelControl1.ImageOptions.Image")));
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1261, 69);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ürünler";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.controlAnaMenu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 649);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1261, 100);
            this.groupControl1.TabIndex = 1;
            this.groupControl1.Text = "Menü";
            // 
            // controlAnaMenu
            // 
            this.controlAnaMenu.ButtonFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.controlAnaMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlAnaMenu.Location = new System.Drawing.Point(2, 28);
            this.controlAnaMenu.Name = "controlAnaMenu";
            this.controlAnaMenu.Size = new System.Drawing.Size(1257, 70);
            this.controlAnaMenu.TabIndex = 0;
            this.controlAnaMenu.ButtonEkle += new System.EventHandler(this.controlAnaMenu_ButtonEkle);
            this.controlAnaMenu.ButtonDuzenle += new System.EventHandler(this.controlAnaMenu_ButtonDuzenle);
            this.controlAnaMenu.ButtonSil += new System.EventHandler(this.controlAnaMenu_ButtonSil);
            this.controlAnaMenu.ButtonGuncelle += new System.EventHandler(this.controlAnaMenu_ButtonGuncelle);
            this.controlAnaMenu.ButtonKapat += new System.EventHandler(this.controlAnaMenu_ButtonKapat);
            // 
            // gridControlUrunler
            // 
            this.gridControlUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlUrunler.Location = new System.Drawing.Point(0, 69);
            this.gridControlUrunler.MainView = this.gridUrunler;
            this.gridControlUrunler.Name = "gridControlUrunler";
            this.gridControlUrunler.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.btnFotografEkle,
            this.picFotograf});
            this.gridControlUrunler.Size = new System.Drawing.Size(1261, 580);
            this.gridControlUrunler.TabIndex = 2;
            this.gridControlUrunler.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridUrunler});
            // 
            // gridUrunler
            // 
            this.gridUrunler.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.collFotograf,
            this.collAdi,
            this.collBarkod,
            this.collurunGrup,
            this.collFotografEkle});
            this.gridUrunler.GridControl = this.gridControlUrunler;
            this.gridUrunler.Name = "gridUrunler";
            this.gridUrunler.RowHeight = 100;
            // 
            // collFotograf
            // 
            this.collFotograf.Caption = "Fotograf";
            this.collFotograf.ColumnEdit = this.picFotograf;
            this.collFotograf.FieldName = "Fotograf";
            this.collFotograf.MaxWidth = 150;
            this.collFotograf.MinWidth = 150;
            this.collFotograf.Name = "collFotograf";
            this.collFotograf.OptionsColumn.AllowEdit = false;
            this.collFotograf.Visible = true;
            this.collFotograf.VisibleIndex = 0;
            this.collFotograf.Width = 150;
            // 
            // picFotograf
            // 
            this.picFotograf.Name = "picFotograf";
            this.picFotograf.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // collAdi
            // 
            this.collAdi.Caption = "Ürün Adı";
            this.collAdi.FieldName = "Adi";
            this.collAdi.MinWidth = 25;
            this.collAdi.Name = "collAdi";
            this.collAdi.OptionsColumn.AllowEdit = false;
            this.collAdi.Visible = true;
            this.collAdi.VisibleIndex = 2;
            this.collAdi.Width = 94;
            // 
            // collBarkod
            // 
            this.collBarkod.Caption = "Barkodu";
            this.collBarkod.FieldName = "Barkod";
            this.collBarkod.MinWidth = 25;
            this.collBarkod.Name = "collBarkod";
            this.collBarkod.OptionsColumn.AllowEdit = false;
            this.collBarkod.Visible = true;
            this.collBarkod.VisibleIndex = 1;
            this.collBarkod.Width = 94;
            // 
            // collurunGrup
            // 
            this.collurunGrup.Caption = "Kategori";
            this.collurunGrup.FieldName = "UrunGrup.Adi";
            this.collurunGrup.MinWidth = 25;
            this.collurunGrup.Name = "collurunGrup";
            this.collurunGrup.OptionsColumn.AllowEdit = false;
            this.collurunGrup.Visible = true;
            this.collurunGrup.VisibleIndex = 3;
            this.collurunGrup.Width = 94;
            // 
            // collFotografEkle
            // 
            this.collFotografEkle.Caption = "Fotograf Ekle";
            this.collFotografEkle.ColumnEdit = this.btnFotografEkle;
            this.collFotografEkle.MaxWidth = 80;
            this.collFotografEkle.MinWidth = 80;
            this.collFotografEkle.Name = "collFotografEkle";
            this.collFotografEkle.Visible = true;
            this.collFotografEkle.VisibleIndex = 4;
            this.collFotografEkle.Width = 80;
            // 
            // btnFotografEkle
            // 
            this.btnFotografEkle.AutoHeight = false;
            editorButtonImageOptions1.Image = ((System.Drawing.Image)(resources.GetObject("editorButtonImageOptions1.Image")));
            this.btnFotografEkle.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.btnFotografEkle.Name = "btnFotografEkle";
            this.btnFotografEkle.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.btnFotografEkle.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.btnFotografEkle_ButtonClick);
            // 
            // FrmUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 749);
            this.Controls.Add(this.gridControlUrunler);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmUrun";
            this.Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridUrunler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFotograf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnFotografEkle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlUrunler;
        private DevExpress.XtraGrid.Views.Grid.GridView gridUrunler;
        private DevExpress.XtraGrid.Columns.GridColumn collFotograf;
        private DevExpress.XtraGrid.Columns.GridColumn collAdi;
        private DevExpress.XtraGrid.Columns.GridColumn collBarkod;
        private DevExpress.XtraGrid.Columns.GridColumn collurunGrup;
        private DevExpress.XtraGrid.Columns.GridColumn collFotografEkle;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit btnFotografEkle;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit picFotograf;
        private UserControls.ControlAnaMenuAlt controlAnaMenu;
    }
}