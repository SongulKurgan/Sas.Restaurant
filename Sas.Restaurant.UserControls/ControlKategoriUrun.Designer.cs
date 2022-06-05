
namespace Sas.Restaurant.UserControls
{
    partial class ControlKategoriUrun
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
            this.groupBase = new DevExpress.XtraEditors.GroupControl();
            this.picFoto = new DevExpress.XtraEditors.PictureEdit();
            this.lblAciklama = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupBase)).BeginInit();
            this.groupBase.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFoto.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBase
            // 
            this.groupBase.Controls.Add(this.picFoto);
            this.groupBase.Controls.Add(this.lblAciklama);
            this.groupBase.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBase.Location = new System.Drawing.Point(0, 0);
            this.groupBase.Name = "groupBase";
            this.groupBase.Size = new System.Drawing.Size(301, 306);
            this.groupBase.TabIndex = 0;
            this.groupBase.Text = "groupControl1";
            this.groupBase.Click += new System.EventHandler(this.groupBase_Click);
            // 
            // picFoto
            // 
            this.picFoto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picFoto.Location = new System.Drawing.Point(2, 28);
            this.picFoto.Name = "picFoto";
            this.picFoto.Properties.AllowFocused = false;
            this.picFoto.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.picFoto.Properties.Appearance.Options.UseBackColor = true;
            this.picFoto.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.picFoto.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picFoto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.picFoto.Size = new System.Drawing.Size(297, 224);
            this.picFoto.TabIndex = 0;
            this.picFoto.Click += new System.EventHandler(this.picFoto_Click);
            // 
            // lblAciklama
            // 
            this.lblAciklama.Appearance.Options.UseTextOptions = true;
            this.lblAciklama.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblAciklama.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblAciklama.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblAciklama.Location = new System.Drawing.Point(2, 252);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(297, 52);
            this.lblAciklama.TabIndex = 1;
            this.lblAciklama.Click += new System.EventHandler(this.lblAciklama_Click);
            // 
            // ControlKategoriUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBase);
            this.Name = "ControlKategoriUrun";
            this.Size = new System.Drawing.Size(301, 306);
            ((System.ComponentModel.ISupportInitialize)(this.groupBase)).EndInit();
            this.groupBase.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picFoto.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupBase;
        private DevExpress.XtraEditors.LabelControl lblAciklama;
        private DevExpress.XtraEditors.PictureEdit picFoto;
    }
}
