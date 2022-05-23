
namespace Sas.Restaurant.UI.BackOffice.Tanim
{
    partial class FrmTanim
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
            this.groupTanimBilgi = new DevExpress.XtraEditors.GroupControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtTanim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.controlMenu = new Sas.Restaurant.UserControls.ControlMenuKayit();
            this.gridControlTanim = new DevExpress.XtraGrid.GridControl();
            this.gridTanim = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTanim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupTanimBilgi)).BeginInit();
            this.groupTanimBilgi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTanim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTanim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTanim)).BeginInit();
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
            this.labelControl1.Size = new System.Drawing.Size(895, 69);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ürünler";
            // 
            // groupTanimBilgi
            // 
            this.groupTanimBilgi.Controls.Add(this.txtAciklama);
            this.groupTanimBilgi.Controls.Add(this.labelControl2);
            this.groupTanimBilgi.Controls.Add(this.txtTanim);
            this.groupTanimBilgi.Controls.Add(this.labelControl6);
            this.groupTanimBilgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupTanimBilgi.Location = new System.Drawing.Point(0, 69);
            this.groupTanimBilgi.Name = "groupTanimBilgi";
            this.groupTanimBilgi.Size = new System.Drawing.Size(895, 176);
            this.groupTanimBilgi.TabIndex = 2;
            this.groupTanimBilgi.Text = "Tanim İşlemleri";
            this.groupTanimBilgi.Visible = false;
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Options.UseTextOptions = true;
            this.labelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl6.Location = new System.Drawing.Point(12, 48);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(127, 22);
            this.labelControl6.TabIndex = 2;
            this.labelControl6.Text = "Tanım";
            // 
            // txtTanim
            // 
            this.txtTanim.Location = new System.Drawing.Point(145, 48);
            this.txtTanim.Name = "txtTanim";
            this.txtTanim.Size = new System.Drawing.Size(738, 22);
            this.txtTanim.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Options.UseTextOptions = true;
            this.labelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.labelControl2.Location = new System.Drawing.Point(12, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(127, 95);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(145, 75);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(738, 96);
            this.txtAciklama.TabIndex = 5;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.controlMenu);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl2.Location = new System.Drawing.Point(0, 245);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(895, 72);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Menu";
            // 
            // controlMenu
            // 
            this.controlMenu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlMenu.KapatVisibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            this.controlMenu.KayitAc = false;
            this.controlMenu.Location = new System.Drawing.Point(2, 28);
            this.controlMenu.Name = "controlMenu";
            this.controlMenu.SecVisibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always;
            this.controlMenu.Size = new System.Drawing.Size(891, 42);
            this.controlMenu.TabIndex = 0;
            this.controlMenu.SecClick += new System.EventHandler(this.controlMenu_SecClick);
            this.controlMenu.EkleClick += new System.EventHandler(this.controlMenu_EkleClick);
            this.controlMenu.DuzenleClick += new System.EventHandler(this.controlMenu_DuzenleClick);
            this.controlMenu.SilClick += new System.EventHandler(this.controlMenu_SilClick);
            this.controlMenu.KaydetClick += new System.EventHandler(this.controlMenu_KaydetClick);
            this.controlMenu.VazgecClick += new System.EventHandler(this.controlMenu_VazgecClick);
            this.controlMenu.KapatClick += new System.EventHandler(this.controlMenu_KapatClick);
            // 
            // gridControlTanim
            // 
            this.gridControlTanim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTanim.Location = new System.Drawing.Point(0, 317);
            this.gridControlTanim.MainView = this.gridTanim;
            this.gridControlTanim.Name = "gridControlTanim";
            this.gridControlTanim.Size = new System.Drawing.Size(895, 389);
            this.gridControlTanim.TabIndex = 4;
            this.gridControlTanim.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridTanim});
            // 
            // gridTanim
            // 
            this.gridTanim.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTanim,
            this.colAciklama});
            this.gridTanim.GridControl = this.gridControlTanim;
            this.gridTanim.Name = "gridTanim";
            this.gridTanim.OptionsView.ShowAutoFilterRow = true;
            this.gridTanim.OptionsView.ShowGroupPanel = false;
            // 
            // colTanim
            // 
            this.colTanim.Caption = "Tanım";
            this.colTanim.FieldName = "Adi";
            this.colTanim.MinWidth = 25;
            this.colTanim.Name = "colTanim";
            this.colTanim.OptionsColumn.AllowEdit = false;
            this.colTanim.Visible = true;
            this.colTanim.VisibleIndex = 0;
            this.colTanim.Width = 94;
            // 
            // colAciklama
            // 
            this.colAciklama.Caption = "Açıklama";
            this.colAciklama.FieldName = "Aciklama";
            this.colAciklama.MinWidth = 25;
            this.colAciklama.Name = "colAciklama";
            this.colAciklama.OptionsColumn.AllowEdit = false;
            this.colAciklama.Visible = true;
            this.colAciklama.VisibleIndex = 1;
            this.colAciklama.Width = 94;
            // 
            // FrmTanim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 706);
            this.Controls.Add(this.gridControlTanim);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupTanimBilgi);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTanim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmTanim";
            ((System.ComponentModel.ISupportInitialize)(this.groupTanimBilgi)).EndInit();
            this.groupTanimBilgi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtTanim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTanim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridTanim)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupTanimBilgi;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTanim;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private UserControls.ControlMenuKayit controlMenu;
        private DevExpress.XtraGrid.GridControl gridControlTanim;
        private DevExpress.XtraGrid.Views.Grid.GridView gridTanim;
        private DevExpress.XtraGrid.Columns.GridColumn colTanim;
        private DevExpress.XtraGrid.Columns.GridColumn colAciklama;
    }
}