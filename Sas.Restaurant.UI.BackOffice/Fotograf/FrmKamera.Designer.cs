
namespace Sas.Restaurant.UI.BackOffice.Fotograf
{
    partial class FrmKamera
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKamera));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnGoruntuAl = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnAktar = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.picFoto = new DevExpress.XtraEditors.PictureEdit();
            this.Camera = new DevExpress.XtraEditors.Camera.CameraControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnAktar);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnGoruntuAl);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 396);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1004, 90);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Menu";
            // 
            // btnGoruntuAl
            // 
            this.btnGoruntuAl.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnGoruntuAl.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnGoruntuAl.Location = new System.Drawing.Point(2, 28);
            this.btnGoruntuAl.Name = "btnGoruntuAl";
            this.btnGoruntuAl.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnGoruntuAl.Size = new System.Drawing.Size(131, 60);
            this.btnGoruntuAl.TabIndex = 0;
            this.btnGoruntuAl.Text = "Görüntü Al";
            this.btnGoruntuAl.Click += new System.EventHandler(this.btnGoruntuAl_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(871, 28);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnKapat.Size = new System.Drawing.Size(131, 60);
            this.btnKapat.TabIndex = 1;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnAktar
            // 
            this.btnAktar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAktar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.btnAktar.Location = new System.Drawing.Point(740, 28);
            this.btnAktar.Name = "btnAktar";
            this.btnAktar.PaintStyle = DevExpress.XtraEditors.Controls.PaintStyles.Light;
            this.btnAktar.Size = new System.Drawing.Size(131, 60);
            this.btnAktar.TabIndex = 2;
            this.btnAktar.Text = "Aktar";
            this.btnAktar.Click += new System.EventHandler(this.btnAktar_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.Camera);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.picFoto);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1004, 396);
            this.splitContainerControl1.SplitterPosition = 500;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // picFoto
            // 
            this.picFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFoto.Location = new System.Drawing.Point(0, 0);
            this.picFoto.Name = "picFoto";
            this.picFoto.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picFoto.Size = new System.Drawing.Size(492, 396);
            this.picFoto.TabIndex = 0;
            // 
            // Camera
            // 
            this.Camera.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Camera.Location = new System.Drawing.Point(0, 0);
            this.Camera.Name = "Camera";
            this.Camera.Size = new System.Drawing.Size(500, 396);
            this.Camera.TabIndex = 0;
            this.Camera.Text = "cameraControl1";
            // 
            // FrmKamera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1004, 486);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKamera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmKamera";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnAktar;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnGoruntuAl;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.Camera.CameraControl Camera;
        private DevExpress.XtraEditors.PictureEdit picFoto;
    }
}