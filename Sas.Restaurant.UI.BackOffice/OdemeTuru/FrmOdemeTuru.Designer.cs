
namespace Sas.Restaurant.UI.BackOffice.OdemeTuru
{
    partial class FrmOdemeTuru
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
            this.gridControlOdemeTuru = new DevExpress.XtraGrid.GridControl();
            this.gridOdemeTuru = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.controlMenu = new Sas.Restaurant.UserControls.ControlAnaMenuAlt();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.colAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOdemeTuru = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOdemeTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdemeTuru)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControlOdemeTuru
            // 
            this.gridControlOdemeTuru.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlOdemeTuru.Location = new System.Drawing.Point(0, 69);
            this.gridControlOdemeTuru.MainView = this.gridOdemeTuru;
            this.gridControlOdemeTuru.Name = "gridControlOdemeTuru";
            this.gridControlOdemeTuru.Size = new System.Drawing.Size(1185, 548);
            this.gridControlOdemeTuru.TabIndex = 9;
            this.gridControlOdemeTuru.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridOdemeTuru});
            // 
            // gridOdemeTuru
            // 
            this.gridOdemeTuru.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAdi,
            this.colOdemeTuru,
            this.colAciklama});
            this.gridOdemeTuru.GridControl = this.gridControlOdemeTuru;
            this.gridOdemeTuru.Name = "gridOdemeTuru";
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
            this.labelControl1.TabIndex = 7;
            this.labelControl1.Text = "Ödeme Türleri";
            // 
            // colAdi
            // 
            this.colAdi.Caption = "Adı";
            this.colAdi.FieldName = "Adi";
            this.colAdi.MinWidth = 25;
            this.colAdi.Name = "colAdi";
            this.colAdi.Visible = true;
            this.colAdi.VisibleIndex = 0;
            this.colAdi.Width = 94;
            // 
            // colOdemeTuru
            // 
            this.colOdemeTuru.Caption = "Ödeme Türü";
            this.colOdemeTuru.FieldName = "OdemeTur.Adi";
            this.colOdemeTuru.MinWidth = 25;
            this.colOdemeTuru.Name = "colOdemeTuru";
            this.colOdemeTuru.Visible = true;
            this.colOdemeTuru.VisibleIndex = 1;
            this.colOdemeTuru.Width = 94;
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
            // FrmOdemeTuru
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 717);
            this.Controls.Add(this.gridControlOdemeTuru);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "FrmOdemeTuru";
            this.Text = "FrmOdemeTuru";
            ((System.ComponentModel.ISupportInitialize)(this.gridControlOdemeTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridOdemeTuru)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlOdemeTuru;
        private DevExpress.XtraGrid.Views.Grid.GridView gridOdemeTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colOdemeTuru;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private UserControls.ControlAnaMenuAlt controlMenu;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}