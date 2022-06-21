
namespace Sas.Restaurant.UI.BackOffice.Masa
{
    partial class FrmMasa
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
            this.gridControlMasa = new DevExpress.XtraGrid.GridControl();
            this.gridMasa = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.controlMenu = new Sas.Restaurant.UserControls.ControlAnaMenuAlt();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.colMasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKonum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKapasite = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMasa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlMasa
            // 
            this.gridControlMasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMasa.Location = new System.Drawing.Point(0, 69);
            this.gridControlMasa.MainView = this.gridMasa;
            this.gridControlMasa.Name = "gridControlMasa";
            this.gridControlMasa.Size = new System.Drawing.Size(1185, 548);
            this.gridControlMasa.TabIndex = 6;
            this.gridControlMasa.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridMasa});
            // 
            // gridMasa
            // 
            this.gridMasa.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colMasaAdi,
            this.colKonum,
            this.colKapasite,
            this.colAciklama});
            this.gridMasa.GridControl = this.gridControlMasa;
            this.gridMasa.Name = "gridMasa";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.controlMenu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 617);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1185, 100);
            this.groupControl1.TabIndex = 5;
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
            this.controlMenu.ButtonEkle += new System.EventHandler(this.controlMenu_ButtonEkle);
            this.controlMenu.ButtonDuzenle += new System.EventHandler(this.controlMenu_ButtonDuzenle);
            this.controlMenu.ButtonSil += new System.EventHandler(this.controlMenu_ButtonSil);
            this.controlMenu.ButtonGuncelle += new System.EventHandler(this.controlMenu_ButtonGuncelle);
            this.controlMenu.ButtonKapat += new System.EventHandler(this.controlMenu_ButtonKapat);
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
            this.labelControl1.Size = new System.Drawing.Size(1185, 69);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Masalar";
            // 
            // colMasaAdi
            // 
            this.colMasaAdi.Caption = "Masa Adı";
            this.colMasaAdi.FieldName = "Adi";
            this.colMasaAdi.MinWidth = 25;
            this.colMasaAdi.Name = "colMasaAdi";
            this.colMasaAdi.Visible = true;
            this.colMasaAdi.VisibleIndex = 0;
            this.colMasaAdi.Width = 288;
            // 
            // colKonum
            // 
            this.colKonum.Caption = "Konumu";
            this.colKonum.FieldName = "Konum.Adi";
            this.colKonum.MinWidth = 25;
            this.colKonum.Name = "colKonum";
            this.colKonum.Visible = true;
            this.colKonum.VisibleIndex = 1;
            this.colKonum.Width = 288;
            // 
            // colKapasite
            // 
            this.colKapasite.Caption = "Kapasite";
            this.colKapasite.FieldName = "Kapasite";
            this.colKapasite.MinWidth = 25;
            this.colKapasite.Name = "colKapasite";
            this.colKapasite.Visible = true;
            this.colKapasite.VisibleIndex = 2;
            this.colKapasite.Width = 117;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.MinWidth = 25;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 3;
            this.colAciklama.Width = 462;
            // 
            // FrmMasa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 717);
            this.Controls.Add(this.gridControlMasa);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmMasa";
            this.Text = "FrmMasa";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridMasa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlMasa;
        private DevExpress.XtraGrid.Views.Grid.GridView gridMasa;
        private DevExpress.XtraGrid.Columns.GridColumn colMasaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colKonum;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private UserControls.ControlAnaMenuAlt controlMenu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn colKapasite;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
    }
}