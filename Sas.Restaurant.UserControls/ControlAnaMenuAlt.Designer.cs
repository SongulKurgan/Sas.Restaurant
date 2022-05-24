
namespace Sas.Restaurant.UserControls
{
    partial class ControlAnaMenuAlt
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlAnaMenuAlt));
            this.btnEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnDüzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnGüncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnEkle
            // 
            this.btnEkle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnEkle.Location = new System.Drawing.Point(0, 0);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnEkle.Size = new System.Drawing.Size(127, 77);
            this.btnEkle.TabIndex = 0;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnDüzenle
            // 
            this.btnDüzenle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDüzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnDüzenle.Location = new System.Drawing.Point(127, 0);
            this.btnDüzenle.Name = "btnDüzenle";
            this.btnDüzenle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnDüzenle.Size = new System.Drawing.Size(127, 77);
            this.btnDüzenle.TabIndex = 1;
            this.btnDüzenle.Text = "Düzenle";
            this.btnDüzenle.Click += new System.EventHandler(this.btnDüzenle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(254, 0);
            this.btnSil.Name = "btnSil";
            this.btnSil.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnSil.Size = new System.Drawing.Size(127, 77);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGüncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.btnGüncelle.Location = new System.Drawing.Point(381, 0);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnGüncelle.Size = new System.Drawing.Size(127, 77);
            this.btnGüncelle.TabIndex = 3;
            this.btnGüncelle.Text = "Güncelle";
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(990, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKapat.Size = new System.Drawing.Size(127, 77);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // ControlAnaMenuAlt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnDüzenle);
            this.Controls.Add(this.btnEkle);
            this.Name = "ControlAnaMenuAlt";
            this.Size = new System.Drawing.Size(1117, 77);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnEkle;
        private DevExpress.XtraEditors.SimpleButton btnDüzenle;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnGüncelle;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
    }
}
