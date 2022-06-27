
namespace Sas.Restaurant.UI.BackOffice.AnaMenu
{
    partial class XtraForm1
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
            this.components = new System.ComponentModel.Container();
            this.textEdit1 = new DevExpress.XtraEditors.TextEdit();
            this.alertControl1 = new DevExpress.XtraBars.Alerter.AlertControl(this.components);
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.adornerUIManager1 = new DevExpress.Utils.VisualEffects.AdornerUIManager(this.components);
            this.badge1 = new DevExpress.Utils.VisualEffects.Badge();
            this.controlBadgButton1 = new Sas.Restaurant.UserControls.ControlBadgButton();
            this.controlKeyboard1 = new Sas.Restaurant.UserControls.ControlKeyboard();
            this.controlKullaniciGiris1 = new Sas.Restaurant.UserControls.ControlKullaniciGiris();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adornerUIManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit1
            // 
            this.textEdit1.Location = new System.Drawing.Point(681, 400);
            this.textEdit1.Name = "textEdit1";
            this.textEdit1.Size = new System.Drawing.Size(646, 22);
            this.textEdit1.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(1043, 99);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(212, 114);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "simpleButton1";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // adornerUIManager1
            // 
            this.adornerUIManager1.Elements.Add(this.badge1);
            this.adornerUIManager1.Owner = this;
            // 
            // badge1
            // 
            this.badge1.Properties.Text = "Songul";
            this.badge1.TargetElement = this.simpleButton1;
            // 
            // controlBadgButton1
            // 
            this.controlBadgButton1.BadgeAligment = System.Drawing.ContentAlignment.TopRight;
            this.controlBadgButton1.BadgeBackColor = System.Drawing.Color.Red;
            this.controlBadgButton1.BadgeFont = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.controlBadgButton1.BadgeForeColor = System.Drawing.Color.White;
            this.controlBadgButton1.ContainerControl = this;
            this.controlBadgButton1.Count = 5;
            this.controlBadgButton1.Location = new System.Drawing.Point(993, -9);
            this.controlBadgButton1.Name = "controlBadgButton1";
            this.controlBadgButton1.Size = new System.Drawing.Size(229, 114);
            this.controlBadgButton1.TabIndex = 3;
            this.controlBadgButton1.Text = "controlBadgButton1";
            // 
            // controlKeyboard1
            // 
            this.controlKeyboard1.CapsLock = true;
            this.controlKeyboard1.FocusTextBox = null;
            this.controlKeyboard1.KeyBoardButtonType = Sas.Restaurant.UserControls.KeyBoardButtonType.Standart;
            this.controlKeyboard1.Location = new System.Drawing.Point(681, 428);
            this.controlKeyboard1.Name = "controlKeyboard1";
            this.controlKeyboard1.Size = new System.Drawing.Size(651, 249);
            this.controlKeyboard1.TabIndex = 1;
            // 
            // controlKullaniciGiris1
            // 
            this.controlKullaniciGiris1.Location = new System.Drawing.Point(69, 3);
            this.controlKullaniciGiris1.Name = "controlKullaniciGiris1";
            this.controlKullaniciGiris1.Size = new System.Drawing.Size(551, 607);
            this.controlKullaniciGiris1.TabIndex = 4;
            // 
            // XtraForm1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 689);
            this.Controls.Add(this.controlKullaniciGiris1);
            this.Controls.Add(this.controlBadgButton1);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.controlKeyboard1);
            this.Controls.Add(this.textEdit1);
            this.Name = "XtraForm1";
            this.Text = "XtraForm1";
            ((System.ComponentModel.ISupportInitialize)(this.textEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adornerUIManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit1;
        private UserControls.ControlKeyboard controlKeyboard1;
        private DevExpress.XtraBars.Alerter.AlertControl alertControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.Utils.VisualEffects.AdornerUIManager adornerUIManager1;
        private DevExpress.Utils.VisualEffects.Badge badge1;
        private UserControls.ControlBadgButton controlBadgButton1;
        private UserControls.ControlKullaniciGiris controlKullaniciGiris1;
    }
}