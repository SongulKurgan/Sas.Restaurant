
namespace Sas.Restaurant.UI.BackOffice.Musteri
{
    partial class FrmMusteri
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlMusteri = new DevExpress.XtraGrid.GridControl();
            this.gridMusteri = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colKartNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoyadi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSirket = new DevExpress.XtraGrid.Columns.GridColumn();
            this.controlMenu = new Sas.Restaurant.UserControls.ControlAnaMenuAlt();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMusteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMusteri)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1261, 69);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ürünler";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.controlMenu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 649);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1261, 100);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Menü";
            // 
            // gridControlMusteri
            // 
            this.gridControlMusteri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMusteri.Location = new System.Drawing.Point(0, 69);
            this.gridControlMusteri.MainView = this.gridMusteri;
            this.gridControlMusteri.Name = "gridControlMusteri";
            this.gridControlMusteri.Size = new System.Drawing.Size(1261, 580);
            this.gridControlMusteri.TabIndex = 3;
            this.gridControlMusteri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMusteri});
            // 
            // gridMusteri
            // 
            this.gridMusteri.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colKartNo,
            this.colAdi,
            this.colSoyadi,
            this.colSirket});
            this.gridMusteri.GridControl = this.gridControlMusteri;
            this.gridMusteri.Name = "gridMusteri";
            // 
            // colKartNo
            // 
            this.colKartNo.Caption = "Kart No";
            this.colKartNo.FieldName = "KartNo";
            this.colKartNo.MinWidth = 25;
            this.colKartNo.Name = "colKartNo";
            this.colKartNo.Visible = true;
            this.colKartNo.VisibleIndex = 0;
            this.colKartNo.Width = 94;
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.MinWidth = 25;
            this.colAdi.Name = "colAdi";
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 1;
            this.colAdi.Width = 94;
            // 
            // colSoyadi
            // 
            this.colSoyadi.Caption = "Soyadı";
            this.colSoyadi.FieldName = "Soyadi";
            this.colSoyadi.MinWidth = 25;
            this.colSoyadi.Name = "colSoyadi";
            this.colSoyadi.Visible = true;
            this.colSoyadi.VisibleIndex = 2;
            this.colSoyadi.Width = 94;
            // 
            // colSirket
            // 
            this.colSirket.Caption = "Şirket Adı";
            this.colSirket.FieldName = "Sirket";
            this.colSirket.MinWidth = 25;
            this.colSirket.Name = "colSirket";
            this.colSirket.Visible = true;
            this.colSirket.VisibleIndex = 3;
            this.colSirket.Width = 94;
            // 
            // controlMenu
            // 
            this.controlMenu.ButtonFont = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.controlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlMenu.Location = new System.Drawing.Point(2, 28);
            this.controlMenu.Name = "controlMenu";
            this.controlMenu.Size = new System.Drawing.Size(1257, 70);
            this.controlMenu.TabIndex = 0;
            this.controlMenu.ButtonEkle += new System.EventHandler(this.controlMenu_ButtonEkle);
            this.controlMenu.ButtonDuzenle += new System.EventHandler(this.controlMenu_ButtonDuzenle);
            this.controlMenu.ButtonSil += new System.EventHandler(this.controlMenu_ButtonSil);
            this.controlMenu.ButtonGuncelle += new System.EventHandler(this.controlMenu_ButtonGuncelle);
            this.controlMenu.ButtonKapat += new System.EventHandler(this.controlMenu_ButtonKapat);
            // 
            // FrmMusteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 749);
            this.Controls.Add(this.gridControlMusteri);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmMusteri";
            this.Text = "FrmMusteri";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMusteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMusteri)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridControlMusteri;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMusteri;
        private DevExpress.XtraGrid.Columns.GridColumn colKartNo;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colSoyadi;
        private DevExpress.XtraGrid.Columns.GridColumn colSirket;
        private UserControls.ControlAnaMenuAlt controlMenu;
    }
}