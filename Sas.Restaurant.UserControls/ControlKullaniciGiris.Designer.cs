
namespace Sas.Restaurant.UserControls
{
    partial class ControlKullaniciGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ControlKullaniciGiris));
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.txtKullaniciAdi = new DevExpress.XtraEditors.TextEdit();
            this.txtKullaniciParola = new DevExpress.XtraEditors.TextEdit();
            this.btnKullaniciGiris = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciParola.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(3, 23);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.AllowFocused = false;
            this.pictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.pictureEdit1.Properties.Appearance.Options.UseBackColor = true;
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.pictureEdit1.Properties.ShowMenu = false;
            this.pictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.pictureEdit1.Size = new System.Drawing.Size(583, 339);
            this.pictureEdit1.TabIndex = 0;
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(129, 381);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciAdi.Properties.Appearance.Options.UseFont = true;
            this.txtKullaniciAdi.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtKullaniciAdi.Properties.ContextImageOptions.Image")));
            this.txtKullaniciAdi.Size = new System.Drawing.Size(333, 52);
            this.txtKullaniciAdi.TabIndex = 1;
            // 
            // txtKullaniciParola
            // 
            this.txtKullaniciParola.Location = new System.Drawing.Point(129, 439);
            this.txtKullaniciParola.Name = "txtKullaniciParola";
            this.txtKullaniciParola.Properties.AllowFocused = false;
            this.txtKullaniciParola.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKullaniciParola.Properties.Appearance.Options.UseFont = true;
            this.txtKullaniciParola.Properties.ContextImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("txtKullaniciParola.Properties.ContextImageOptions.Image")));
            this.txtKullaniciParola.Size = new System.Drawing.Size(333, 52);
            this.txtKullaniciParola.TabIndex = 2;
            // 
            // btnKullaniciGiris
            // 
            this.btnKullaniciGiris.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKullaniciGiris.Appearance.Options.UseFont = true;
            this.btnKullaniciGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKullaniciGiris.ImageOptions.Image")));
            this.btnKullaniciGiris.Location = new System.Drawing.Point(129, 497);
            this.btnKullaniciGiris.Name = "btnKullaniciGiris";
            this.btnKullaniciGiris.Size = new System.Drawing.Size(163, 61);
            this.btnKullaniciGiris.TabIndex = 3;
            this.btnKullaniciGiris.Text = "Giriş Yap";
            this.btnKullaniciGiris.Click += new System.EventHandler(this.btnKullaniciGiris_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Appearance.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.simpleButton2.Appearance.Options.UseFont = true;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(299, 497);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(163, 61);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Kapat";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // ControlKullaniciGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.btnKullaniciGiris);
            this.Controls.Add(this.txtKullaniciParola);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.pictureEdit1);
            this.Name = "ControlKullaniciGiris";
            this.Size = new System.Drawing.Size(622, 694);
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKullaniciParola.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.TextEdit txtKullaniciAdi;
        private DevExpress.XtraEditors.TextEdit txtKullaniciParola;
        private DevExpress.XtraEditors.SimpleButton btnKullaniciGiris;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}
