
namespace Sas.Restaurant.UI.BackOffice.Kullanici
{
    partial class FrmKullanicilar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKullanicilar));
            this.controlKullaniciMenu = new Sas.Restaurant.UserControls.ControlMenuKayit();
            this.gridControlKullanicilar = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKullaniciAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYetki = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupKullaniciBilgi = new DevExpress.XtraEditors.GroupControl();
            this.txtParolaTekrar = new DevExpress.XtraEditors.TextEdit();
            this.txtParola = new DevExpress.XtraEditors.TextEdit();
            this.lookYetki = new DevExpress.XtraEditors.LookUpEdit();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKullanicilar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupKullaniciBilgi)).BeginInit();
            this.groupKullaniciBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtParolaTekrar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookYetki.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // controlKullaniciMenu
            // 
            this.controlKullaniciMenu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.controlKullaniciMenu.KapatVisibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            this.controlKullaniciMenu.KayitAc = false;
            this.controlKullaniciMenu.Location = new System.Drawing.Point(0, 619);
            this.controlKullaniciMenu.Name = "controlKullaniciMenu";
            this.controlKullaniciMenu.SecVisibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            this.controlKullaniciMenu.Size = new System.Drawing.Size(961, 82);
            this.controlKullaniciMenu.TabIndex = 0;
            this.controlKullaniciMenu.EkleClick += new System.EventHandler(this.controlKullaniciMenu_EkleClick);
            this.controlKullaniciMenu.DuzenleClick += new System.EventHandler(this.controlKullaniciMenu_DuzenleClick);
            this.controlKullaniciMenu.SilClick += new System.EventHandler(this.controlKullaniciMenu_SilClick);
            this.controlKullaniciMenu.KaydetClick += new System.EventHandler(this.controlKullaniciMenu_KaydetClick);
            this.controlKullaniciMenu.VazgecClick += new System.EventHandler(this.controlKullaniciMenu_VazgecClick);
            this.controlKullaniciMenu.KapatClick += new System.EventHandler(this.controlKullaniciMenu_KapatClick);
            // 
            // gridControlKullanicilar
            // 
            this.gridControlKullanicilar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlKullanicilar.Location = new System.Drawing.Point(0, 309);
            this.gridControlKullanicilar.MainView = this.gridView1;
            this.gridControlKullanicilar.Name = "gridControlKullanicilar";
            this.gridControlKullanicilar.Size = new System.Drawing.Size(961, 310);
            this.gridControlKullanicilar.TabIndex = 1;
            this.gridControlKullanicilar.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKullaniciAdi,
            this.colYetki,
            this.colAciklama});
            this.gridView1.GridControl = this.gridControlKullanicilar;
            this.gridView1.Name = "gridView1";
            // 
            // colKullaniciAdi
            // 
            this.colKullaniciAdi.Caption = "KUllanıcı Adı";
            this.colKullaniciAdi.FieldName = "KullaniciAdi";
            this.colKullaniciAdi.MinWidth = 25;
            this.colKullaniciAdi.Name = "colKullaniciAdi";
            this.colKullaniciAdi.Visible = true;
            this.colKullaniciAdi.VisibleIndex = 0;
            this.colKullaniciAdi.Width = 94;
            // 
            // colYetki
            // 
            this.colYetki.Caption = "Yetkisi";
            this.colYetki.FieldName = "KullaniciRol";
            this.colYetki.MinWidth = 25;
            this.colYetki.Name = "colYetki";
            this.colYetki.Visible = true;
            this.colYetki.VisibleIndex = 1;
            this.colYetki.Width = 94;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.MinWidth = 25;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 2;
            this.colAciklama.Width = 94;
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
            this.labelControl1.Size = new System.Drawing.Size(961, 69);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Kullanıcılar";
            // 
            // groupKullaniciBilgi
            // 
            this.groupKullaniciBilgi.Controls.Add(this.txtParolaTekrar);
            this.groupKullaniciBilgi.Controls.Add(this.txtParola);
            this.groupKullaniciBilgi.Controls.Add(this.lookYetki);
            this.groupKullaniciBilgi.Controls.Add(this.txtAciklama);
            this.groupKullaniciBilgi.Controls.Add(this.labelControl9);
            this.groupKullaniciBilgi.Controls.Add(this.txtKullaniciAdi);
            this.groupKullaniciBilgi.Controls.Add(this.labelControl3);
            this.groupKullaniciBilgi.Controls.Add(this.labelControl2);
            this.groupKullaniciBilgi.Controls.Add(this.labelControl7);
            this.groupKullaniciBilgi.Controls.Add(this.labelControl6);
            this.groupKullaniciBilgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupKullaniciBilgi.Location = new System.Drawing.Point(0, 69);
            this.groupKullaniciBilgi.Name = "groupKullaniciBilgi";
            this.groupKullaniciBilgi.Size = new System.Drawing.Size(961, 240);
            this.groupKullaniciBilgi.TabIndex = 6;
            this.groupKullaniciBilgi.Text = "Kullanıcı Bilgisi";
            this.groupKullaniciBilgi.Visible = false;
            // 
            // txtParolaTekrar
            // 
            this.txtParolaTekrar.Location = new System.Drawing.Point(140, 106);
            this.txtParolaTekrar.Name = "txtParolaTekrar";
            this.txtParolaTekrar.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParolaTekrar.Properties.Appearance.Options.UseFont = true;
            this.txtParolaTekrar.Size = new System.Drawing.Size(359, 22);
            this.txtParolaTekrar.TabIndex = 4;
            // 
            // txtParola
            // 
            this.txtParola.Location = new System.Drawing.Point(140, 78);
            this.txtParola.Name = "txtParola";
            this.txtParola.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParola.Properties.Appearance.Options.UseFont = true;
            this.txtParola.Size = new System.Drawing.Size(359, 22);
            this.txtParola.TabIndex = 4;
            // 
            // lookYetki
            // 
            this.lookYetki.Location = new System.Drawing.Point(140, 134);
            this.lookYetki.Name = "lookYetki";
            this.lookYetki.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookYetki.Properties.NullText = "Lütfen BirTelefon Tipi Seçin";
            this.lookYetki.Properties.ShowFooter = false;
            this.lookYetki.Size = new System.Drawing.Size(788, 22);
            this.lookYetki.TabIndex = 0;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(140, 162);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(788, 71);
            this.txtAciklama.TabIndex = 3;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Options.UseTextOptions = true;
            this.labelControl9.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl9.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl9.Location = new System.Drawing.Point(12, 161);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(122, 71);
            this.labelControl9.TabIndex = 3;
            this.labelControl9.Text = "Açıklama :";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(140, 47);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.txtKullaniciAdi.Size = new System.Drawing.Size(788, 22);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Options.UseTextOptions = true;
            this.labelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl3.Location = new System.Drawing.Point(12, 133);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(122, 22);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Kullanıcı Yetki :";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(12, 105);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(122, 22);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Parola Tekrar :";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Options.UseTextOptions = true;
            this.labelControl7.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl7.Location = new System.Drawing.Point(12, 47);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(122, 22);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Kullanıcı Adı :";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl6.Location = new System.Drawing.Point(12, 77);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(122, 22);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Parola :";
            // 
            // FrmKullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 701);
            this.Controls.Add(this.gridControlKullanicilar);
            this.Controls.Add(this.groupKullaniciBilgi);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.controlKullaniciMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKullanicilar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmKullanicilar";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlKullanicilar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupKullaniciBilgi)).EndInit();
            this.groupKullaniciBilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtParolaTekrar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtParola.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookYetki.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private UserControls.ControlMenuKayit controlKullaniciMenu;
        private DevExpress.XtraGrid.GridControl gridControlKullanicilar;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colKullaniciAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colYetki;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraEditors.GroupControl groupKullaniciBilgi;
        private DevExpress.XtraEditors.TextEdit txtParola;
        private DevExpress.XtraEditors.LookUpEdit lookYetki;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit txtParolaTekrar;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
    }
}